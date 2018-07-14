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
    /// Provides data of the <see cref="WebViewNavigationCompletedEventArgs"/>
    /// resolved by <see cref="IWebViewNavigationCompletedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewNavigationCompletedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewNavigationCompletedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewNavigationCompletedEventArgs"/>.
        /// </summary>
        public static IWebViewNavigationCompletedEventArgsResolver Resolver { get; set; } = new DefaultWebViewNavigationCompletedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the navigation completed successfully.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationCompletedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the navigation completed successfully; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsSuccess(this WebViewNavigationCompletedEventArgs e) => Resolver.IsSuccess(e);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the <see cref="WebView"/> content.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationCompletedEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        public static Uri Uri(this WebViewNavigationCompletedEventArgs e) => Resolver.Uri(e);

        /// <summary>
        /// If the navigation was unsuccessful, gets a value that indicates why.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationCompletedEventArgs"/>.</param>
        /// <returns>A value that explains an unsuccessful navigation.</returns>
        public static WebErrorStatus WebErrorStatus(this WebViewNavigationCompletedEventArgs e) => Resolver.WebErrorStatus(e);

        private sealed class DefaultWebViewNavigationCompletedEventArgsResolver : IWebViewNavigationCompletedEventArgsResolver
        {
            bool IWebViewNavigationCompletedEventArgsResolver.IsSuccess(WebViewNavigationCompletedEventArgs e) => e.IsSuccess;
            Uri IWebViewNavigationCompletedEventArgsResolver.Uri(WebViewNavigationCompletedEventArgs e) => e.Uri;
            WebErrorStatus IWebViewNavigationCompletedEventArgsResolver.WebErrorStatus(WebViewNavigationCompletedEventArgs e) => e.WebErrorStatus;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewNavigationCompletedEventArgs"/>.
    /// </summary>
    public interface IWebViewNavigationCompletedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the navigation completed successfully.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationCompletedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the navigation completed successfully; otherwise, <c>false</c>.
        /// </returns>
        bool IsSuccess(WebViewNavigationCompletedEventArgs e);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the <see cref="WebView"/> content.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationCompletedEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        Uri Uri(WebViewNavigationCompletedEventArgs e);

        /// <summary>
        /// If the navigation was unsuccessful, gets a value that indicates why.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNavigationCompletedEventArgs"/>.</param>
        /// <returns>A value that explains an unsuccessful navigation.</returns>
        WebErrorStatus WebErrorStatus(WebViewNavigationCompletedEventArgs e);
    }
}
