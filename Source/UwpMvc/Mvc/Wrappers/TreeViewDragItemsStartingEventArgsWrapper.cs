// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TreeViewDragItemsStartingEventArgs"/>
    /// resolved by <see cref="ITreeViewDragItemsStartingEventArgsResolver"/>.
    /// </summary>
    public static class TreeViewDragItemsStartingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITreeViewDragItemsStartingEventArgsResolver"/>
        /// that resolves data of the <see cref="TreeViewDragItemsStartingEventArgs"/>.
        /// </summary>
        public static ITreeViewDragItemsStartingEventArgsResolver Resolver { get; set; } = new DefaultTreeViewDragItemsStartingEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the item drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the item drag action; otherwise, <c>false</c>.</returns>
        public static bool Cancel(this TreeViewDragItemsStartingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that indicates whether the item drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the item drag action; otherwise, <c>false</c>.</param>
        public static void Cancel(this TreeViewDragItemsStartingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Gets the data payload associated with an items drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns>The data payload.</returns>
        public static DataPackage Data(this TreeViewDragItemsStartingEventArgs e) => Resolver.Data(e);

        /// <summary>
        /// Gets the loosely typed collection of objects that are selected for the item drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns>A loosely typed collection of objects.</returns>
        public static IList<object> Items(this TreeViewDragItemsStartingEventArgs e) => Resolver.Items(e);

        private sealed class DefaultTreeViewDragItemsStartingEventArgsResolver : ITreeViewDragItemsStartingEventArgsResolver
        {
            bool ITreeViewDragItemsStartingEventArgsResolver.Cancel(TreeViewDragItemsStartingEventArgs e) => e.Cancel;
            void ITreeViewDragItemsStartingEventArgsResolver.Cancel(TreeViewDragItemsStartingEventArgs e, bool cancel) => e.Cancel = cancel;
            DataPackage ITreeViewDragItemsStartingEventArgsResolver.Data(TreeViewDragItemsStartingEventArgs e) => e.Data;
            IList<object> ITreeViewDragItemsStartingEventArgsResolver.Items(TreeViewDragItemsStartingEventArgs e) => e.Items;
        }
    }

    /// <summary>
    /// Provides data of the <see cref="TreeViewDragItemsStartingEventArgs"/>.
    /// </summary>
    public interface ITreeViewDragItemsStartingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the item drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the item drag action; otherwise, <c>false</c>.</returns>
        bool Cancel(TreeViewDragItemsStartingEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the item drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the item drag action; otherwise, <c>false</c>.</param>
        void Cancel(TreeViewDragItemsStartingEventArgs e, bool cancel);

        /// <summary>
        /// Gets the data payload associated with an items drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns>The data payload.</returns>
        DataPackage Data(TreeViewDragItemsStartingEventArgs e);

        /// <summary>
        /// Gets the loosely typed collection of objects that are selected for the item drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns>A loosely typed collection of objects.</returns>
        IList<object> Items(TreeViewDragItemsStartingEventArgs e);
    }
}
