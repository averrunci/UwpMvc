// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.Search;
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SearchBoxSuggestionsRequestedEventArgs"/>
    /// resolved by <see cref="ISearchBoxSuggestionsRequestedEventArgsResolver"/>.
    /// </summary>
    public static class SearchBoxSuggestionsRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISearchBoxSuggestionsRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.
        /// </summary>
        public static ISearchBoxSuggestionsRequestedEventArgsResolver Resolver { get; set; } = new DefaultSearchBoxSuggestionsRequestedEventArgsResolver();

        /// <summary>
        /// Gets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language
        /// currently associated with the user's text input device.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.</param>
        /// <returns>The IETF BCP 47 standard language tag.</returns>
        public static string Language(this SearchBoxSuggestionsRequestedEventArgs e) => Resolver.Language(e);

        /// <summary>
        /// Gets information about query text that the user enters through an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.</param>
        /// <returns>Linguistic information about query text that the user enters through an Input Method Editor (IME).</returns>
        public static SearchQueryLinguisticDetails LinguisticDetails(this SearchBoxSuggestionsRequestedEventArgs e) => Resolver.LinguisticDetails(e);

        /// <summary>
        /// Gets the query text of the current search.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.</param>
        /// <returns>The query text of the current search.</returns>
        public static string QueryText(this SearchBoxSuggestionsRequestedEventArgs e) => Resolver.QueryText(e);

        /// <summary>
        /// Gets the object that stores the suggestions and information about this request.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.</param>
        /// <returns>The object that stores the suggestions and information about this request.</returns>
        public static SearchSuggestionsRequest Request(this SearchBoxSuggestionsRequestedEventArgs e) => Resolver.Request(e);

        private sealed class DefaultSearchBoxSuggestionsRequestedEventArgsResolver : ISearchBoxSuggestionsRequestedEventArgsResolver
        {
            string ISearchBoxSuggestionsRequestedEventArgsResolver.Language(SearchBoxSuggestionsRequestedEventArgs e) => e.Language;
            SearchQueryLinguisticDetails ISearchBoxSuggestionsRequestedEventArgsResolver.LinguisticDetails(SearchBoxSuggestionsRequestedEventArgs e) => e.LinguisticDetails;
            string ISearchBoxSuggestionsRequestedEventArgsResolver.QueryText(SearchBoxSuggestionsRequestedEventArgs e) => e.QueryText;
            SearchSuggestionsRequest ISearchBoxSuggestionsRequestedEventArgsResolver.Request(SearchBoxSuggestionsRequestedEventArgs e) => e.Request;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.
    /// </summary>
    public interface ISearchBoxSuggestionsRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language
        /// currently associated with the user's text input device.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.</param>
        /// <returns>The IETF BCP 47 standard language tag.</returns>
        string Language(SearchBoxSuggestionsRequestedEventArgs e);

        /// <summary>
        /// Gets information about query text that the user enters through an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.</param>
        /// <returns>Linguistic information about query text that the user enters through an Input Method Editor (IME).</returns>
        SearchQueryLinguisticDetails LinguisticDetails(SearchBoxSuggestionsRequestedEventArgs e);

        /// <summary>
        /// Gets the query text of the current search.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.</param>
        /// <returns>The query text of the current search.</returns>
        string QueryText(SearchBoxSuggestionsRequestedEventArgs e);

        /// <summary>
        /// Gets the object that stores the suggestions and information about this request.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxSuggestionsRequestedEventArgs"/>.</param>
        /// <returns>The object that stores the suggestions and information about this request.</returns>
        SearchSuggestionsRequest Request(SearchBoxSuggestionsRequestedEventArgs e);
    }
}
