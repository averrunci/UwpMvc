// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="CleanUpVirtualizedItemEventArgs"/>
    /// resolved by <see cref="ICleanUpVirtualizedItemEventArgsResolver"/>.
    /// </summary>
    public static class CleanUpVirtualizedItemEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ICleanUpVirtualizedItemEventArgsResolver"/>
        /// that resolves data of the <see cref="CleanUpVirtualizedItemEventArgs"/>.
        /// </summary>
        public static ICleanUpVirtualizedItemEventArgsResolver Resolver { get; set; } = new DefaultCleanUpVirtualizedItemEventArgsResolver();

        /// <summary>
        /// Gets an object that represents the original data value.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <returns>The Object that represents the original data value.</returns>
        public static object Value(this CleanUpVirtualizedItemEventArgs e) => Resolver.Value(e);

        /// <summary>
        /// Gets an instance of the visual element that represents the data value.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <returns>The UIElement that represents the data value.</returns>
        public static UIElement UIElement(this CleanUpVirtualizedItemEventArgs e) => Resolver.UIElement(e);

        /// <summary>
        /// Gets a value that indicates whether this item should not be revirtualized.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <returns><c>true</c> if you want to prevent revirtualization of this item; otherwise, <c>false</c>.</returns>
        public static bool Cancel(this CleanUpVirtualizedItemEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that indicates whether this item should not be revirtualized.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> if you want to prevent revirtualization of this item; otherwise, <c>false</c>.</param>
        public static void Cancel(this CleanUpVirtualizedItemEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this CleanUpVirtualizedItemEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultCleanUpVirtualizedItemEventArgsResolver : ICleanUpVirtualizedItemEventArgsResolver
        {
            object ICleanUpVirtualizedItemEventArgsResolver.Value(CleanUpVirtualizedItemEventArgs e) => e.Value;
            UIElement ICleanUpVirtualizedItemEventArgsResolver.UIElement(CleanUpVirtualizedItemEventArgs e) => e.UIElement;
            bool ICleanUpVirtualizedItemEventArgsResolver.Cancel(CleanUpVirtualizedItemEventArgs e) => e.Cancel;
            void ICleanUpVirtualizedItemEventArgsResolver.Cancel(CleanUpVirtualizedItemEventArgs e, bool cancel) => e.Cancel = cancel;
            object ICleanUpVirtualizedItemEventArgsResolver.OriginalSource(CleanUpVirtualizedItemEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="CleanUpVirtualizedItemEventArgs"/>.
    /// </summary>
    public interface ICleanUpVirtualizedItemEventArgsResolver
    {
        /// <summary>
        /// Gets an object that represents the original data value.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <returns>The Object that represents the original data value.</returns>
        object Value(CleanUpVirtualizedItemEventArgs e);

        /// <summary>
        /// Gets an instance of the visual element that represents the data value.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <returns>The UIElement that represents the data value.</returns>
        UIElement UIElement(CleanUpVirtualizedItemEventArgs e);

        /// <summary>
        /// Gets a value that indicates whether this item should not be revirtualized.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <returns><c>true</c> if you want to prevent revirtualization of this item; otherwise, <c>false</c>.</returns>
        bool Cancel(CleanUpVirtualizedItemEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether this item should not be revirtualized.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> if you want to prevent revirtualization of this item; otherwise, <c>false</c>.</param>
        void Cancel(CleanUpVirtualizedItemEventArgs e, bool cancel);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="CleanUpVirtualizedItemEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(CleanUpVirtualizedItemEventArgs e);
    }
}
