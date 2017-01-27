// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="NotifyEventArgs"/>
    /// resolved by <see cref="INotifyEventArgsResolver"/>.
    /// </summary>
    public static class NotifyEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="INotifyEventArgsResolver"/>
        /// that resolves data of the <see cref="NotifyEventArgs"/>.
        /// </summary>
        public static INotifyEventArgsResolver Resolver { get; set; } = new DefaultNotifyEventArgsResolver();

        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the page containing the script
        /// that raised the <see cref="WebView.ScriptNotify"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="NotifyEventArgs"/>.</param>
        /// <returns>The URI of the page that raised the event.</returns>
        public static Uri CallingUri(this NotifyEventArgs e) => Resolver.CallingUri(e);

        /// <summary>
        /// Gets the method name as passed to the application.
        /// </summary>
        /// <param name="e">The requested <see cref="NotifyEventArgs"/>.</param>
        /// <returns>The JavaScript method name.</returns>
        public static string Value(this NotifyEventArgs e) => Resolver.Value(e);

        private sealed class DefaultNotifyEventArgsResolver : INotifyEventArgsResolver
        {
            Uri INotifyEventArgsResolver.CallingUri(NotifyEventArgs e) => e.CallingUri;
            string INotifyEventArgsResolver.Value(NotifyEventArgs e) => e.Value;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="NotifyEventArgs"/>.
    /// </summary>
    public interface INotifyEventArgsResolver
    {
        /// <summary>
        /// Gets the Uniform Resource Identifier (URI) of the page containing the script
        /// that raised the <see cref="WebView.ScriptNotify"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="NotifyEventArgs"/>.</param>
        /// <returns>The URI of the page that raised the event.</returns>
        Uri CallingUri(NotifyEventArgs e);

        /// <summary>
        /// Gets the method name as passed to the application.
        /// </summary>
        /// <param name="e">The requested <see cref="NotifyEventArgs"/>.</param>
        /// <returns>The JavaScript method name.</returns>
        string Value(NotifyEventArgs e);
    }
}
