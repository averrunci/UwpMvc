// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TextCompositionEndedEventArgs"/>
    /// resolved by <see cref="ITextCompositionEndedEventArgsResolver"/>.
    /// </summary>
    public static class TextCompositionEndedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITextCompositionEndedEventArgsResolver"/>
        /// that resolves data of the <see cref="TextCompositionEndedEventArgs"/>.
        /// </summary>
        public static ITextCompositionEndedEventArgsResolver Resolver { get; set; } = new DefaultTextCompositionEndedEventArgsResolver();

        /// <summary>
        /// Gets the length of the portion of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionEndedEventArgs"/>.</param>
        /// <returns>The length of the portion of the text that the user is composing with an IME.</returns>
        public static int Length(this TextCompositionEndedEventArgs e) => Resolver.Length(e);

        /// <summary>
        /// Gets the starting location of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionEndedEventArgs"/>.</param>
        /// <returns>The starting location of the text that the user is composing with an IME.</returns>
        public static int StartIndex(this TextCompositionEndedEventArgs e) => Resolver.StartIndex(e);

        private sealed class DefaultTextCompositionEndedEventArgsResolver : ITextCompositionEndedEventArgsResolver
        {
            int ITextCompositionEndedEventArgsResolver.Length(TextCompositionEndedEventArgs e) => e.Length;
            int ITextCompositionEndedEventArgsResolver.StartIndex(TextCompositionEndedEventArgs e) => e.StartIndex;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TextCompositionEndedEventArgs"/>.
    /// </summary>
    public interface ITextCompositionEndedEventArgsResolver
    {
        /// <summary>
        /// Gets the length of the portion of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionEndedEventArgs"/>.</param>
        /// <returns>The length of the portion of the text that the user is composing with an IME.</returns>
        int Length(TextCompositionEndedEventArgs e);

        /// <summary>
        /// Gets the starting location of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionEndedEventArgs"/>.</param>
        /// <returns>The starting location of the text that the user is composing with an IME.</returns>
        int StartIndex(TextCompositionEndedEventArgs e);
    }
}
