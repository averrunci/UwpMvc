// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>
    /// resolved by <see cref="IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewUnsupportedUriSchemeIdentifiedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>.
        /// </summary>
        public static IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver Resolver { get; set; } = new DefaultWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this WebViewUnsupportedUriSchemeIdentifiedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this WebViewUnsupportedUriSchemeIdentifiedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> attempted to navigate to.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        public static Uri Uri(this WebViewUnsupportedUriSchemeIdentifiedEventArgs e) => Resolver.Uri(e);

        private sealed class DefaultWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver : IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver
        {
            bool IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver.Handled(WebViewUnsupportedUriSchemeIdentifiedEventArgs e) => e.Handled;
            void IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver.Handled(WebViewUnsupportedUriSchemeIdentifiedEventArgs e, bool handled) => e.Handled = handled;
            Uri IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver.Uri(WebViewUnsupportedUriSchemeIdentifiedEventArgs e) => e.Uri;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>.
    /// </summary>
    public interface IWebViewUnsupportedUriSchemeIdentifiedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(WebViewUnsupportedUriSchemeIdentifiedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(WebViewUnsupportedUriSchemeIdentifiedEventArgs e, bool handled);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> attempted to navigate to.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewUnsupportedUriSchemeIdentifiedEventArgs"/>.</param>
        /// <returns>The URI of the content.</returns>
        Uri Uri(WebViewUnsupportedUriSchemeIdentifiedEventArgs e);
    }
}
