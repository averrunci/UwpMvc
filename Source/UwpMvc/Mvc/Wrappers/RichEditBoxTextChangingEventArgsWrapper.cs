// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="RichEditBoxTextChangingEventArgs"/>
    /// resolved by <see cref="IRichEditBoxTextChangingEventArgsResolver"/>.
    /// </summary>
    public static class RichEditBoxTextChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IRichEditBoxTextChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="RichEditBoxTextChangingEventArgs"/>.
        /// </summary>
        public static IRichEditBoxTextChangingEventArgsResolver Resolver { get; set; } = new DefaultRichEditBoxTextChangingEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the event occurred due to a change in the text content.
        /// </summary>
        /// <param name="e">The requested <see cref="RichEditBoxTextChangingEventArgs"/>.</param>
        /// <returns><c>true</c> if a change to the text content caused the event; otherwise, <c>false</c>.</returns>
        public static bool IsContentChanging(this RichEditBoxTextChangingEventArgs e) => Resolver.IsContentChanging(e);

        private sealed class DefaultRichEditBoxTextChangingEventArgsResolver : IRichEditBoxTextChangingEventArgsResolver
        {
            bool IRichEditBoxTextChangingEventArgsResolver.IsContentChanging(RichEditBoxTextChangingEventArgs e) => e.IsContentChanging;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="RichEditBoxTextChangingEventArgs"/>.
    /// </summary>
    public interface IRichEditBoxTextChangingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the event occurred due to a change in the text content.
        /// </summary>
        /// <param name="e">The requested <see cref="RichEditBoxTextChangingEventArgs"/>.</param>
        /// <returns><c>true</c> if a change to the text content caused the event; otherwise, <c>false</c>.</returns>
        bool IsContentChanging(RichEditBoxTextChangingEventArgs e);
    }
}
