// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DynamicOverflowItemsChangingEventArgs"/>
    /// resolved by <see cref="IDynamicOverflowItemsChangingEventArgsResolver"/>.
    /// </summary>
    public static class DynamicOverflowItemsChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDynamicOverflowItemsChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="DynamicOverflowItemsChangingEventArgs"/>.
        /// </summary>
        public static IDynamicOverflowItemsChangingEventArgsResolver Resolver { get; set; } = new DefaultDynamicOverflowItemsChangingEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether items were added to or removed from the <see cref="CommandBar"/> overflow menu.
        /// </summary>
        /// <param name="e">The requested <see cref="DynamicOverflowItemsChangingEventArgs"/>.</param>
        /// <returns>
        /// A value that indicates whether items were added to or removed from the <see cref="CommandBar"/> overflow action.
        /// </returns>
        public static CommandBarDynamicOverflowAction Action(this DynamicOverflowItemsChangingEventArgs e) => Resolver.Action(e);

        private sealed class DefaultDynamicOverflowItemsChangingEventArgsResolver : IDynamicOverflowItemsChangingEventArgsResolver
        {
            CommandBarDynamicOverflowAction IDynamicOverflowItemsChangingEventArgsResolver.Action(DynamicOverflowItemsChangingEventArgs e) => e.Action;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DynamicOverflowItemsChangingEventArgs"/>.
    /// </summary>
    public interface IDynamicOverflowItemsChangingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether items were added to or removed from the <see cref="CommandBar"/> overflow menu.
        /// </summary>
        /// <param name="e">The requested <see cref="DynamicOverflowItemsChangingEventArgs"/>.</param>
        /// <returns>
        /// A value that indicates whether items were added to or removed from the <see cref="CommandBar"/> overflow action.
        /// </returns>
        CommandBarDynamicOverflowAction Action(DynamicOverflowItemsChangingEventArgs e);
    }
}
