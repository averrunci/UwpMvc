// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewDOMContentLoadedEventArgs"/>
    /// resolved by <see cref="IWebViewDOMContentLoadedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewDOMContentLoadedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewDOMContentLoadedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewDOMContentLoadedEventArgs"/>.
        /// </summary>
        public static IWebViewDOMContentLoadedEventArgsResolver Resolver { get; set; } = new DefaultWebViewDOMContentLoadedEventArgsResolver();

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> is loading.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewDOMContentLoadedEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        public static Uri Uri(this WebViewDOMContentLoadedEventArgs e) => Resolver.Uri(e);

        private sealed class DefaultWebViewDOMContentLoadedEventArgsResolver : IWebViewDOMContentLoadedEventArgsResolver
        {
            Uri IWebViewDOMContentLoadedEventArgsResolver.Uri(WebViewDOMContentLoadedEventArgs e) => e.Uri;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewDOMContentLoadedEventArgs"/>.
    /// </summary>
    public interface IWebViewDOMContentLoadedEventArgsResolver
    {
        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> is loading.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewDOMContentLoadedEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        Uri Uri(WebViewDOMContentLoadedEventArgs e);
    }
}
