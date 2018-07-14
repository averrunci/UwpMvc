// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;
using Windows.Web;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewNavigationFailedEventArgs"/>
    /// resolved by <see cref="IWebViewNavigationFailedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewNavigationFailedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewNavigationFailedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewNavigationFailedEventArgs"/>.
        /// </summary>
        public static IWebViewNavigationFailedEventArgsResolver Resolver { get; set; } = new DefaultWebViewNavigationFailedEventArgsResolver();

        /// <summary>
        /// Gets the URI that the <see cref="WebView"/> attempted to navigate to.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationFailedEventArgs"/>.</param>
        /// <returns>The attempted navigation target.</returns>
        public static Uri Uri(this WebViewNavigationFailedEventArgs e) => Resolver.Uri(e);

        /// <summary>
        /// Gets the error that occurred when navigation failed.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationFailedEventArgs"/>.</param>
        /// <returns>The navigation error.</returns>
        public static WebErrorStatus WebErrorStatus(this WebViewNavigationFailedEventArgs e) => Resolver.WebErrorStatus(e);

        private sealed class DefaultWebViewNavigationFailedEventArgsResolver : IWebViewNavigationFailedEventArgsResolver
        {
            Uri IWebViewNavigationFailedEventArgsResolver.Uri(WebViewNavigationFailedEventArgs e) => e.Uri;
            WebErrorStatus IWebViewNavigationFailedEventArgsResolver.WebErrorStatus(WebViewNavigationFailedEventArgs e) => e.WebErrorStatus;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewNavigationFailedEventArgs"/>.
    /// </summary>
    public interface IWebViewNavigationFailedEventArgsResolver
    {
        /// <summary>
        /// Gets the URI that the <see cref="WebView"/> attempted to navigate to.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationFailedEventArgs"/>.</param>
        /// <returns>The attempted navigation target.</returns>
        Uri Uri(WebViewNavigationFailedEventArgs e);

        /// <summary>
        /// Gets the error that occurred when navigation failed.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationFailedEventArgs"/>.</param>
        /// <returns>The navigation error.</returns>
        WebErrorStatus WebErrorStatus(WebViewNavigationFailedEventArgs e);
    }
}
