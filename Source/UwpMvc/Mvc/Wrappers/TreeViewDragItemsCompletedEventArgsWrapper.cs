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
    /// Provides data of the <see cref="TreeViewDragItemsCompletedEventArgs"/>
    /// resolved by <see cref="ITreeViewDragItemsCompletedEventArgsResolver"/>.
    /// </summary>
    public static class TreeViewDragItemsCompletedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITreeViewDragItemsCompletedEventArgsResolver"/>
        /// that resolves data of the <see cref="TreeViewDragItemsCompletedEventArgs"/>.
        /// </summary>
        public static ITreeViewDragItemsCompletedEventArgsResolver Resolver { get; set; } = new DefaultTreeViewDragItemsCompletedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates what operation was performed on the dragged data, and whether it was successful.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns>A value of the enumeration that indicates what operation was performed on the dragged data.</returns>
        public static DataPackageOperation DropResult(this TreeViewDragItemsCompletedEventArgs e) => Resolver.DropResult(e);

        /// <summary>
        /// Gets the loosely typed collection of objects that are selected for the item drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns>A loosely typed collection of objects.</returns>
        public static IReadOnlyList<object> Items(this TreeViewDragItemsCompletedEventArgs e) => Resolver.Items(e);

        private sealed class DefaultTreeViewDragItemsCompletedEventArgsResolver : ITreeViewDragItemsCompletedEventArgsResolver
        {
            DataPackageOperation ITreeViewDragItemsCompletedEventArgsResolver.DropResult(TreeViewDragItemsCompletedEventArgs e) => e.DropResult;
            IReadOnlyList<object> ITreeViewDragItemsCompletedEventArgsResolver.Items(TreeViewDragItemsCompletedEventArgs e) => e.Items;
        }
    }

    /// <summary>
    /// Provides data of the <see cref="TreeViewDragItemsCompletedEventArgs"/>.
    /// </summary>
    public interface ITreeViewDragItemsCompletedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates what operation was performed on the dragged data, and whether it was successful.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns>A value of the enumeration that indicates what operation was performed on the dragged data.</returns>
        DataPackageOperation DropResult(TreeViewDragItemsCompletedEventArgs e);

        /// <summary>
        /// Gets the loosely typed collection of objects that are selected for the item drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="TreeViewDragItemsCompletedEventArgs"/>.</param>
        /// <returns>A loosely typed collection of objects.</returns>
        IReadOnlyList<object> Items(TreeViewDragItemsCompletedEventArgs e);
    }
}
