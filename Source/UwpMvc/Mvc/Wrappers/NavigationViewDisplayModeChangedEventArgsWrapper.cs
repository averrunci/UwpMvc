// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="NavigationViewDisplayModeChangedEventArgs"/>
    /// resolved by <see cref="INavigationViewDisplayModeChangedEventArgsResolver"/>.
    /// </summary>
    public static class NavigationViewDisplayModeChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="INavigationViewDisplayModeChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="NavigationViewDisplayModeChangedEventArgs"/>.
        /// </summary>
        public static INavigationViewDisplayModeChangedEventArgsResolver Resolver { get; set; } = new DefaultNavigationViewDisplayModeChangedEventArgsResolver();

        /// <summary>
        /// Gets the new display mode.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewDisplayModeChangedEventArgs"/>.</param>
        /// <returns>The new display mode.</returns>
        public static NavigationViewDisplayMode DisplayMode(this NavigationViewDisplayModeChangedEventArgs e) => Resolver.DisplayMode(e);

        private sealed class DefaultNavigationViewDisplayModeChangedEventArgsResolver : INavigationViewDisplayModeChangedEventArgsResolver
        {
            NavigationViewDisplayMode INavigationViewDisplayModeChangedEventArgsResolver.DisplayMode(NavigationViewDisplayModeChangedEventArgs e) => e.DisplayMode;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="NavigationViewDisplayModeChangedEventArgs"/>.
    /// </summary>
    public interface INavigationViewDisplayModeChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the new display mode.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewDisplayModeChangedEventArgs"/>.</param>
        /// <returns>The new display mode.</returns>
        NavigationViewDisplayMode DisplayMode(NavigationViewDisplayModeChangedEventArgs e);
    }
}
