// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Primitives;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ScrollEventArgs"/>
    /// resolved by <see cref="IScrollEventArgsResolver"/>.
    /// </summary>
    public static class ScrollEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IScrollEventArgsResolver"/>
        /// that resolves data of the <see cref="ScrollEventArgs"/>.
        /// </summary>
        public static IScrollEventArgsResolver Resolver { get; set; } = new DefaultScrollEventArgsResolver();

        /// <summary>
        /// Gets the new <see cref="RangeBase.Value"/> of the <see cref="ScrollBar"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="RangeBase.Value"/> of the <see cref="ScrollBar"/> after the event.
        /// </returns>
        public static double NewValue(this ScrollEventArgs e) => Resolver.NewValue(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ScrollEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets a <see cref="global::Windows.UI.Xaml.Controls.Primitives.ScrollEventType"/> describing the event.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollEventArgs"/>.</param>
        /// <returns>
        /// A <see cref="global::Windows.UI.Xaml.Controls.Primitives.ScrollEventType"/> describing the event.
        /// </returns>
        public static ScrollEventType ScrollEventType(this ScrollEventArgs e) => Resolver.ScrollEventType(e);

        private sealed class DefaultScrollEventArgsResolver : IScrollEventArgsResolver
        {
            double IScrollEventArgsResolver.NewValue(ScrollEventArgs e) => e.NewValue;
            object IScrollEventArgsResolver.OriginalSource(ScrollEventArgs e) => e.OriginalSource;
            ScrollEventType IScrollEventArgsResolver.ScrollEventType(ScrollEventArgs e) => e.ScrollEventType;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ScrollEventArgs"/>.
    /// </summary>
    public interface IScrollEventArgsResolver
    {
        /// <summary>
        /// Gets the new <see cref="RangeBase.Value"/> of the <see cref="ScrollBar"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="RangeBase.Value"/> of the <see cref="ScrollBar"/> after the event.
        /// </returns>
        double NewValue(ScrollEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ScrollEventArgs e);

        /// <summary>
        /// Gets a <see cref="global::Windows.UI.Xaml.Controls.Primitives.ScrollEventType"/> describing the event.
        /// </summary>
        /// <param name="e">The requested <see cref="ScrollEventArgs"/>.</param>
        /// <returns>
        /// A <see cref="global::Windows.UI.Xaml.Controls.Primitives.ScrollEventType"/> describing the event.
        /// </returns>
        ScrollEventType ScrollEventType(ScrollEventArgs e);
    }
}
