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
    /// Provides data of the <see cref="DragStartingEventArgs"/>
    /// resolved by <see cref="IDragStartingEventArgsResolver"/>.
    /// </summary>
    public static class DragStartingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragStartingEventArgsResolver"/>
        /// that resolves data of the <see cref="DragStartingEventArgs"/>.
        /// </summary>
        public static IDragStartingEventArgsResolver Resolver { get; set; } = new DefaultDragStartingEventArgsResolver();

        /// <summary>
        /// Gets the allowed data package operations (none, move, copy and/or link) for the drag and drop operation.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>The allowed data operations.</returns>
        public static DataPackageOperation AllowedOperations(this DragStartingEventArgs e) => Resolver.AllowedOperations(e);

        /// <summary>
        /// Sets the allowed data package operations (none, move, copy and/or link) for the drag and drop operation.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <param name="dataPackageOperation">The allowed data operations.</param>
        public static void AllowedOperations(this DragStartingEventArgs e, DataPackageOperation dataPackageOperation) => Resolver.AllowedOperations(e, dataPackageOperation);

        /// <summary>
        /// Gets a value that indicates whether the drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the drag action; otherwise, <c>false</c>.
        /// </returns>
        public static bool Cancel(this DragStartingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that indicates whether the drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the drag action; otherwise, <c>false</c>.
        /// </param>
        public static void Cancel(this DragStartingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Gets the data payload associated with a drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>The data payload.</returns>
        public static DataPackage Data(this DragStartingEventArgs e) => Resolver.Data(e);

        /// <summary>
        /// Gets the visual representation of the data being dragged.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>The visual representation of the data being dragged.</returns>
        public static DragUI DragUI(this DragStartingEventArgs e) => Resolver.DragUI(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this DragStartingEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Supports asynchronous drag-and-drop operations by creating and returning a
        /// <see cref="DragOperationDeferral"/> object.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>
        /// A deferral object that you can use to identify when the generation of the data package is complete.
        /// </returns>
        public static DragOperationDeferral GetDeferralWrapped(this DragStartingEventArgs e) => Resolver.GetDeferral(e);

        /// <summary>
        /// Gets a drop point that is relative to a specified <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <param name="relativeTo">The <see cref="UIElement"/> for which to get a relative drop point.</param>
        /// <returns>
        /// A point in the coordinate system that is relative to the element specified in <paramref name="relativeTo"/>.
        /// </returns>
        public static Point GetPositionWrapped(this DragStartingEventArgs e, UIElement relativeTo) => Resolver.GetPosition(e, relativeTo);

        private sealed class DefaultDragStartingEventArgsResolver : IDragStartingEventArgsResolver
        {
            DataPackageOperation IDragStartingEventArgsResolver.AllowedOperations(DragStartingEventArgs e) => e.AllowedOperations;
            void IDragStartingEventArgsResolver.AllowedOperations(DragStartingEventArgs e, DataPackageOperation dataPackageOperation) => e.AllowedOperations = dataPackageOperation;
            bool IDragStartingEventArgsResolver.Cancel(DragStartingEventArgs e) => e.Cancel;
            void IDragStartingEventArgsResolver.Cancel(DragStartingEventArgs e, bool cancel) => e.Cancel = cancel;
            DataPackage IDragStartingEventArgsResolver.Data(DragStartingEventArgs e) => e.Data;
            DragUI IDragStartingEventArgsResolver.DragUI(DragStartingEventArgs e) => e.DragUI;
            object IDragStartingEventArgsResolver.OriginalSource(DragStartingEventArgs e) => e.OriginalSource;
            DragOperationDeferral IDragStartingEventArgsResolver.GetDeferral(DragStartingEventArgs e) => e.GetDeferral();
            Point IDragStartingEventArgsResolver.GetPosition(DragStartingEventArgs e, UIElement relativeTo) => e.GetPosition(relativeTo);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DragStartingEventArgs"/>.
    /// </summary>
    public interface IDragStartingEventArgsResolver
    {
        /// <summary>
        /// Gets the allowed data package operations (none, move, copy and/or link) for the drag and drop operation.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>The allowed data operations.</returns>
        DataPackageOperation AllowedOperations(DragStartingEventArgs e);

        /// <summary>
        /// Sets the allowed data package operations (none, move, copy and/or link) for the drag and drop operation.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <param name="dataPackageOperation">The allowed data operations.</param>
        void AllowedOperations(DragStartingEventArgs e, DataPackageOperation dataPackageOperation);

        /// <summary>
        /// Gets a value that indicates whether the drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the drag action; otherwise, <c>false</c>.
        /// </returns>
        bool Cancel(DragStartingEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the drag action; otherwise, <c>false</c>.
        /// </param>
        void Cancel(DragStartingEventArgs e, bool cancel);

        /// <summary>
        /// Gets the data payload associated with a drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>The data payload.</returns>
        DataPackage Data(DragStartingEventArgs e);

        /// <summary>
        /// Gets the visual representation of the data being dragged.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>The visual representation of the data being dragged.</returns>
        DragUI DragUI(DragStartingEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(DragStartingEventArgs e);

        /// <summary>
        /// Supports asynchronous drag-and-drop operations by creating and returning a
        /// <see cref="DragOperationDeferral"/> object.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <returns>
        /// A deferral object that you can use to identify when the generation of the data package is complete.
        /// </returns>
        DragOperationDeferral GetDeferral(DragStartingEventArgs e);

        /// <summary>
        /// Gets a drop point that is relative to a specified <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartingEventArgs"/>.</param>
        /// <param name="relativeTo">The <see cref="UIElement"/> for which to get a relative drop point.</param>
        /// <returns>
        /// A point in the coordinate system that is relative to the element specified in <paramref name="relativeTo"/>.
        /// </returns>
        Point GetPosition(DragStartingEventArgs e, UIElement relativeTo);
    }
}
