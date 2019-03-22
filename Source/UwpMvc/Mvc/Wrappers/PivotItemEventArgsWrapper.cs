// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="PivotItemEventArgs"/>
    /// resolved by <see cref="IPivotItemEventArgsResolver"/>.
    /// </summary>
    public static class PivotItemEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IPivotItemEventArgsResolver"/>
        /// that resolves data of the <see cref="PivotItemEventArgs"/>.
        /// </summary>
        public static IPivotItemEventArgsResolver Resolver { get; set; } = new DefaultPivotItemEventArgsResolver();

        /// <summary>
        /// Gets the pivot item instance.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <returns>Returns PivotItem.</returns>
        public static PivotItem Item(this PivotItemEventArgs e) => Resolver.Item(e);

        /// <summary>
        /// Sets the pivot item instance.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <param name="item">Returns PivotItem.</param>
        public static void Item(this PivotItemEventArgs e, PivotItem item) => Resolver.Item(e, item);

        private sealed class DefaultPivotItemEventArgsResolver : IPivotItemEventArgsResolver
        {
            PivotItem IPivotItemEventArgsResolver.Item(PivotItemEventArgs e) => e.Item;
            void IPivotItemEventArgsResolver.Item(PivotItemEventArgs e, PivotItem item) => e.Item = item;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="PivotItemEventArgs"/>.
    /// </summary>
    public interface IPivotItemEventArgsResolver
    {
        /// <summary>
        /// Gets the pivot item instance.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <returns>Returns PivotItem.</returns>
        PivotItem Item(PivotItemEventArgs e);

        /// <summary>
        /// Sets the pivot item instance.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <param name="item">Returns PivotItem.</param>
        void Item(PivotItemEventArgs e, PivotItem item);
    }
}
