// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewNewWindowRequestedEventArgs"/>
    /// resolved by <see cref="IWebViewNewWindowRequestedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewNewWindowRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewNewWindowRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewNewWindowRequestedEventArgs"/>.
        /// </summary>
        public static IWebViewNewWindowRequestedEventArgsResolver Resolver { get; set; } = new DefaultWebViewNewWindowRequestedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNewWindowRequestedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this WebViewNewWindowRequestedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNewWindowRequestedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this WebViewNewWindowRequestedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content where the navigation was initiated.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNewWindowRequestedEventArgs"/>.</param>
        /// <returns>The URI of the content where the navigation was initiated.</returns>
        public static Uri Referrer(this WebViewNewWindowRequestedEventArgs e) => Resolver.Referrer(e);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> is attempting to navigate to.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNewWindowRequestedEventArgs"/>.</param>
        /// <returns>The URI of the content the <see cref="WebView"/> is attempting to navigate to.</returns>
        public static Uri Uri(this WebViewNewWindowRequestedEventArgs e) => Resolver.Uri(e);

        private sealed class DefaultWebViewNewWindowRequestedEventArgsResolver : IWebViewNewWindowRequestedEventArgsResolver
        {
            bool IWebViewNewWindowRequestedEventArgsResolver.Handled(WebViewNewWindowRequestedEventArgs e) => e.Handled;
            void IWebViewNewWindowRequestedEventArgsResolver.Handled(WebViewNewWindowRequestedEventArgs e, bool handled) => e.Handled = handled;
            Uri IWebViewNewWindowRequestedEventArgsResolver.Referrer(WebViewNewWindowRequestedEventArgs e) => e.Referrer;
            Uri IWebViewNewWindowRequestedEventArgsResolver.Uri(WebViewNewWindowRequestedEventArgs e) => e.Uri;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewNewWindowRequestedEventArgs"/>.
    /// </summary>
    public interface IWebViewNewWindowRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNewWindowRequestedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(WebViewNewWindowRequestedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNewWindowRequestedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(WebViewNewWindowRequestedEventArgs e, bool handled);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content where the navigation was initiated.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNewWindowRequestedEventArgs"/>.</param>
        /// <returns>The URI of the content where the navigation was initiated.</returns>
        Uri Referrer(WebViewNewWindowRequestedEventArgs e);

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the content the <see cref="WebView"/> is attempting to navigate to.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewNewWindowRequestedEventArgs"/>.</param>
        /// <returns>The URI of the content the <see cref="WebView"/> is attempting to navigate to.</returns>
        Uri Uri(WebViewNewWindowRequestedEventArgs e);
    }
}
