// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SizeChangedEventArgs"/>
    /// resolved by <see cref="ISizeChangedEventArgsResolver"/>.
    /// </summary>
    public static class SizeChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISizeChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="SizeChangedEventArgs"/>.
        /// </summary>
        public static ISizeChangedEventArgsResolver Resolver { get; set; } = new DefaultSizeChangedEventArgsResolver();

        /// <summary>
        /// Gets the new size of the object reporting the size change.
        /// </summary>
        /// <param name="e">The requested <see cref="SizeChangedEventArgs"/>.</param>
        /// <returns>
        /// The new size. The <see cref="Size"/> structure contains the new height and width.
        /// </returns>
        public static Size NewSize(this SizeChangedEventArgs e) => Resolver.NewSize(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="SizeChangedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this SizeChangedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the previous size of the object reporting the size change.
        /// </summary>
        /// <param name="e">The requested <see cref="SizeChangedEventArgs"/>.</param>
        /// <returns>The previous size.</returns>
        public static Size PreviousSize(this SizeChangedEventArgs e) => Resolver.PreviousSize(e);

        private sealed class DefaultSizeChangedEventArgsResolver : ISizeChangedEventArgsResolver
        {
            Size ISizeChangedEventArgsResolver.NewSize(SizeChangedEventArgs e) => e.NewSize;
            object ISizeChangedEventArgsResolver.OriginalSource(SizeChangedEventArgs e) => e.OriginalSource;
            Size ISizeChangedEventArgsResolver.PreviousSize(SizeChangedEventArgs e) => e.PreviousSize;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SizeChangedEventArgs"/>.
    /// </summary>
    public interface ISizeChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the new size of the object reporting the size change.
        /// </summary>
        /// <param name="e">The requested <see cref="SizeChangedEventArgs"/>.</param>
        /// <returns>
        /// The new size. The <see cref="Size"/> structure contains the new height and width.
        /// </returns>
        Size NewSize(SizeChangedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="SizeChangedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(SizeChangedEventArgs e);

        /// <summary>
        /// Gets the previous size of the object reporting the size change.
        /// </summary>
        /// <param name="e">The requested <see cref="SizeChangedEventArgs"/>.</param>
        /// <returns>The previous size.</returns>
        Size PreviousSize(SizeChangedEventArgs e);
    }
}
