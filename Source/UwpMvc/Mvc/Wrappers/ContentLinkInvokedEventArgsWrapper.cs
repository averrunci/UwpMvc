// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Text;
using Windows.UI.Xaml.Documents;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ContentLinkInvokedEventArgs"/>
    /// resolved by <see cref="IContentLinkInvokedEventArgsResolver"/>.
    /// </summary>
    public static class ContentLinkInvokedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IContentLinkInvokedEventArgsResolver"/>
        /// that resolves data of the <see cref="ContentLinkInvokedEventArgs"/>.
        /// </summary>
        public static IContentLinkInvokedEventArgsResolver Resolver { get; set; } = new DefaultContentLinkInvokedEventArgsResolver();

        /// <summary>
        /// Gets the ContentLinkInfo object that contains the data for the invoked link.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkInvokedEventArgs"/>.</param>
        /// <returns>The ContentLinkInfo object that contains the data for the invoked link.</returns>
        public static ContentLinkInfo ContentLinkInfo(this ContentLinkInvokedEventArgs e) => Resolver.ContentLinkInfo(e);

        /// <summary>
        /// Gets a value that marks the event as handled.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkInvokedEventArgs"/>.</param>
        /// <returns><c>true</c> to mark the event as handled; otherwise, <c>false</c>.</returns>
        public static bool Handled(this ContentLinkInvokedEventArgs e) => Resolver.Handled(e);

        /// <summary>Sets a value that marks the event as handled.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkInvokedEventArgs"/>.</param>
        /// <param name="handled"><c>true</c> to mark the event as handled; otherwise, <c>false</c>.</param>
        public static void Handled(this ContentLinkInvokedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        private sealed class DefaultContentLinkInvokedEventArgsResolver : IContentLinkInvokedEventArgsResolver
        {
            ContentLinkInfo IContentLinkInvokedEventArgsResolver.ContentLinkInfo(ContentLinkInvokedEventArgs e) => e.ContentLinkInfo;
            bool IContentLinkInvokedEventArgsResolver.Handled(ContentLinkInvokedEventArgs e) => e.Handled;
            void IContentLinkInvokedEventArgsResolver.Handled(ContentLinkInvokedEventArgs e, bool handled) => e.Handled = handled;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ContentLinkInvokedEventArgs"/>.
    /// </summary>
    public interface IContentLinkInvokedEventArgsResolver
    {
        /// <summary>
        /// Gets the ContentLinkInfo object that contains the data for the invoked link.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkInvokedEventArgs"/>.</param>
        /// <returns>The ContentLinkInfo object that contains the data for the invoked link.</returns>
        ContentLinkInfo ContentLinkInfo(ContentLinkInvokedEventArgs e);

        /// <summary>
        /// Gets a value that marks the event as handled.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkInvokedEventArgs"/>.</param>
        /// <returns><c>true</c> to mark the event as handled; otherwise, <c>false</c>.</returns>
        bool Handled(ContentLinkInvokedEventArgs e);

        /// <summary>Sets a value that marks the event as handled.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkInvokedEventArgs"/>.</param>
        /// <param name="handled"><c>true</c> to mark the event as handled; otherwise, <c>false</c>.</param>
        void Handled(ContentLinkInvokedEventArgs e, bool handled);
    }
}
