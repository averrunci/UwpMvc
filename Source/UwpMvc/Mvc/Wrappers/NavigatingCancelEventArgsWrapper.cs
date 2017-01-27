// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="NavigatingCancelEventArgs"/>
    /// resolved by <see cref="INavigatingCancelEventArgsResolver"/>.
    /// </summary>
    public static class NavigatingCancelEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="INavigatingCancelEventArgsResolver"/>
        /// that resolves data of the <see cref="NavigatingCancelEventArgs"/>.
        /// </summary>
        public static INavigatingCancelEventArgsResolver Resolver { get; set; } = new DefaultNavigatingCancelEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether a pending navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the pending cancelable navigation; <c>false</c> to continue with navigation.
        /// </returns>
        public static bool Cancel(this NavigatingCancelEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Specifies whether a pending navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the pending cancelable navigation; <c>false</c> to continue with navigation.
        /// </param>
        public static void Cancel(this NavigatingCancelEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Gets the value of the mode parameter from the originating Navigate call.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>The value of the mode parameter from the originating Navigate call.</returns>
        public static NavigationMode NavigationMode(this NavigatingCancelEventArgs e) => Resolver.NavigationMode(e);

        /// <summary>
        /// Gets a value that indicates the animated transition associated with the navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>Information about the animated transition.</returns>
        public static NavigationTransitionInfo NavigationTransitionInfo(this NavigatingCancelEventArgs e) => Resolver.NavigationTransitionInfo(e);

        /// <summary>
        /// Gets the navigation parameter associated with this navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>The navigation parameter.</returns>
        public static object Parameter(this NavigatingCancelEventArgs e) => Resolver.Parameter(e);

        /// <summary>
        /// Gets the value of the SourcePageType parameter from the originating Navigate call.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>The value of the SourcePageType parameter from the originating Navigate call.</returns>
        public static Type SourcePageType(this NavigatingCancelEventArgs e) => Resolver.SourcePageType(e);

        private sealed class DefaultNavigatingCancelEventArgsResolver : INavigatingCancelEventArgsResolver
        {
            bool INavigatingCancelEventArgsResolver.Cancel(NavigatingCancelEventArgs e) => e.Cancel;
            void INavigatingCancelEventArgsResolver.Cancel(NavigatingCancelEventArgs e, bool cancel) => e.Cancel = cancel;
            NavigationMode INavigatingCancelEventArgsResolver.NavigationMode(NavigatingCancelEventArgs e) => e.NavigationMode;
            NavigationTransitionInfo INavigatingCancelEventArgsResolver.NavigationTransitionInfo(NavigatingCancelEventArgs e) => e.NavigationTransitionInfo;
            object INavigatingCancelEventArgsResolver.Parameter(NavigatingCancelEventArgs e) => e.Parameter;
            Type INavigatingCancelEventArgsResolver.SourcePageType(NavigatingCancelEventArgs e) => e.SourcePageType;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="NavigatingCancelEventArgs"/>.
    /// </summary>
    public interface INavigatingCancelEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether a pending navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the pending cancelable navigation; <c>false</c> to continue with navigation.
        /// </returns>
        bool Cancel(NavigatingCancelEventArgs e);

        /// <summary>
        /// Specifies whether a pending navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the pending cancelable navigation; <c>false</c> to continue with navigation.
        /// </param>
        void Cancel(NavigatingCancelEventArgs e, bool cancel);

        /// <summary>
        /// Gets the value of the mode parameter from the originating Navigate call.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>The value of the mode parameter from the originating Navigate call.</returns>
        NavigationMode NavigationMode(NavigatingCancelEventArgs e);

        /// <summary>
        /// Gets a value that indicates the animated transition associated with the navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>Information about the animated transition.</returns>
        NavigationTransitionInfo NavigationTransitionInfo(NavigatingCancelEventArgs e);

        /// <summary>
        /// Gets the navigation parameter associated with this navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>The navigation parameter.</returns>
        object Parameter(NavigatingCancelEventArgs e);

        /// <summary>
        /// Gets the value of the SourcePageType parameter from the originating Navigate call.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigatingCancelEventArgs"/>.</param>
        /// <returns>The value of the SourcePageType parameter from the originating Navigate call.</returns>
        Type SourcePageType(NavigatingCancelEventArgs e);
    }
}
