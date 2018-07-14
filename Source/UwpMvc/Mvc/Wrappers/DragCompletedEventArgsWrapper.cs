// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Primitives;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DragCompletedEventArgs"/>
    /// resolved by <see cref="IDragCompletedEventArgsResolver"/>.
    /// </summary>
    public static class DragCompletedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragCompletedEventArgsResolver"/>
        /// that resolves data of the <see cref="DragCompletedEventArgs"/>.
        /// </summary>
        public static IDragCompletedEventArgsResolver Resolver { get; set; } = new DefaultDragCompletedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the drag operation was canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragCompletedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the drag operation was canceled; otherwise, <c>false</c>.
        /// </returns>
        public static bool Canceled(this DragCompletedEventArgs e) => Resolver.Canceled(e);

        /// <summary>
        /// Gets the horizontal distance between the current mouse position and the thumb coordinates.
        /// </summary>
        /// <param name="e">The requested <see cref="DragCompletedEventArgs"/>.</param>
        /// <returns>The horizontal distance between the current mouse position and the thumb coordinates.</returns>
        public static double HorizontalChange(this DragCompletedEventArgs e) => Resolver.HorizontalChange(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragCompletedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this DragCompletedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the vertical distance between the current mouse position and the thumb coordinates.
        /// </summary>
        /// <param name="e">The requested <see cref="DragCompletedEventArgs"/>.</param>
        /// <returns>The vertical distance between the current mouse position and the thumb coordinates.</returns>
        public static double VerticalChange(this DragCompletedEventArgs e) => VerticalChange(e);

        private sealed class DefaultDragCompletedEventArgsResolver : IDragCompletedEventArgsResolver
        {
            bool IDragCompletedEventArgsResolver.Canceled(DragCompletedEventArgs e) => e.Canceled;
            double IDragCompletedEventArgsResolver.HorizontalChange(DragCompletedEventArgs e) => e.HorizontalChange;
            object IDragCompletedEventArgsResolver.OriginalSource(DragCompletedEventArgs e) => e.OriginalSource;
            double IDragCompletedEventArgsResolver.VerticalChange(DragCompletedEventArgs e) => e.VerticalChange;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DragCompletedEventArgs"/>.
    /// </summary>
    public interface IDragCompletedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the drag operation was canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragCompletedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the drag operation was canceled; otherwise, <c>false</c>.
        /// </returns>
        bool Canceled(DragCompletedEventArgs e);

        /// <summary>
        /// Gets the horizontal distance between the current mouse position and the thumb coordinates.
        /// </summary>
        /// <param name="e">The requested <see cref="DragCompletedEventArgs"/>.</param>
        /// <returns>The horizontal distance between the current mouse position and the thumb coordinates.</returns>
        double HorizontalChange(DragCompletedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragCompletedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(DragCompletedEventArgs e);

        /// <summary>
        /// Gets the vertical distance between the current mouse position and the thumb coordinates.
        /// </summary>
        /// <param name="e">The requested <see cref="DragCompletedEventArgs"/>.</param>
        /// <returns>The vertical distance between the current mouse position and the thumb coordinates.</returns>
        double VerticalChange(DragCompletedEventArgs e);
    }
}
