// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="NavigationViewPaneClosingEventArgs"/>
    /// resolved by <see cref="INavigationViewPaneClosingEventArgsResolver"/>.
    /// </summary>
    public static class NavigationViewPaneClosingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="INavigationViewPaneClosingEventArgsResolver"/>
        /// that resolves data of the <see cref="NavigationViewPaneClosingEventArgs"/>.
        /// </summary>
        public static INavigationViewPaneClosingEventArgsResolver Resolver { get; set; } = new DefaultNavigationViewPaneClosingEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the event should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewPaneClosingEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the event; otherwise, <c>false</c>. The default is <c>false</c>.</returns>
        public static bool Cancel(this NavigationViewPaneClosingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that indicates whether the event should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewPaneClosingEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the event; otherwise, <c>false</c>. The default is <c>false</c>.</param>
        public static void Cancel(this NavigationViewPaneClosingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        private sealed class DefaultNavigationViewPaneClosingEventArgsResolver : INavigationViewPaneClosingEventArgsResolver
        {
            bool INavigationViewPaneClosingEventArgsResolver.Cancel(NavigationViewPaneClosingEventArgs e) => e.Cancel;
            void INavigationViewPaneClosingEventArgsResolver.Cancel(NavigationViewPaneClosingEventArgs e, bool cancel) => e.Cancel = cancel;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="NavigationViewPaneClosingEventArgs"/>.
    /// </summary>
    public interface INavigationViewPaneClosingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the event should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewPaneClosingEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the event; otherwise, <c>false</c>. The default is <c>false</c>.</returns>
        bool Cancel(NavigationViewPaneClosingEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the event should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="NavigationViewPaneClosingEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the event; otherwise, <c>false</c>. The default is <c>false</c>.</param>
        void Cancel(NavigationViewPaneClosingEventArgs e, bool cancel);
    }
}
