// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Navigation;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="NavigationFailedEventArgs"/>
    /// resolved by <see cref="INavigationFailedEventArgsResolver"/>.
    /// </summary>
    public static class NavigationFailedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="INavigationFailedEventArgsResolver"/>
        /// that resolves data of the <see cref="NavigationFailedEventArgs"/>.
        /// </summary>
        public static INavigationFailedEventArgsResolver Resolver { get; set; } = new DefaultNavigationFailedEventArgsResolver();

        /// <summary>
        /// Gets the result code for the exception that is associated with the failed navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationFailedEventArgs"/>.</param>
        /// <returns>A system exception result code.</returns>
        public static Exception Exception(this NavigationFailedEventArgs e) => Resolver.Exception(e);

        /// <summary>
        /// Gets a value that indicates whether the failure event has been handled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationFailedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the failure event is handled; <c>false</c> if the failure event is not yet handled.
        /// </returns>
        public static bool Handled(this NavigationFailedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that indicates whether the failure event has been handled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationFailedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> if the failure event is handled; <c>false</c> if the failure event is not yet handled.
        /// </param>
        public static void Handled(this NavigationFailedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the data type of the target page.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationFailedEventArgs"/>.</param>
        /// <returns>The data type of the target page.</returns>
        public static Type SourcePageType(this NavigationFailedEventArgs e) => Resolver.SourcePageType(e);

        private sealed class DefaultNavigationFailedEventArgsResolver : INavigationFailedEventArgsResolver
        {
            Exception INavigationFailedEventArgsResolver.Exception(NavigationFailedEventArgs e) => e.Exception;
            bool INavigationFailedEventArgsResolver.Handled(NavigationFailedEventArgs e) => e.Handled;
            void INavigationFailedEventArgsResolver.Handled(NavigationFailedEventArgs e, bool handled) => e.Handled = handled;
            Type INavigationFailedEventArgsResolver.SourcePageType(NavigationFailedEventArgs e) => e.SourcePageType;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="NavigationFailedEventArgs"/>.
    /// </summary>
    public interface INavigationFailedEventArgsResolver
    {
        /// <summary>
        /// Gets the result code for the exception that is associated with the failed navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationFailedEventArgs"/>.</param>
        /// <returns>A system exception result code.</returns>
        Exception Exception(NavigationFailedEventArgs e);

        /// <summary>
        /// Gets a value that indicates whether the failure event has been handled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationFailedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the failure event is handled; <c>false</c> if the failure event is not yet handled.
        /// </returns>
        bool Handled(NavigationFailedEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the failure event has been handled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationFailedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> if the failure event is handled; <c>false</c> if the failure event is not yet handled.
        /// </param>
        void Handled(NavigationFailedEventArgs e, bool handled);

        /// <summary>
        /// Gets the data type of the target page.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationFailedEventArgs"/>.</param>
        /// <returns>The data type of the target page.</returns>
        Type SourcePageType(NavigationFailedEventArgs e);
    }
}
