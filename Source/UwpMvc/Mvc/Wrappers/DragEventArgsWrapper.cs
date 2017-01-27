// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.DataTransfer;
using Windows.Foundation;
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DragEventArgs"/>
    /// resolved by <see cref="IDragEventArgsResolver"/>.
    /// </summary>
    public static class DragEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragEventArgsResolver"/>
        /// that resolves data of the <see cref="DragEventArgs"/>.
        /// </summary>
        public static IDragEventArgsResolver Resolver { get; set; } = new DefaultDragEventArgsResolver();

        /// <summary>
        /// Gets a data object (<see cref="DataPackage"/>) that contains the data associated
        /// with the corresponding drag event. This value is not useful in all event cases;
        /// specifically, the event must be handled by a valid drop target.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <returns>
        /// The data object that contains data payload that is associated with the corresponding
        /// drag event.
        /// </returns>
        public static DataPackage Data(this DragEventArgs e) => Resolver.Data(e);

        /// <summary>
        /// Sets a data object (<see cref="DataPackage"/>) that contains the data associated
        /// with the corresponding drag event. This value is not useful in all event cases;
        /// specifically, the event must be handled by a valid drop target.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <param name="data">
        /// The data object that contains data payload that is associated with the corresponding
        /// drag event.
        /// </param>
        public static void Data(this DragEventArgs e, DataPackage data) => Resolver.Data(e, data);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this DragEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this DragEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this DragEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets a drop point that is relative to a specified <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// The <see cref="UIElement"/> for which to get a relative drop point.
        /// </param>
        /// <returns>
        /// A point in the coordinate system that is relative to the element specified in <paramref name="relativeTo"/>.
        /// </returns>
        public static Point GetPositionWrapped(this DragEventArgs e, UIElement relativeTo) => Resolver.GetPosition(e, relativeTo);

        private sealed class DefaultDragEventArgsResolver : IDragEventArgsResolver
        {
            DataPackage IDragEventArgsResolver.Data(DragEventArgs e) => e.Data;
            void IDragEventArgsResolver.Data(DragEventArgs e, DataPackage data) => e.Data = data;
            bool IDragEventArgsResolver.Handled(DragEventArgs e) => e.Handled;
            void IDragEventArgsResolver.Handled(DragEventArgs e, bool handled) => e.Handled = handled;
            object IDragEventArgsResolver.OriginalSource(DragEventArgs e) => e.OriginalSource;
            Point IDragEventArgsResolver.GetPosition(DragEventArgs e, UIElement relativeTo) => e.GetPosition(relativeTo);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DragEventArgs"/>.
    /// </summary>
    public interface IDragEventArgsResolver
    {
        /// <summary>
        /// Gets a data object (<see cref="DataPackage"/>) that contains the data associated
        /// with the corresponding drag event. This value is not useful in all event cases;
        /// specifically, the event must be handled by a valid drop target.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <returns>
        /// The data object that contains data payload that is associated with the corresponding
        /// drag event.
        /// </returns>
        DataPackage Data(DragEventArgs e);

        /// <summary>
        /// Sets a data object (<see cref="DataPackage"/>) that contains the data associated
        /// with the corresponding drag event. This value is not useful in all event cases;
        /// specifically, the event must be handled by a valid drop target.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <param name="data">
        /// The data object that contains data payload that is associated with the corresponding
        /// drag event.
        /// </param>
        void Data(DragEventArgs e, DataPackage data);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(DragEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(DragEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(DragEventArgs e);

        /// <summary>
        /// Gets a drop point that is relative to a specified <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="DragEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// The <see cref="UIElement"/> for which to get a relative drop point.
        /// </param>
        /// <returns>
        /// A point in the coordinate system that is relative to the element specified in <paramref name="relativeTo"/>.
        /// </returns>
        Point GetPosition(DragEventArgs e, UIElement relativeTo);
    }
}
