// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DoubleTappedRoutedEventArgs"/>
    /// resolved by <see cref="IDoubleTappedRoutedEventArgsResolver"/>.
    /// </summary>
    public static class DoubleTappedRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDoubleTappedRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="DoubleTappedRoutedEventArgs"/>.
        /// </summary>
        public static IDoubleTappedRoutedEventArgsResolver Resolver { get; set; } = new DefaultDoubleTappedRoutedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this DoubleTappedRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this DoubleTappedRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this DoubleTappedRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// that initiated the associated input event.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this event occurrence.
        /// </returns>
        public static PointerDeviceType PointerDeviceType(this DoubleTappedRoutedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against
        /// a coordinate origin of a supplied <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <returns>
        /// A Point that represents the current x- and y-coordinates of the mouse pointer
        /// position. If <c>null</c> was passed as <paramref name="relativeTo"/>, this coordinate is for
        /// the overall window. If a <paramref name="relativeTo"/> value other than <c>null</c> was
        /// passed, this coordinate is relative to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        public static Point GetPositionWrapped(this DoubleTappedRoutedEventArgs e, UIElement relativeTo) => Resolver.GetPosition(e, relativeTo);

        private sealed class DefaultDoubleTappedRoutedEventArgsResolver : IDoubleTappedRoutedEventArgsResolver
        {
            bool IDoubleTappedRoutedEventArgsResolver.Handled(DoubleTappedRoutedEventArgs e) => e.Handled;
            void IDoubleTappedRoutedEventArgsResolver.Handled(DoubleTappedRoutedEventArgs e, bool handled) => e.Handled = handled;
            object IDoubleTappedRoutedEventArgsResolver.OriginalSource(DoubleTappedRoutedEventArgs e) => e.OriginalSource;
            PointerDeviceType IDoubleTappedRoutedEventArgsResolver.PointerDeviceType(DoubleTappedRoutedEventArgs e) => e.PointerDeviceType;
            Point IDoubleTappedRoutedEventArgsResolver.GetPosition(DoubleTappedRoutedEventArgs e, UIElement relativeTo) => e.GetPosition(relativeTo);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DoubleTappedRoutedEventArgs"/>.
    /// </summary>
    public interface IDoubleTappedRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(DoubleTappedRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(DoubleTappedRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(DoubleTappedRoutedEventArgs e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// that initiated the associated input event.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this event occurrence.
        /// </returns>
        PointerDeviceType PointerDeviceType(DoubleTappedRoutedEventArgs e);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against
        /// a coordinate origin of a supplied <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="DoubleTappedRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <returns>
        /// A Point that represents the current x- and y-coordinates of the mouse pointer
        /// position. If <c>null</c> was passed as <paramref name="relativeTo"/>, this coordinate is for
        /// the overall window. If a <paramref name="relativeTo"/> value other than <c>null</c> was
        /// passed, this coordinate is relative to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        Point GetPosition(DoubleTappedRoutedEventArgs e, UIElement relativeTo);
    }
}
