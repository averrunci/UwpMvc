// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ChoosingItemContainerEventArgs"/>
    /// resolved by <see cref="IChoosingItemContainerEventArgsResolver"/>.
    /// </summary>
    public static class ChoosingItemContainerEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IChoosingItemContainerEventArgsResolver"/>
        /// that resolves data of the <see cref="ChoosingItemContainerEventArgs"/>.
        /// </summary>
        public static IChoosingItemContainerEventArgsResolver Resolver { get; set; } = new DefaultChoosingItemContainerEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the container is ready for use.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the container is ready for use; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsContainerPrepared(this ChoosingItemContainerEventArgs e) => Resolver.IsContainerPrepared(e);

        /// <summary>
        /// Sets a value that indicates whether the container is ready for use.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <param name="isContainerPrepared">
        /// <c>true</c> if the container is ready for use; otherwise, <c>false</c>.
        /// </param>
        public static void IsContainerPrepared(this ChoosingItemContainerEventArgs e, bool isContainerPrepared) => Resolver.IsContainerPrepared(e, isContainerPrepared);

        /// <summary>
        /// Gets the data item associated with this <see cref="ChoosingItemContainerEventArgs.ItemContainer"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <returns>
        /// The data item associated with this <see cref="ChoosingItemContainerEventArgs.ItemContainer"/>.
        /// </returns>
        public static object Item(this ChoosingItemContainerEventArgs e) => Resolver.Item(e);

        /// <summary>
        /// Gets the UI container that will be used to display the current data item.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <returns>The UI container that will be used to display the current data item.</returns>
        public static SelectorItem ItemContainer(this ChoosingItemContainerEventArgs e) => Resolver.ItemContainer(e);

        /// <summary>
        /// Sets the UI container that will be used to display the current data item.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <param name="itemContainer">
        /// The UI container that will be used to display the current data item.
        /// </param>
        public static void ItemContainer(this ChoosingItemContainerEventArgs e, SelectorItem itemContainer) => Resolver.ItemContainer(e, itemContainer);

        /// <summary>
        /// Gets the index in the <see cref="ItemsControl.ItemsSource"/> of the data item
        /// for which a container is being selected.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <returns>
        /// The index in the <see cref="ItemsControl.ItemsSource"/> of the data item
        /// for which a container is being selected.
        /// </returns>
        public static int ItemIndex(this ChoosingItemContainerEventArgs e) => Resolver.ItemIndex(e);

        private sealed class DefaultChoosingItemContainerEventArgsResolver : IChoosingItemContainerEventArgsResolver
        {
            bool IChoosingItemContainerEventArgsResolver.IsContainerPrepared(ChoosingItemContainerEventArgs e) => e.IsContainerPrepared;
            void IChoosingItemContainerEventArgsResolver.IsContainerPrepared(ChoosingItemContainerEventArgs e, bool isContainerPrepared) => e.IsContainerPrepared = isContainerPrepared;
            object IChoosingItemContainerEventArgsResolver.Item(ChoosingItemContainerEventArgs e) => e.Item;
            SelectorItem IChoosingItemContainerEventArgsResolver.ItemContainer(ChoosingItemContainerEventArgs e) => e.ItemContainer;
            void IChoosingItemContainerEventArgsResolver.ItemContainer(ChoosingItemContainerEventArgs e, SelectorItem itemContainer) => e.ItemContainer = itemContainer;
            int IChoosingItemContainerEventArgsResolver.ItemIndex(ChoosingItemContainerEventArgs e) => e.ItemIndex;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ChoosingItemContainerEventArgs"/>.
    /// </summary>
    public interface IChoosingItemContainerEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the container is ready for use.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the container is ready for use; otherwise, <c>false</c>.
        /// </returns>
        bool IsContainerPrepared(ChoosingItemContainerEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the container is ready for use.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <param name="isContainerPrepared">
        /// <c>true</c> if the container is ready for use; otherwise, <c>false</c>.
        /// </param>
        void IsContainerPrepared(ChoosingItemContainerEventArgs e, bool isContainerPrepared);

        /// <summary>
        /// Gets the data item associated with this <see cref="ChoosingItemContainerEventArgs.ItemContainer"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <returns>
        /// The data item associated with this <see cref="ChoosingItemContainerEventArgs.ItemContainer"/>.
        /// </returns>
        object Item(ChoosingItemContainerEventArgs e);

        /// <summary>
        /// Gets the UI container that will be used to display the current data item.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <returns>The UI container that will be used to display the current data item.</returns>
        SelectorItem ItemContainer(ChoosingItemContainerEventArgs e);

        /// <summary>
        /// Sets the UI container that will be used to display the current data item.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <param name="itemContainer">
        /// The UI container that will be used to display the current data item.
        /// </param>
        void ItemContainer(ChoosingItemContainerEventArgs e, SelectorItem itemContainer);

        /// <summary>
        /// Gets the index in the <see cref="ItemsControl.ItemsSource"/> of the data item
        /// for which a container is being selected.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingItemContainerEventArgs"/>.</param>
        /// <returns>
        /// The index in the <see cref="ItemsControl.ItemsSource"/> of the data item
        /// for which a container is being selected.
        /// </returns>
        int ItemIndex(ChoosingItemContainerEventArgs e);
    }
}
