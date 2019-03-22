// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="AutoSuggestBoxTextChangedEventArgs"/>
    /// resolved by <see cref="IAutoSuggestBoxTextChangedEventArgsResolver"/>.
    /// </summary>
    public static class AutoSuggestBoxTextChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IAutoSuggestBoxTextChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="AutoSuggestBoxTextChangedEventArgs"/>.
        /// </summary>
        public static IAutoSuggestBoxTextChangedEventArgsResolver Resolver { get; set; } = new DefaultAutoSuggestBoxTextChangedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates the reason for the text changing in the AutoSuggestBox.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <returns>The reason for the text changing in the AutoSuggestBox.</returns>
        public static AutoSuggestionBoxTextChangeReason Reason(this AutoSuggestBoxTextChangedEventArgs e) => Resolver.Reason(e);

        /// <summary>
        /// Sets a value that indicates the reason for the text changing in the AutoSuggestBox.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <param name="reason">The reason for the text changing in the AutoSuggestBox.</param>
        public static void Reason(this AutoSuggestBoxTextChangedEventArgs e, AutoSuggestionBoxTextChangeReason reason) => Resolver.Reason(e, reason);

        /// <summary>
        /// Returns a Boolean value indicating if the current value of the TextBox is unchanged from the point in time when the TextChanged event was raised.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <returns>Indicates if the current value of the TextBox is unchanged from the point in time when the TextChanged event was raised.</returns>
        public static bool CheckCurrentWrapped(this AutoSuggestBoxTextChangedEventArgs e) => Resolver.CheckCurrent(e);

        private sealed class DefaultAutoSuggestBoxTextChangedEventArgsResolver : IAutoSuggestBoxTextChangedEventArgsResolver
        {
            AutoSuggestionBoxTextChangeReason IAutoSuggestBoxTextChangedEventArgsResolver.Reason(AutoSuggestBoxTextChangedEventArgs e) => e.Reason;
            void IAutoSuggestBoxTextChangedEventArgsResolver.Reason(AutoSuggestBoxTextChangedEventArgs e, AutoSuggestionBoxTextChangeReason reason) => e.Reason = reason;
            bool IAutoSuggestBoxTextChangedEventArgsResolver.CheckCurrent(AutoSuggestBoxTextChangedEventArgs e) => e.CheckCurrent();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="AutoSuggestBoxTextChangedEventArgs"/>.
    /// </summary>
    public interface IAutoSuggestBoxTextChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates the reason for the text changing in the AutoSuggestBox.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <returns>The reason for the text changing in the AutoSuggestBox.</returns>
        AutoSuggestionBoxTextChangeReason Reason(AutoSuggestBoxTextChangedEventArgs e);

        /// <summary>
        /// Sets a value that indicates the reason for the text changing in the AutoSuggestBox.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <param name="reason">The reason for the text changing in the AutoSuggestBox.</param>
        void Reason(AutoSuggestBoxTextChangedEventArgs e, AutoSuggestionBoxTextChangeReason reason);

        /// <summary>
        /// Returns a Boolean value indicating if the current value of the TextBox is unchanged from the point in time when the TextChanged event was raised.
        /// </summary>
        /// <param name="e">The requested <see cref="AutoSuggestBoxTextChangedEventArgs"/>.</param>
        /// <returns>Indicates if the current value of the TextBox is unchanged from the point in time when the TextChanged event was raised.</returns>
        bool CheckCurrent(AutoSuggestBoxTextChangedEventArgs e);
    }
}
