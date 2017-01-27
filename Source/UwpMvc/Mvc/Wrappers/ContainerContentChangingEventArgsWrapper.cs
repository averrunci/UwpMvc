// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ContainerContentChangingEventArgs"/>
    /// resolved by <see cref="IContainerContentChangingEventArgsResolver"/>.
    /// </summary>
    public static class ContainerContentChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IContainerContentChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="ContainerContentChangingEventArgs"/>.
        /// </summary>
        public static IContainerContentChangingEventArgsResolver Resolver { get; set; } = new DefaultContainerContentChangingEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this ContainerContentChangingEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this ContainerContentChangingEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a value that indicates whether this container is in the recycle queue of the
        /// <see cref="ListViewBase"/> and is not being used to visualize a data item.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the container is in the recycle queue of the <see cref="ListviewBase"/>; otherwise, <c>false</c>.
        /// </returns>
        public static bool InRecycleQueue(this ContainerContentChangingEventArgs e) => Resolver.InRecycleQueue(e);

        /// <summary>
        /// Gets the data item associated with this container.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>
        /// The data item associated with this container, or <c>null</c> if no data is associated with this container.
        /// </returns>
        public static object Item(this ContainerContentChangingEventArgs e) => Resolver.Item(e);

        /// <summary>
        /// Gets the UI container used to display the current data item.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>The UI container used to display the current data item.</returns>
        public static SelectorItem ItemContainer(this ContainerContentChangingEventArgs e) => Resolver.ItemContainer(e);

        /// <summary>
        /// Gets the index in the <see cref="ItemsControl.ItemsSource"/> of the data item
        /// associated with this container.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>
        /// The index in the <see cref="ItemsControl.ItemsSource"/> of the data item
        /// associated with this container.
        /// </returns>
        public static int ItemIndex(this ContainerContentChangingEventArgs e) => Resolver.ItemIndex(e);

        /// <summary>
        /// Gets the number of times this container and data item pair has been called.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>The number of times this container and data item pair has been called.</returns>
        public static uint Phase(this ContainerContentChangingEventArgs e) => Resolver.Phase(e);

        /// <summary>
        /// Registers the event handler to be called again during the next phase.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <param name="callback">The event handler function.</param>
        public static void RegisterUpdateCallback(this ContainerContentChangingEventArgs e, TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback) => Resolver.RegisterUpdateCallback(e, callback);

        /// <summary>
        /// Registers the event handler to be called again during the specified phase.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <param name="callbackPhase">The phase during which the callback should occur.</param>
        /// <param name="callback">The event handler function.</param>
        public static void RegisterUpdateCallback(this ContainerContentChangingEventArgs e, uint callbackPhase, TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback) => Resolver.RegisterUpdateCallback(e, callbackPhase, callback);

        private sealed class DefaultContainerContentChangingEventArgsResolver : IContainerContentChangingEventArgsResolver
        {
            bool IContainerContentChangingEventArgsResolver.Handled(ContainerContentChangingEventArgs e) => e.Handled;
            void IContainerContentChangingEventArgsResolver.Handled(ContainerContentChangingEventArgs e, bool handled) => e.Handled = handled;
            bool IContainerContentChangingEventArgsResolver.InRecycleQueue(ContainerContentChangingEventArgs e) => e.InRecycleQueue;
            object IContainerContentChangingEventArgsResolver.Item(ContainerContentChangingEventArgs e) => e.Item;
            SelectorItem IContainerContentChangingEventArgsResolver.ItemContainer(ContainerContentChangingEventArgs e) => e.ItemContainer;
            int IContainerContentChangingEventArgsResolver.ItemIndex(ContainerContentChangingEventArgs e) => e.ItemIndex;
            uint IContainerContentChangingEventArgsResolver.Phase(ContainerContentChangingEventArgs e) => e.Phase;
            void IContainerContentChangingEventArgsResolver.RegisterUpdateCallback(ContainerContentChangingEventArgs e, TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback) => e.RegisterUpdateCallback(callback);
            void IContainerContentChangingEventArgsResolver.RegisterUpdateCallback(ContainerContentChangingEventArgs e, uint callbackPhase, TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback) => e.RegisterUpdateCallback(callbackPhase, callback);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ContainerContentChangingEventArgs"/>.
    /// </summary>
    public interface IContainerContentChangingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(ContainerContentChangingEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(ContainerContentChangingEventArgs e, bool handled);

        /// <summary>
        /// Gets a value that indicates whether this container is in the recycle queue of the
        /// <see cref="ListViewBase"/> and is not being used to visualize a data item.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the container is in the recycle queue of the <see cref="ListviewBase"/>; otherwise, <c>false</c>.
        /// </returns>
        bool InRecycleQueue(ContainerContentChangingEventArgs e);

        /// <summary>
        /// Gets the data item associated with this container.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>
        /// The data item associated with this container, or <c>null</c> if no data is associated with this container.
        /// </returns>
        object Item(ContainerContentChangingEventArgs e);

        /// <summary>
        /// Gets the UI container used to display the current data item.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>The UI container used to display the current data item.</returns>
        SelectorItem ItemContainer(ContainerContentChangingEventArgs e);

        /// <summary>
        /// Gets the index in the <see cref="ItemsControl.ItemsSource"/> of the data item
        /// associated with this container.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>
        /// The index in the <see cref="ItemsControl.ItemsSource"/> of the data item
        /// associated with this container.
        /// </returns>
        int ItemIndex(ContainerContentChangingEventArgs e);

        /// <summary>
        /// Gets the number of times this container and data item pair has been called.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <returns>The number of times this container and data item pair has been called.</returns>
        uint Phase(ContainerContentChangingEventArgs e);

        /// <summary>
        /// Registers the event handler to be called again during the next phase.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <param name="callback">The event handler function.</param>
        void RegisterUpdateCallback(ContainerContentChangingEventArgs e, TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);

        /// <summary>
        /// Registers the event handler to be called again during the specified phase.
        /// </summary>
        /// <param name="e">The requested <see cref="ContainerContentChangingEventArgs"/>.</param>
        /// <param name="callbackPhase">The phase during which the callback should occur.</param>
        /// <param name="callback">The event handler function.</param>
        void RegisterUpdateCallback(ContainerContentChangingEventArgs e, uint callbackPhase, TypedEventHandler<ListViewBase, ContainerContentChangingEventArgs> callback);
    }
}
