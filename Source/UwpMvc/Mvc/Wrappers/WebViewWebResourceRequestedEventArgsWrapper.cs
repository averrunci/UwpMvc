// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.Web.Http;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewWebResourceRequestedEventArgs"/>
    /// resolved by <see cref="IWebViewWebResourceRequestedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewWebResourceRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewWebResourceRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewWebResourceRequestedEventArgs"/>.
        /// </summary>
        public static IWebViewWebResourceRequestedEventArgsResolver Resolver { get; set; } = new DefaultWebViewWebResourceRequestedEventArgsResolver();

        /// <summary>
        /// Gets the web resource request.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewWebResourceRequestedEventArgs"/>.</param>
        /// <returns>The web resource request.</returns>
        public static HttpRequestMessage Request(this WebViewWebResourceRequestedEventArgs e) => Resolver.Request(e);

        /// <summary>
        /// Gets the response to the web resource request.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewWebResourceRequestedEventArgs"/>.</param>
        /// <returns>The response to the web resource request.</returns>
        public static HttpResponseMessage Response(this WebViewWebResourceRequestedEventArgs e) => Resolver.Response(e);

        /// <summary>
        /// Sets the response to the web resource request.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewWebResourceRequestedEventArgs"/>.</param>
        /// <param name="response">The response to the web resource request.</param>
        public static void Response(this WebViewWebResourceRequestedEventArgs e, HttpResponseMessage response) => Resolver.Response(e, response);

        /// <summary>
        /// Gets a deferral object for managing the work done in the WebResourceRequested event handler.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewWebResourceRequestedEventArgs"/>.</param>
        /// <returns>A deferral object.</returns>
        public static Deferral GetDeferralWrapped(this WebViewWebResourceRequestedEventArgs e) => Resolver.GetDeferral(e);

        private sealed class DefaultWebViewWebResourceRequestedEventArgsResolver : IWebViewWebResourceRequestedEventArgsResolver
        {
            HttpRequestMessage IWebViewWebResourceRequestedEventArgsResolver.Request(WebViewWebResourceRequestedEventArgs e) => e.Request;
            HttpResponseMessage IWebViewWebResourceRequestedEventArgsResolver.Response(WebViewWebResourceRequestedEventArgs e) => e.Response;
            void IWebViewWebResourceRequestedEventArgsResolver.Response(WebViewWebResourceRequestedEventArgs e, HttpResponseMessage response) => e.Response = response;
            Deferral IWebViewWebResourceRequestedEventArgsResolver.GetDeferral(WebViewWebResourceRequestedEventArgs e) => e.GetDeferral();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewWebResourceRequestedEventArgs"/>.
    /// </summary>
    public interface IWebViewWebResourceRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets the web resource request.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewWebResourceRequestedEventArgs"/>.</param>
        /// <returns>The web resource request.</returns>
        HttpRequestMessage Request(WebViewWebResourceRequestedEventArgs e);

        /// <summary>
        /// Gets the response to the web resource request.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewWebResourceRequestedEventArgs"/>.</param>
        /// <returns>The response to the web resource request.</returns>
        HttpResponseMessage Response(WebViewWebResourceRequestedEventArgs e);

        /// <summary>
        /// Sets the response to the web resource request.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewWebResourceRequestedEventArgs"/>.</param>
        /// <param name="response">The response to the web resource request.</param>
        void Response(WebViewWebResourceRequestedEventArgs e, HttpResponseMessage response);

        /// <summary>
        /// Gets a deferral object for managing the work done in the WebResourceRequested event handler.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewWebResourceRequestedEventArgs"/>.</param>
        /// <returns>A deferral object.</returns>
        Deferral GetDeferral(WebViewWebResourceRequestedEventArgs e);
    }
}
