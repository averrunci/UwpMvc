// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewContentLoadingEventArgs"/>
    /// resolved by <see cref="IWebViewContentLoadingEventArgsResolver"/>.
    /// </summary>
    public static class WebViewContentLoadingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewContentLoadingEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewContentLoadingEventArgs"/>.
        /// </summary>
        public static IWebViewContentLoadingEventArgsResolver Resolver { get; set; } = new DefaultWebViewContentLoadingEventArgsResolver();

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> is loading.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewContentLoadingEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        public static Uri Uri(this WebViewContentLoadingEventArgs e) => Resolver.Uri(e);

        private sealed class DefaultWebViewContentLoadingEventArgsResolver : IWebViewContentLoadingEventArgsResolver
        {
            Uri IWebViewContentLoadingEventArgsResolver.Uri(WebViewContentLoadingEventArgs e) => e.Uri;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewContentLoadingEventArgs"/>.
    /// </summary>
    public interface IWebViewContentLoadingEventArgsResolver
    {
        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> is loading.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewContentLoadingEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        Uri Uri(WebViewContentLoadingEventArgs e);
    }
}
