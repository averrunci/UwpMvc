// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Text;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Documents;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ContentLinkChangedEventArgs"/>
    /// resolved by <see cref="IContentLinkChangedEventArgsResolver"/>.
    /// </summary>
    public static class ContentLinkChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IContentLinkChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="ContentLinkChangedEventArgs"/>.
        /// </summary>
        public static IContentLinkChangedEventArgsResolver Resolver { get; set; } = new DefaultContentLinkChangedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates how the content link is changed.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkChangedEventArgs"/>.</param>
        /// <returns>An enumeration value that indicates how the content link is changed.</returns>
        public static ContentLinkChangeKind ChangeKind(this ContentLinkChangedEventArgs e) => Resolver.ChangeKind(e);

        /// <summary>
        /// Gets an object that contains information about the content link.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkChangedEventArgs"/>.</param>
        /// <returns>An object that contains information about the content link.</returns>
        public static ContentLinkInfo ContentLinkInfo(this ContentLinkChangedEventArgs e) => Resolver.ContentLinkInfo(e);

        /// <summary>
        /// Gets the text range that contains the content link.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkChangedEventArgs"/>.</param>
        /// <returns>The text range that contains the content link.</returns>
        public static TextRange TextRange(this ContentLinkChangedEventArgs e) => Resolver.TextRange(e);

        private sealed class DefaultContentLinkChangedEventArgsResolver : IContentLinkChangedEventArgsResolver
        {
            ContentLinkChangeKind IContentLinkChangedEventArgsResolver.ChangeKind(ContentLinkChangedEventArgs e) => e.ChangeKind;
            ContentLinkInfo IContentLinkChangedEventArgsResolver.ContentLinkInfo(ContentLinkChangedEventArgs e) => e.ContentLinkInfo;
            TextRange IContentLinkChangedEventArgsResolver.TextRange(ContentLinkChangedEventArgs e) => e.TextRange;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ContentLinkChangedEventArgs"/>.
    /// </summary>
    public interface IContentLinkChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates how the content link is changed.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkChangedEventArgs"/>.</param>
        /// <returns>An enumeration value that indicates how the content link is changed.</returns>
        ContentLinkChangeKind ChangeKind(ContentLinkChangedEventArgs e);

        /// <summary>
        /// Gets an object that contains information about the content link.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkChangedEventArgs"/>.</param>
        /// <returns>An object that contains information about the content link.</returns>
        ContentLinkInfo ContentLinkInfo(ContentLinkChangedEventArgs e);

        /// <summary>
        /// Gets the text range that contains the content link.
        /// </summary>
        /// <param name="e">The requested <see cref="ContentLinkChangedEventArgs"/>.</param>
        /// <returns>The text range that contains the content link.</returns>
        TextRange TextRange(ContentLinkChangedEventArgs e);
    }
}
