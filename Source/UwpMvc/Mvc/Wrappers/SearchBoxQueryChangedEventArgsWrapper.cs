// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.Search;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SearchBoxQueryChangedEventArgs"/>
    /// resolved by <see cref="ISearchBoxQueryChangedEventArgsResolver"/>.
    /// </summary>
    public static class SearchBoxQueryChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISearchBoxQueryChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="SearchBoxQueryChangedEventArgs"/>.
        /// </summary>
        public static ISearchBoxQueryChangedEventArgsResolver Resolver { get; set; } = new DefaultSearchBoxQueryChangedEventArgsResolver();

        /// <summary>
        /// Gets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language
        /// currently associated with the user's text input device.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQueryChangedEventArgs"/>.</param>
        /// <returns>The IETF BCP 47 standard language tag.</returns>
        public static string Language(this SearchBoxQueryChangedEventArgs e) => Resolver.Language(e);

        /// <summary>
        /// Gets information about query text that the user enters through an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQueryChangedEventArgs"/>.</param>
        /// <returns>Linguistic information about query text that the user enters through an Input Method Editor (IME).</returns>
        public static SearchQueryLinguisticDetails LinguisticDetails(this SearchBoxQueryChangedEventArgs e) => Resolver.LinguisticDetails(e);

        /// <summary>
        /// Gets the query text of the current search.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQueryChangedEventArgs"/>.</param>
        /// <returns>The query text of the current search.</returns>
        public static string QueryText(this SearchBoxQueryChangedEventArgs e) => Resolver.QueryText(e);

        private sealed class DefaultSearchBoxQueryChangedEventArgsResolver : ISearchBoxQueryChangedEventArgsResolver
        {
            string ISearchBoxQueryChangedEventArgsResolver.Language(SearchBoxQueryChangedEventArgs e) => e.Language;
            SearchQueryLinguisticDetails ISearchBoxQueryChangedEventArgsResolver.LinguisticDetails(SearchBoxQueryChangedEventArgs e) => e.LinguisticDetails;
            string ISearchBoxQueryChangedEventArgsResolver.QueryText(SearchBoxQueryChangedEventArgs e) => e.QueryText;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SearchBoxQueryChangedEventArgs"/>.
    /// </summary>
    public interface ISearchBoxQueryChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the Internet Engineering Task Force (IETF) language tag (BCP 47 standard) that identifies the language
        /// currently associated with the user's text input device.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQueryChangedEventArgs"/>.</param>
        /// <returns>The IETF BCP 47 standard language tag.</returns>
        string Language(SearchBoxQueryChangedEventArgs e);

        /// <summary>
        /// Gets information about query text that the user enters through an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQueryChangedEventArgs"/>.</param>
        /// <returns>Linguistic information about query text that the user enters through an Input Method Editor (IME).</returns>
        SearchQueryLinguisticDetails LinguisticDetails(SearchBoxQueryChangedEventArgs e);

        /// <summary>
        /// Gets the query text of the current search.
        /// </summary>
        /// <param name="e">The requested <see cref="SearchBoxQueryChangedEventArgs"/>.</param>
        /// <returns>The query text of the current search.</returns>
        string QueryText(SearchBoxQueryChangedEventArgs e);
    }
}
