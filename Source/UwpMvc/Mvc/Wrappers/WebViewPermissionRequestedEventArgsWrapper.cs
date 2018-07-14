// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewPermissionRequestedEventArgs"/>
    /// resolved by <see cref="IWebViewPermissionRequestedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewPermissionRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewPermissionRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewPermissionRequestedEventArgs"/>.
        /// </summary>
        public static IWebViewPermissionRequestedEventArgsResolver Resolver { get; set; } = new DefaultWebViewPermissionRequestedEventArgsResolver();

        /// <summary>
        /// Gets the <see cref="WebViewPermissionRequest"/> object that contains information about the request.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewPermissionRequestedEventArgs"/>.</param>
        /// <returns>The <see cref="WebViewPermissionRequest"/> object that contains information about the request.</returns>
        public static WebViewPermissionRequest PermissionRequest(this WebViewPermissionRequestedEventArgs e) => Resolver.PermissionRequest(e);

        private sealed class DefaultWebViewPermissionRequestedEventArgsResolver : IWebViewPermissionRequestedEventArgsResolver
        {
            WebViewPermissionRequest IWebViewPermissionRequestedEventArgsResolver.PermissionRequest(WebViewPermissionRequestedEventArgs e) => e.PermissionRequest;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewPermissionRequestedEventArgs"/>.
    /// </summary>
    public interface IWebViewPermissionRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets the <see cref="WebViewPermissionRequest"/> object that contains information about the request.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewPermissionRequestedEventArgs"/>.</param>
        /// <returns>The <see cref="WebViewPermissionRequest"/> object that contains information about the request.</returns>
        WebViewPermissionRequest PermissionRequest(WebViewPermissionRequestedEventArgs e);
    }
}
