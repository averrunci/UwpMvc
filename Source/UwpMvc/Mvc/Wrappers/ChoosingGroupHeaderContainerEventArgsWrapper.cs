// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ChoosingGroupHeaderContainerEventArgs"/>
    /// resolved by <see cref="IChoosingGroupHeaderContainerEventArgsResolver"/>.
    /// </summary>
    public static class ChoosingGroupHeaderContainerEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IChoosingGroupHeaderContainerEventArgsResolver"/>
        /// that resolves data of the <see cref="ChoosingGroupHeaderContainerEventArgs"/>.
        /// </summary>
        public static IChoosingGroupHeaderContainerEventArgsResolver Resolver { get; set; } = new DefaultChoosingGroupHeaderContainerEventArgsResolver();

        /// <summary>
        /// Gets the data group associated with this <see cref="ChoosingGroupHeaderContainerEventArgs.GroupHeaderContainer"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingGroupHeaderContainerEventArgs"/>.</param>
        /// <returns>The data group associated with this <see cref="ChoosingGroupHeaderContainerEventArgs.GroupHeaderContainer"/>.</returns>
        public static object Group(this ChoosingGroupHeaderContainerEventArgs e) => Resolver.Group(e);

        /// <summary>
        /// Gets the UI container that will be used to display the current data group.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingGroupHeaderContainerEventArgs"/>.</param>
        /// <returns>The UI container that will be used to display the current data group.</returns>
        public static ListViewBaseHeaderItem GroupHeaderContainer(this ChoosingGroupHeaderContainerEventArgs e) => Resolver.GroupHeaderContainer(e);

        /// <summary>
        /// Sets the UI container that will be used to display the current data group.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingGroupHeaderContainerEventArgs"/>.</param>
        /// <param name="groupHeaderContainer">The UI container that will be used to display the current data group.</param>
        public static void GroupHeaderContainer(this ChoosingGroupHeaderContainerEventArgs e, ListViewBaseHeaderItem groupHeaderContainer) => Resolver.GroupHeaderContainer(e, groupHeaderContainer);

        /// <summary>
        /// Gets the index in the <see cref="ItemsControl.ItemsSource"/> of the data group for which a container is being selected.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingGroupHeaderContainerEventArgs"/>.</param>
        /// <returns>
        /// The index in the <see cref="ItemsControl.ItemsSource"/> of the data group for which a container is being selected.
        /// </returns>
        public static int GroupIndex(this ChoosingGroupHeaderContainerEventArgs e) => Resolver.GroupIndex(e);

        private sealed class DefaultChoosingGroupHeaderContainerEventArgsResolver : IChoosingGroupHeaderContainerEventArgsResolver
        {
            object IChoosingGroupHeaderContainerEventArgsResolver.Group(ChoosingGroupHeaderContainerEventArgs e) => e.Group;
            ListViewBaseHeaderItem IChoosingGroupHeaderContainerEventArgsResolver.GroupHeaderContainer(ChoosingGroupHeaderContainerEventArgs e) => e.GroupHeaderContainer;
            void IChoosingGroupHeaderContainerEventArgsResolver.GroupHeaderContainer(ChoosingGroupHeaderContainerEventArgs e, ListViewBaseHeaderItem groupHeaderContainer) => e.GroupHeaderContainer = groupHeaderContainer;
            int IChoosingGroupHeaderContainerEventArgsResolver.GroupIndex(ChoosingGroupHeaderContainerEventArgs e) => e.GroupIndex;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ChoosingGroupHeaderContainerEventArgs"/>.
    /// </summary>
    public interface IChoosingGroupHeaderContainerEventArgsResolver
    {
        /// <summary>
        /// Gets the data group associated with this <see cref="ChoosingGroupHeaderContainerEventArgs.GroupHeaderContainer"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingGroupHeaderContainerEventArgs"/>.</param>
        /// <returns>The data group associated with this <see cref="ChoosingGroupHeaderContainerEventArgs.GroupHeaderContainer"/>.</returns>
        object Group(ChoosingGroupHeaderContainerEventArgs e);

        /// <summary>
        /// Gets the UI container that will be used to display the current data group.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingGroupHeaderContainerEventArgs"/>.</param>
        /// <returns>The UI container that will be used to display the current data group.</returns>
        ListViewBaseHeaderItem GroupHeaderContainer(ChoosingGroupHeaderContainerEventArgs e);

        /// <summary>
        /// Sets the UI container that will be used to display the current data group.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingGroupHeaderContainerEventArgs"/>.</param>
        /// <param name="groupHeaderContainer">The UI container that will be used to display the current data group.</param>
        void GroupHeaderContainer(ChoosingGroupHeaderContainerEventArgs e, ListViewBaseHeaderItem groupHeaderContainer);

        /// <summary>
        /// Gets the index in the <see cref="ItemsControl.ItemsSource"/> of the data group for which a container is being selected.
        /// </summary>
        /// <param name="e">The requested <see cref="ChoosingGroupHeaderContainerEventArgs"/>.</param>
        /// <returns>
        /// The index in the <see cref="ItemsControl.ItemsSource"/> of the data group for which a container is being selected.
        /// </returns>
        int GroupIndex(ChoosingGroupHeaderContainerEventArgs e);
    }
}
