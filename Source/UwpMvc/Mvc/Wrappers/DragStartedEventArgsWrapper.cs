// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Primitives;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DragStartedEventArgs"/>
    /// resolved by <see cref="IDragStartedEventArgsResolver"/>.
    /// </summary>
    public static class DragStartedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragStartedEventArgsResolver"/>
        /// that resolves data of the <see cref="DragStartedEventArgs"/>.
        /// </summary>
        public static IDragStartedEventArgsResolver Resolver { get; set; } = new DefaultDragStartedEventArgsResolver();

        /// <summary>
        /// Gets the horizontal distance between the current mouse position and the thumb coordinates.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartedEventArgs"/>.</param>
        /// <returns>The horizontal distance between the current mouse position and the thumb coordinates.</returns>
        public static double HorizontalOffset(this DragStartedEventArgs e) => Resolver.HorizontalOffset(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this DragStartedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the vertical distance between the current mouse position and the thumb coordinates.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartedEventArgs"/>.</param>
        /// <returns>The vertical distance between the current mouse position and the thumb coordinates.</returns>
        public static double VerticalOffset(this DragStartedEventArgs e) => Resolver.VerticalOffset(e);

        private sealed class DefaultDragStartedEventArgsResolver : IDragStartedEventArgsResolver
        {
            double IDragStartedEventArgsResolver.HorizontalOffset(DragStartedEventArgs e) => e.HorizontalOffset;
            object IDragStartedEventArgsResolver.OriginalSource(DragStartedEventArgs e) => e.OriginalSource;
            double IDragStartedEventArgsResolver.VerticalOffset(DragStartedEventArgs e) => e.VerticalOffset;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DragStartedEventArgs"/>.
    /// </summary>
    public interface IDragStartedEventArgsResolver
    {
        /// <summary>
        /// Gets the horizontal distance between the current mouse position and the thumb coordinates.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartedEventArgs"/>.</param>
        /// <returns>The horizontal distance between the current mouse position and the thumb coordinates.</returns>
        double HorizontalOffset(DragStartedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(DragStartedEventArgs e);

        /// <summary>
        /// Gets the vertical distance between the current mouse position and the thumb coordinates.
        /// </summary>
        /// <param name="e">The requested <see cref="DragStartedEventArgs"/>.</param>
        /// <returns>The vertical distance between the current mouse position and the thumb coordinates.</returns>
        double VerticalOffset(DragStartedEventArgs e);
    }
}
