// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SearchBoxResultSuggestionChosenEventArgs"/>
    /// resolved by <see cref="ISearchBoxResultSuggestionChosenEventArgsResolver"/>.
    /// </summary>
    public static class SearchBoxResultSuggestionChosenEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISearchBoxResultSuggestionChosenEventArgsResolver"/>
        /// that resolves data of the <see cref="SearchBoxResultSuggestionChosenEventArgs"/>.
        /// </summary>
        public static ISearchBoxResultSuggestionChosenEventArgsResolver Resolver { get; set; } = new DefaultSearchBoxResultSuggestionChosenEventArgsResolver();

        /// <summary>
        /// Gets any modifier keys that are pressed when the user presses enter to pick a search result.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxResultSuggestionChosenEventArgs"/>.</param>
        /// <returns>Any modifier keys that are pressed when the user presses enter to pick a search result.</returns>
        public static VirtualKeyModifiers KeyModifiers(this SearchBoxResultSuggestionChosenEventArgs e) => Resolver.KeyModifiers(e);

        /// <summary>
        /// The app- defined tag for the suggested result that the user selected.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxResultSuggestionChosenEventArgs"/>.</param>
        /// <returns>The app-defined tag for the selected search result.</returns>
        public static string Tag(this SearchBoxResultSuggestionChosenEventArgs e) => Resolver.Tag(e);

        private sealed class DefaultSearchBoxResultSuggestionChosenEventArgsResolver : ISearchBoxResultSuggestionChosenEventArgsResolver
        {
            VirtualKeyModifiers ISearchBoxResultSuggestionChosenEventArgsResolver.KeyModifiers(SearchBoxResultSuggestionChosenEventArgs e) => e.KeyModifiers;
            string ISearchBoxResultSuggestionChosenEventArgsResolver.Tag(SearchBoxResultSuggestionChosenEventArgs e) => e.Tag;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SearchBoxResultSuggestionChosenEventArgs"/>.
    /// </summary>
    public interface ISearchBoxResultSuggestionChosenEventArgsResolver
    {
        /// <summary>
        /// Gets any modifier keys that are pressed when the user presses enter to pick a search result.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxResultSuggestionChosenEventArgs"/>.</param>
        /// <returns>Any modifier keys that are pressed when the user presses enter to pick a search result.</returns>
        VirtualKeyModifiers KeyModifiers(SearchBoxResultSuggestionChosenEventArgs e);

        /// <summary>
        /// The app- defined tag for the suggested result that the user selected.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxResultSuggestionChosenEventArgs"/>.</param>
        /// <returns>The app-defined tag for the selected search result.</returns>
        string Tag(SearchBoxResultSuggestionChosenEventArgs e);
    }
}
