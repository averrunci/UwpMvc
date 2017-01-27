// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="RoutedEventArgs"/>
    /// resolved by <see cref="IRoutedEventArgsResolver"/>.
    /// </summary>
    public static class RoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="RoutedEventArgs"/>.
        /// </summary>
        public static IRoutedEventArgsResolver Resolver { get; set; } = new DefaultRoutedEventArgsResolver();

        /// <summary>
        /// Gets a reference to the object thar raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="RoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this RoutedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultRoutedEventArgsResolver : IRoutedEventArgsResolver
        {
            object IRoutedEventArgsResolver.OriginalSource(RoutedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="RoutedEventArgs"/>.
    /// </summary>
    public interface IRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="RoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(RoutedEventArgs e);
    }
}
