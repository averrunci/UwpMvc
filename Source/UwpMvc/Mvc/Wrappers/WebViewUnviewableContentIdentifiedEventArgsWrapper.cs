// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewUnviewableContentIdentifiedEventArgs"/>
    /// resolved by <see cref="IWebViewUnviewableContentIdentifiedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewUnviewableContentIdentifiedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewUnviewableContentIdentifiedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewUnviewableContentIdentifiedEventArgs"/>.
        /// </summary>
        public static IWebViewUnviewableContentIdentifiedEventArgsResolver Resolver { get; set; } = new DefaultWebViewUnviewableContentIdentifiedEventArgsResolver();

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the page that contains the link to the unviewable content.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnviewableContentIdentifiedEventArgs"/>.</param>
        /// <returns>The URI of the referring page.</returns>
        public static Uri Referrer(this WebViewUnviewableContentIdentifiedEventArgs e) => Resolver.Referrer(e);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> attempted to load.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnviewableContentIdentifiedEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        public static Uri Uri(this WebViewUnviewableContentIdentifiedEventArgs e) => Resolver.Uri(e);

        private sealed class DefaultWebViewUnviewableContentIdentifiedEventArgsResolver : IWebViewUnviewableContentIdentifiedEventArgsResolver
        {
            Uri IWebViewUnviewableContentIdentifiedEventArgsResolver.Referrer(WebViewUnviewableContentIdentifiedEventArgs e) => e.Referrer;
            Uri IWebViewUnviewableContentIdentifiedEventArgsResolver.Uri(WebViewUnviewableContentIdentifiedEventArgs e) => e.Uri;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewUnviewableContentIdentifiedEventArgs"/>.
    /// </summary>
    public interface IWebViewUnviewableContentIdentifiedEventArgsResolver
    {
        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the page that contains the link to the unviewable content.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnviewableContentIdentifiedEventArgs"/>.</param>
        /// <returns>The URI of the referring page.</returns>
        Uri Referrer(WebViewUnviewableContentIdentifiedEventArgs e);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> attempted to load.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnviewableContentIdentifiedEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        Uri Uri(WebViewUnviewableContentIdentifiedEventArgs e);
    }
}
