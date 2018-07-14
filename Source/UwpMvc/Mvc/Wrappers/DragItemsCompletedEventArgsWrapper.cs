// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.ApplicationModel.DataTransfer;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DragItemsCompletedEventArgs"/>
    /// resolved by <see cref="IDragItemsCompletedEventArgsResolver"/>.
    /// </summary>
    public static class DragItemsCompletedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragItemsCompletedEventArgsResolver"/>
        /// that resolves data of the <see cref="DragItemsCompletedEventArgs"/>.
        /// </summary>
        public static IDragItemsCompletedEventArgsResolver Resolver { get; set; } = new DefaultDragItemCompletedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates what operation was performed on the dragged data,
        /// and whether it was successful.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsCompletedEventArgs"/>.</param>
        /// <returns>
        /// A value of the <see cref="DataPackageOperation"/> enumeration that indicates
        /// what operation was performed on the dragged data.
        /// </returns>
        public static DataPackageOperation DropResult(this DragItemsCompletedEventArgs e) => Resolver.DropResult(e);

        /// <summary>
        /// Gets the loosely typed collection of objects that are selected for the item drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsCompletedEventArgs"/>.</param>
        /// <returns>A loosely typed collection of objects.</returns>
        public static IReadOnlyList<object> Items(this DragItemsCompletedEventArgs e) => Resolver.Items(e);

        private sealed class DefaultDragItemCompletedEventArgsResolver : IDragItemsCompletedEventArgsResolver
        {
            DataPackageOperation IDragItemsCompletedEventArgsResolver.DropResult(DragItemsCompletedEventArgs e) => e.DropResult;
            IReadOnlyList<object> IDragItemsCompletedEventArgsResolver.Items(DragItemsCompletedEventArgs e) => e.Items;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DragItemsCompletedEventArgs"/>.
    /// </summary>
    public interface IDragItemsCompletedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates what operation was performed on the dragged data,
        /// and whether it was successful.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsCompletedEventArgs"/>.</param>
        /// <returns>
        /// A value of the <see cref="DataPackageOperation"/> enumeration that indicates
        /// what operation was performed on the dragged data.
        /// </returns>
        DataPackageOperation DropResult(DragItemsCompletedEventArgs e);

        /// <summary>
        /// Gets the loosely typed collection of objects that are selected for the item drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsCompletedEventArgs"/>.</param>
        /// <returns>A loosely typed collection of objects.</returns>
        IReadOnlyList<object> Items(DragItemsCompletedEventArgs e);
    }
}
