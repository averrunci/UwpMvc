// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="AutoSuggestBoxSuggestionChosenEventArgs"/>
    /// resolved by <see cref="IAutoSuggestBoxSuggestionChosenEventArgsResolver"/>.
    /// </summary>
    public static class AutoSuggestBoxSuggestionChosenEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IAutoSuggestBoxSuggestionChosenEventArgsResolver"/>
        /// that resolves data of the <see cref="AutoSuggestBoxSuggestionChosenEventArgs"/>.
        /// </summary>
        public static IAutoSuggestBoxSuggestionChosenEventArgsResolver Resolver { get; set; } = new DefaultAutoSuggestBoxSuggestionChosenEventArgsResolver();

        /// <summary>
        /// Gets a reference to the selected item.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxSuggestionChosenEventArgs"/>.</param>
        /// <returns>A reference to the selected item.</returns>
        public static object SelectedItem(this AutoSuggestBoxSuggestionChosenEventArgs e) => Resolver.SelectedItem(e);

        private sealed class DefaultAutoSuggestBoxSuggestionChosenEventArgsResolver : IAutoSuggestBoxSuggestionChosenEventArgsResolver
        {
            object IAutoSuggestBoxSuggestionChosenEventArgsResolver.SelectedItem(AutoSuggestBoxSuggestionChosenEventArgs e) => e.SelectedItem;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="AutoSuggestBoxSuggestionChosenEventArgs"/>.
    /// </summary>
    public interface IAutoSuggestBoxSuggestionChosenEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the selected item.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxSuggestionChosenEventArgs"/>.</param>
        /// <returns>A reference to the selected item.</returns>
        object SelectedItem(AutoSuggestBoxSuggestionChosenEventArgs e);
    }
}
