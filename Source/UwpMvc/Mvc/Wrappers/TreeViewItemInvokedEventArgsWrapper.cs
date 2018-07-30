// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TreeViewItemInvokedEventArgs"/>
    /// resolved by <see cref="ITreeViewItemInvokedEventArgsResolver"/>.
    /// </summary>
    public static class TreeViewItemInvokedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITreeViewItemInvokedEventArgsResolver"/>
        /// that resolves data of the <see cref="TreeViewItemInvokedEventArgs"/>.
        /// </summary>
        public static ITreeViewItemInvokedEventArgsResolver Resolver { get; set; } = new DefaultTreeViewItemInvokedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value of prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewItemInvokedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to
        /// potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        public static bool Handled(this TreeViewItemInvokedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value of prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewItemInvokedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to
        /// potentially route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this TreeViewItemInvokedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the tree view item that is invoked.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewItemInvokedEventArgs"/>.</param>
        /// <returns>The tree view that is invoked.</returns>
        public static object InvokedItem(this TreeViewItemInvokedEventArgs e) => Resolver.InvokedItem(e);

        private sealed class DefaultTreeViewItemInvokedEventArgsResolver : ITreeViewItemInvokedEventArgsResolver
        {
            bool ITreeViewItemInvokedEventArgsResolver.Handled(TreeViewItemInvokedEventArgs e) => e.Handled;
            void ITreeViewItemInvokedEventArgsResolver.Handled(TreeViewItemInvokedEventArgs e, bool handled) => e.Handled = handled;
            object ITreeViewItemInvokedEventArgsResolver.InvokedItem(TreeViewItemInvokedEventArgs e) => e.InvokedItem;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TreeViewItemInvokedEventArgs"/>.
    /// </summary>
    public interface ITreeViewItemInvokedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value of prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewItemInvokedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to
        /// potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        bool Handled(TreeViewItemInvokedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value of prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewItemInvokedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to
        /// potentially route further and be acted on by other handlers.
        /// </param>
        void Handled(TreeViewItemInvokedEventArgs e, bool handled);

        /// <summary>
        /// Gets the tree view item that is invoked.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewItemInvokedEventArgs"/>.</param>
        /// <returns>The tree view that is invoked.</returns>
        object InvokedItem(TreeViewItemInvokedEventArgs e);
    }
}
