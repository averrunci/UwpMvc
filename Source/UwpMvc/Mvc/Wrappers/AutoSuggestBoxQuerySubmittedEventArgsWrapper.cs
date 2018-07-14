// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="AutoSuggestBoxQuerySubmittedEventArgs"/>
    /// resolved by <see cref="IAutoSuggestBoxQuerySubmittedEventArgsResolver"/>.
    /// </summary>
    public static class AutoSuggestBoxQuerySubmittedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IAutoSuggestBoxQuerySubmittedEventArgsResolver"/>
        /// that resolves data of the <see cref="AutoSuggestBoxQuerySubmittedEventArgs"/>.
        /// </summary>
        public static IAutoSuggestBoxQuerySubmittedEventArgsResolver Resolver { get; set; } = new DefaultAutoSuggestBoxQuerySubmittedEventArgsResolver();

        /// <summary>
        /// Gets the suggested result that the use chose.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>The suggested result that the use chose.</returns>
        public static object ChosenSuggestion(this AutoSuggestBoxQuerySubmittedEventArgs e) => Resolver.ChosenSuggestion(e);

        /// <summary>
        /// Gets the query text of the current search.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>The query text of the current search.</returns>
        public static string QueryText(this AutoSuggestBoxQuerySubmittedEventArgs e) => Resolver.QueryText(e);

        private sealed class DefaultAutoSuggestBoxQuerySubmittedEventArgsResolver : IAutoSuggestBoxQuerySubmittedEventArgsResolver
        {
            object IAutoSuggestBoxQuerySubmittedEventArgsResolver.ChosenSuggestion(AutoSuggestBoxQuerySubmittedEventArgs e) => e.ChosenSuggestion;
            string IAutoSuggestBoxQuerySubmittedEventArgsResolver.QueryText(AutoSuggestBoxQuerySubmittedEventArgs e) => e.QueryText;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="AutoSuggestBoxQuerySubmittedEventArgs"/>.
    /// </summary>
    public interface IAutoSuggestBoxQuerySubmittedEventArgsResolver
    {
        /// <summary>
        /// Gets the suggested result that the use chose.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>The suggested result that the use chose.</returns>
        object ChosenSuggestion(AutoSuggestBoxQuerySubmittedEventArgs e);

        /// <summary>
        /// Gets the query text of the current search.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxQuerySubmittedEventArgs"/>.</param>
        /// <returns>The query text of the current search.</returns>
        string QueryText(AutoSuggestBoxQuerySubmittedEventArgs e);
    }
}
