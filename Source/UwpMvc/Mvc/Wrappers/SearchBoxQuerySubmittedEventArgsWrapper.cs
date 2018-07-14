// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.Search;
using Windows.System;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SearchBoxQuerySubmittedEventArgs"/>
    /// resolved by <see cref="ISearchBoxQuerySubmittedEventArgsResolver"/>.
    /// </summary>
    public static class SearchBoxQuerySubmittedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISearchBoxQuerySubmittedEventArgsResolver"/>
        /// that resolves data of the <see cref="SearchBoxQuerySubmittedEventArgs"/>.
        /// </summary>
        public static ISearchBoxQuerySubmittedEventArgsResolver Resolver { get; set; } = new DefaultSearchBoxQuerySubmittedEventArgsResolver();

        /// <summary>
        /// Gets any modifier keys that are pressed when the user presses enter to submit a query.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>Any modifier keys that are pressed when the user presses enter to submit a query.</returns>
        public static VirtualKeyModifiers KeyModifiers(this SearchBoxQuerySubmittedEventArgs e) => Resolver.KeyModifiers(e);

        /// <summary>
        /// Gets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language
        /// currently associated with the user's text input device.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>The IETF BCP 47 standard language tag.</returns>
        public static string Language(this SearchBoxQuerySubmittedEventArgs e) => Resolver.Language(e);

        /// <summary>
        /// Gets information about query text that the user enters through an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>Linguistic information about query text that the user enters through an Input Method Editor (IME).</returns>
        public static SearchQueryLinguisticDetails LinguisticDetails(this SearchBoxQuerySubmittedEventArgs e) => Resolver.LinguisticDetails(e);

        /// <summary>
        /// Gets the query text of the current search.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQueryChangedEventArgs"/>.</param>
        /// <returns>The query text of the current search.</returns>
        public static string QueryText(this SearchBoxQuerySubmittedEventArgs e) => Resolver.QueryText(e);

        private sealed class DefaultSearchBoxQuerySubmittedEventArgsResolver : ISearchBoxQuerySubmittedEventArgsResolver
        {
            VirtualKeyModifiers ISearchBoxQuerySubmittedEventArgsResolver.KeyModifiers(SearchBoxQuerySubmittedEventArgs e) => e.KeyModifiers;
            string ISearchBoxQuerySubmittedEventArgsResolver.Language(SearchBoxQuerySubmittedEventArgs e) => e.Language;
            SearchQueryLinguisticDetails ISearchBoxQuerySubmittedEventArgsResolver.LinguisticDetails(SearchBoxQuerySubmittedEventArgs e) => e.LinguisticDetails;
            string ISearchBoxQuerySubmittedEventArgsResolver.QueryText(SearchBoxQuerySubmittedEventArgs e) => e.QueryText;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SearchBoxQuerySubmittedEventArgs"/>.
    /// </summary>
    public interface ISearchBoxQuerySubmittedEventArgsResolver
    {
        /// <summary>
        /// Gets any modifier keys that are pressed when the user presses enter to submit a query.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>Any modifier keys that are pressed when the user presses enter to submit a query.</returns>
        VirtualKeyModifiers KeyModifiers(SearchBoxQuerySubmittedEventArgs e);

        /// <summary>
        /// Gets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language
        /// currently associated with the user's text input device.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>The IETF BCP 47 standard language tag.</returns>
        string Language(SearchBoxQuerySubmittedEventArgs e);

        /// <summary>
        /// Gets information about query text that the user enters through an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>Linguistic information about query text that the user enters through an Input Method Editor (IME).</returns>
        SearchQueryLinguisticDetails LinguisticDetails(SearchBoxQuerySubmittedEventArgs e);

        /// <summary>
        /// Gets the query text of the current search.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>The query text of the current search.</returns>
        string QueryText(SearchBoxQuerySubmittedEventArgs e);
    }
}
