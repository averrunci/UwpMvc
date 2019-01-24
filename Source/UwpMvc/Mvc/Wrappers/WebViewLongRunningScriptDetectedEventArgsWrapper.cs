// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="WebViewLongRunningScriptDetectedEventArgs"/>
    /// resolved by <see cref="IWebViewLongRunningScriptDetectedEventArgsResolver"/>.
    /// </summary>
    public static class WebViewLongRunningScriptDetectedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IWebViewLongRunningScriptDetectedEventArgsResolver"/>
        /// that resolves data of the <see cref="WebViewLongRunningScriptDetectedEventArgs"/>.
        /// </summary>
        public static IWebViewLongRunningScriptDetectedEventArgsResolver Resolver { get; set; } = new DefaultWebViewLongRunningScriptDetectedEventArgsResolver();

        /// <summary>
        /// Gets the number of milliseconds that the <see cref="WebView"/> control has been executing a long-running script.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewLongRunningScriptDetectedEventArgs"/>.</param>
        /// <returns>The number of milliseconds the script has been running.</returns>
        public static TimeSpan ExceptionTime(this WebViewLongRunningScriptDetectedEventArgs e) => Resolver.ExceptionTime(e);

        /// <summary>
        /// Halts a long-running script executing in a <see cref="WebView"/> control.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewLongRunningScriptDetectedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to halt the script; otherwise, <c>false</c>.
        /// </returns>
        public static bool StopPageScriptExecution(this WebViewLongRunningScriptDetectedEventArgs e) => Resolver.StopPageScriptExecution(e);

        private sealed class DefaultWebViewLongRunningScriptDetectedEventArgsResolver : IWebViewLongRunningScriptDetectedEventArgsResolver
        {
            TimeSpan IWebViewLongRunningScriptDetectedEventArgsResolver.ExceptionTime(WebViewLongRunningScriptDetectedEventArgs e) => e.ExecutionTime;
            bool IWebViewLongRunningScriptDetectedEventArgsResolver.StopPageScriptExecution(WebViewLongRunningScriptDetectedEventArgs e) => e.StopPageScriptExecution;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="WebViewLongRunningScriptDetectedEventArgs"/>.
    /// </summary>
    public interface IWebViewLongRunningScriptDetectedEventArgsResolver
    {
        /// <summary>
        /// Gets the number of milliseconds that the <see cref="WebView"/> control has been executing a long-running script.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewLongRunningScriptDetectedEventArgs"/>.</param>
        /// <returns>The number of milliseconds the script has been running.</returns>
        TimeSpan ExceptionTime(WebViewLongRunningScriptDetectedEventArgs e);

        /// <summary>
        /// Halts a long-running script executing in a <see cref="WebView"/> control.
        /// </summary>
        /// <param name="e">The requested <see cref="WebViewLongRunningScriptDetectedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to halt the script; otherwise, <c>false</c>.
        /// </returns>
        bool StopPageScriptExecution(WebViewLongRunningScriptDetectedEventArgs e);
    }
}
