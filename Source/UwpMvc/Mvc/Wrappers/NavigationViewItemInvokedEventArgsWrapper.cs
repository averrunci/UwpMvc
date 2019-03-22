// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media.Animation;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="NavigationViewItemInvokedEventArgs"/>
    /// resolved by <see cref="INavigationViewItemInvokedEventArgsResolver"/>.
    /// </summary>
    public static class NavigationViewItemInvokedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="INavigationViewItemInvokedEventArgsResolver"/>
        /// that resolves data of the <see cref="NavigationViewItemInvokedEventArgs"/>.
        /// </summary>
        public static INavigationViewItemInvokedEventArgsResolver Resolver { get; set; } = new DefaultNavigationViewItemInvokedEventArgsResolver();

        /// <summary>
        /// Gets a reference to the invoked item.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewItemInvokedEventArgs"/>.</param>
        /// <returns>The invoked item.</returns>
        public static object InvokedItem(this NavigationViewItemInvokedEventArgs e) => Resolver.InvokedItem(e);

        /// <summary>
        /// Gets a value that indicates whether the **InvokedItem** is the menu item for Settings.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewItemInvokedEventArgs"/>.</param>
        /// <returns><c>true</c> if the <see cref="InvokedItem"/> is the menu item for Settings; otherwise, <c>false</c>.</returns>
        public static bool IsSettingsInvoked(this NavigationViewItemInvokedEventArgs e) => Resolver.IsSettingsInvoked(e);

        /// <summary>
        /// Gets the container for the invoked item.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewItemInvokedEventArgs"/>.</param>
        /// <returns>The container for the invoked item.</returns>
        public static NavigationViewItemBase InvokedItemContainer(this NavigationViewItemInvokedEventArgs e) => Resolver.InvokedItemContainer(e);

        /// <summary>
        /// Gets the navigation transition recommended for the direction of the navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewItemInvokedEventArgs"/>.</param>
        /// <returns>The navigation transition recommended for the direction of the navigation.</returns>
        public static NavigationTransitionInfo RecommendedNavigationTransitionInfo(this NavigationViewItemInvokedEventArgs e) => Resolver.RecommendedNavigationTransitionInfo(e);

        private sealed class DefaultNavigationViewItemInvokedEventArgsResolver : INavigationViewItemInvokedEventArgsResolver
        {
            object INavigationViewItemInvokedEventArgsResolver.InvokedItem(NavigationViewItemInvokedEventArgs e) => e.InvokedItem;
            bool INavigationViewItemInvokedEventArgsResolver.IsSettingsInvoked(NavigationViewItemInvokedEventArgs e) => e.IsSettingsInvoked;
            NavigationViewItemBase INavigationViewItemInvokedEventArgsResolver.InvokedItemContainer(NavigationViewItemInvokedEventArgs e) => e.InvokedItemContainer;
            NavigationTransitionInfo INavigationViewItemInvokedEventArgsResolver.RecommendedNavigationTransitionInfo(NavigationViewItemInvokedEventArgs e) => e.RecommendedNavigationTransitionInfo;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="NavigationViewItemInvokedEventArgs"/>.
    /// </summary>
    public interface INavigationViewItemInvokedEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the invoked item.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewItemInvokedEventArgs"/>.</param>
        /// <returns>The invoked item.</returns>
        object InvokedItem(NavigationViewItemInvokedEventArgs e);

        /// <summary>
        /// Gets a value that indicates whether the **InvokedItem** is the menu item for Settings.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewItemInvokedEventArgs"/>.</param>
        /// <returns><c>true</c> if the <see cref="InvokedItem"/> is the menu item for Settings; otherwise, <c>false</c>.</returns>
        bool IsSettingsInvoked(NavigationViewItemInvokedEventArgs e);

        /// <summary>
        /// Gets the container for the invoked item.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewItemInvokedEventArgs"/>.</param>
        /// <returns>The container for the invoked item.</returns>
        NavigationViewItemBase InvokedItemContainer(NavigationViewItemInvokedEventArgs e);

        /// <summary>
        /// Gets the navigation transition recommended for the direction of the navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewItemInvokedEventArgs"/>.</param>
        /// <returns>The navigation transition recommended for the direction of the navigation.</returns>
        NavigationTransitionInfo RecommendedNavigationTransitionInfo(NavigationViewItemInvokedEventArgs e);
    }
}
