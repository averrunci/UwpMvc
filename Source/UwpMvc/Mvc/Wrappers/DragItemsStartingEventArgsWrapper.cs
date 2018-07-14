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
    /// Provides data of the <see cref="DragItemsStartingEventArgs"/>
    /// resolved by <see cref="IDragItemsStartingEventArgsResolver"/>.
    /// </summary>
    public static class DragItemsStartingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDragItemsStartingEventArgsResolver"/>
        /// that resolves data of the <see cref="DragItemsStartingEventArgs"/>.
        /// </summary>
        public static IDragItemsStartingEventArgsResolver Resolver { get; set; } = new DefaultDragItemsStartingEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the item drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsStartingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the item drag action; otherwise, <c>false</c>.
        /// </returns>
        public static bool Cancel(this DragItemsStartingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that indicates whether the item drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsStartingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the item drag action; otherwise, <c>false</c>.
        /// </param>
        public static void Cancel(this DragItemsStartingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Gets the data payload associated with an items drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsStartingEventArgs"/>.</param>
        /// <returns>The data payload.</returns>
        public static DataPackage Data(this DragItemsStartingEventArgs e) => Resolver.Data(e);

        /// <summary>
        /// Gets the loosely typed collection of objects that are selected for the item drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsStartingEventArgs"/>.</param>
        /// <returns>A loosely typed collection of objects.</returns>
        public static IList<object> Items(this DragItemsStartingEventArgs e) => Resolver.Items(e);

        private sealed class DefaultDragItemsStartingEventArgsResolver : IDragItemsStartingEventArgsResolver
        {
            bool IDragItemsStartingEventArgsResolver.Cancel(DragItemsStartingEventArgs e) => e.Cancel;
            void IDragItemsStartingEventArgsResolver.Cancel(DragItemsStartingEventArgs e, bool cancel) => e.Cancel = cancel;
            DataPackage IDragItemsStartingEventArgsResolver.Data(DragItemsStartingEventArgs e) => e.Data;
            IList<object> IDragItemsStartingEventArgsResolver.Items(DragItemsStartingEventArgs e) => e.Items;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DragItemsStartingEventArgs"/>.
    /// </summary>
    public interface IDragItemsStartingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the item drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsStartingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to cancel the item drag action; otherwise, <c>false</c>.
        /// </returns>
        bool Cancel(DragItemsStartingEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the item drag action should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsStartingEventArgs"/>.</param>
        /// <param name="cancel">
        /// <c>true</c> to cancel the item drag action; otherwise, <c>false</c>.
        /// </param>
        void Cancel(DragItemsStartingEventArgs e, bool cancel);

        /// <summary>
        /// Gets the data payload associated with an items drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsStartingEventArgs"/>.</param>
        /// <returns>The data payload.</returns>
        DataPackage Data(DragItemsStartingEventArgs e);

        /// <summary>
        /// Gets the loosely typed collection of objects that are selected for the item drag action.
        /// </summary>
        /// <param name="e">The requested <see cref="DragItemsStartingEventArgs"/>.</param>
        /// <returns>A loosely typed collection of objects.</returns>
        IList<object> Items(DragItemsStartingEventArgs e);
    }
}
