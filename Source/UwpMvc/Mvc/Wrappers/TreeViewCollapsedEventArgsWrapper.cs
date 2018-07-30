// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TreeViewCollapsedEventArgs"/>
    /// resolved by <see cref="ITreeViewCollapsedEventArgsResolver"/>.
    /// </summary>
    public static class TreeViewCollapsedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITreeViewCollapsedEventArgsResolver"/>
        /// that resolves data of the <see cref="TreeViewCollapsedEventArgs"/>.
        /// </summary>
        public static ITreeViewCollapsedEventArgsResolver Resolver { get; set; } = new DefaultTreeViewCollapsedEventArgsResolver();

        /// <summary>
        /// Gets the tree view node that is collapsed.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewCollapsedEventArgs"/>.</param>
        /// <returns>The tree view node that is collapsed.</returns>
        public static TreeViewNode Node(this TreeViewCollapsedEventArgs e) => Resolver.Node(e);

        private sealed class DefaultTreeViewCollapsedEventArgsResolver : ITreeViewCollapsedEventArgsResolver
        {
            TreeViewNode ITreeViewCollapsedEventArgsResolver.Node(TreeViewCollapsedEventArgs e) => e.Node;
        }
    }

    /// <summary>
    /// Provides data of the <see cref="TreeViewCollapsedEventArgs"/>.
    /// </summary>
    public interface ITreeViewCollapsedEventArgsResolver
    {
        /// <summary>
        /// Gets the tree view node that is collapsed.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewCollapsedEventArgs"/>.</param>
        /// <returns>The tree view node that is collapsed.</returns>
        TreeViewNode Node(TreeViewCollapsedEventArgs e);
    }
}
