// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewNavigationStartingEventArgs"/>
    /// resolved by <see cref="IWebViewNavigationStartingEventArgsResolver"/>.
    /// </summary>
    public static class WebViewNavigationStartingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewNavigationStartingEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewNavigationStartingEventArgs"/>.
        /// </summary>
        public static IWebViewNavigationStartingEventArgsResolver Resolver { get; set; } = new DefaultWebViewNavigationStartingEventArgsResolver();

        /// <summary>
        /// Gets a value indicating whether to cancel the <see cref="WebView"/> navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationStartingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the navigation; otherwise, <c>false</c>.
        /// </returns>
        public static bool Cancel(this WebViewNavigationStartingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value indicating whether to cancel the <see cref="WebView"/> navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationStartingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the navigation; otherwise, <c>false</c>.
        /// </param>
        public static void Cancel(this WebViewNavigationStartingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> is loading.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationStartingEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        public static Uri Uri(this WebViewNavigationStartingEventArgs e) => Resolver.Uri(e);

        private sealed class DefaultWebViewNavigationStartingEventArgsResolver : IWebViewNavigationStartingEventArgsResolver
        {
            bool IWebViewNavigationStartingEventArgsResolver.Cancel(WebViewNavigationStartingEventArgs e) => e.Cancel;
            void IWebViewNavigationStartingEventArgsResolver.Cancel(WebViewNavigationStartingEventArgs e, bool cancel) => e.Cancel = cancel;
            Uri IWebViewNavigationStartingEventArgsResolver.Uri(WebViewNavigationStartingEventArgs e) => e.Uri;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewNavigationStartingEventArgs"/>.
    /// </summary>
    public interface IWebViewNavigationStartingEventArgsResolver
    {
        /// <summary>
        /// Gets a value indicating whether to cancel the <see cref="WebView"/> navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationStartingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the navigation; otherwise, <c>false</c>.
        /// </returns>
        bool Cancel(WebViewNavigationStartingEventArgs e);

        /// <summary>
        /// Sets a value indicating whether to cancel the <see cref="WebView"/> navigation.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationStartingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the navigation; otherwise, <c>false</c>.
        /// </param>
        void Cancel(WebViewNavigationStartingEventArgs e, bool cancel);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> is loading.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationStartingEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        Uri Uri(WebViewNavigationStartingEventArgs e);
    }
}
