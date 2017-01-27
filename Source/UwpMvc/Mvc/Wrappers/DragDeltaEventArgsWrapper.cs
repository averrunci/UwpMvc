// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Primitives;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DragDeltaEventArgs"/>
    /// resolved by <see cref="IDragDeltaEventArgsResolver"/>.
    /// </summary>
    public static class DragDeltaEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragDeltaEventArgsResolver"/>
        /// that resolves data of the <see cref="DragDeltaEventArgs"/>.
        /// </summary>
        public static IDragDeltaEventArgsResolver Resolver { get; set; } = new DefaultDragDeltaEventArgsResolver();

        /// <summary>
        /// Gets the horizontal change in the <see cref="Thumb"/> position
        /// since the last <see cref="Thumb.DragDelta"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="DragDeltaEventArgs"/>.</param>
        /// <returns>
        /// The horizontal change in the <see cref="Thumb"/> position
        /// since the last <see cref="Thumb.DragDelta"/> event.
        /// </returns>
        public static double HorizontalChange(this DragDeltaEventArgs e) => Resolver.HorizontalChange(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragDeltaEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this DragDeltaEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the vertical change in the <see cref="Thumb"/> position
        /// since the last <see cref="Thumb.DragDelta"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="DragDeltaEventArgs"/>.</param>
        /// <returns>
        /// The vertical change in the <see cref="Thumb"/> position
        /// since the last <see cref="Thumb.DragDelta"/> event.
        /// </returns>
        public static double VerticalChange(this DragDeltaEventArgs e) => Resolver.VerticalChange(e);

        private sealed class DefaultDragDeltaEventArgsResolver : IDragDeltaEventArgsResolver
        {
            double IDragDeltaEventArgsResolver.HorizontalChange(DragDeltaEventArgs e) => e.HorizontalChange;
            object IDragDeltaEventArgsResolver.OriginalSource(DragDeltaEventArgs e) => e.OriginalSource;
            double IDragDeltaEventArgsResolver.VerticalChange(DragDeltaEventArgs e) => e.VerticalChange;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DragDeltaEventArgs"/>.
    /// </summary>
    public interface IDragDeltaEventArgsResolver
    {
        /// <summary>
        /// Gets the horizontal change in the <see cref="Thumb"/> position
        /// since the last <see cref="Thumb.DragDelta"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="DragDeltaEventArgs"/>.</param>
        /// <returns>
        /// The horizontal change in the <see cref="Thumb"/> position
        /// since the last <see cref="Thumb.DragDelta"/> event.
        /// </returns>
        double HorizontalChange(DragDeltaEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="DragDeltaEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(DragDeltaEventArgs e);

        /// <summary>
        /// Gets the vertical change in the <see cref="Thumb"/> position
        /// since the last <see cref="Thumb.DragDelta"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="DragDeltaEventArgs"/>.</param>
        /// <returns>
        /// The vertical change in the <see cref="Thumb"/> position
        /// since the last <see cref="Thumb.DragDelta"/> event.
        /// </returns>
        double VerticalChange(DragDeltaEventArgs e);
    }
}
