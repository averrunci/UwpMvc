// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SelectionChangedEventArgs"/>
    /// resolved by <see cref="ISelectionChangedEventArgsResolver"/>.
    /// </summary>
    public static class SelectionChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISelectionChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="SelectionChangedEventArgs"/>.
        /// </summary>
        public static ISelectionChangedEventArgsResolver Resolver { get; set; } = new DefaultSelectionChangedEventArgsResolver();

        /// <summary>
        /// Gets a list that contains the items that were selected.
        /// </summary>
        /// <param name="e">The requested <see cref="SelectionChangedEventArgs"/>.</param>
        /// <returns>The loosely typed collection of items that were selected in this event.</returns>
        public static IList<object> AddedItems(this SelectionChangedEventArgs e) => Resolver.AddedItems(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="SelectionChangedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this SelectionChangedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets a list that contains the items that were unselected.
        /// </summary>
        /// <param name="e">The requested <see cref="SelectionChangedEventArgs"/>.</param>
        /// <returns>The loosely typed list of items that were unselected in this event.</returns>
        public static IList<object> RemovedItems(this SelectionChangedEventArgs e) => Resolver.RemovedItems(e);

        private sealed class DefaultSelectionChangedEventArgsResolver : ISelectionChangedEventArgsResolver
        {
            IList<object> ISelectionChangedEventArgsResolver.AddedItems(SelectionChangedEventArgs e) => e.AddedItems;
            object ISelectionChangedEventArgsResolver.OriginalSource(SelectionChangedEventArgs e) => e.OriginalSource;
            IList<object> ISelectionChangedEventArgsResolver.RemovedItems(SelectionChangedEventArgs e) => e.RemovedItems;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SelectionChangedEventArgs"/>.
    /// </summary>
    public interface ISelectionChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a list that contains the items that were selected.
        /// </summary>
        /// <param name="e">The requested <see cref="SelectionChangedEventArgs"/>.</param>
        /// <returns>The loosely typed collection of items that were selected in this event.</returns>
        IList<object> AddedItems(SelectionChangedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="SelectionChangedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(SelectionChangedEventArgs e);

        /// <summary>
        /// Gets a list that contains the items that were unselected.
        /// </summary>
        /// <param name="e">The requested <see cref="SelectionChangedEventArgs"/>.</param>
        /// <returns>The loosely typed list of items that were unselected in this event.</returns>
        IList<object> RemovedItems(SelectionChangedEventArgs e);
    }
}
