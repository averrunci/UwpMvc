// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ItemClickEventArgs"/>
    /// resolved by <see cref="IItemClickEventArgsResolver"/>.
    /// </summary>
    public static class ItemClickEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IItemClickEventArgsResolver"/>
        /// that resolves data of the <see cref="ItemClickEventArgs"/>.
        /// </summary>
        public static IItemClickEventArgsResolver Resolver { get; set; } = new DefaultItemClickEventArgsResolver();

        /// <summary>
        /// Gets a reference to the clicked item.
        /// </summary>
        /// <param name="e">The requested <see cref="ItemClickEventArgs"/>.</param>
        /// <returns>The clicked item.</returns>
        public static object ClickedItem(this ItemClickEventArgs e) => Resolver.ClickedItem(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ItemClickEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ItemClickEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultItemClickEventArgsResolver : IItemClickEventArgsResolver
        {
            object IItemClickEventArgsResolver.ClickedItem(ItemClickEventArgs e) => e.ClickedItem;
            object IItemClickEventArgsResolver.OriginalSource(ItemClickEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ItemClickEventArgs"/>.
    /// </summary>
    public interface IItemClickEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the clicked item.
        /// </summary>
        /// <param name="e">The requested <see cref="ItemClickEventArgs"/>.</param>
        /// <returns>The clicked item.</returns>
        object ClickedItem(ItemClickEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ItemClickEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ItemClickEventArgs e);
    }
}
