// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TextCompositionChangedEventArgs"/>
    /// resolved by <see cref="ITextCompositionChangedEventArgsResolver"/>.
    /// </summary>
    public static class TextCompositionChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITextCompositionChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="TextCompositionChangedEventArgs"/>.
        /// </summary>
        public static ITextCompositionChangedEventArgsResolver Resolver { get; set; } = new DefaultTextCompositionChangedEventArgsResolver();

        /// <summary>
        /// Gets the length of the portion of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionChangedEventArgs"/>.</param>
        /// <returns>The length of the protion of the text that the user is composing with an IME.</returns>
        public static int Length(this TextCompositionChangedEventArgs e) => Resolver.Length(e);

        /// <summary>
        /// Gets the starting location of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionChangedEventArgs"/>.</param>
        /// <returns>The starting location of the text that the user is composing with an IME.</returns>
        public static int StartIndex(this TextCompositionChangedEventArgs e) => Resolver.StartIndex(e);

        private sealed class DefaultTextCompositionChangedEventArgsResolver : ITextCompositionChangedEventArgsResolver
        {
            int ITextCompositionChangedEventArgsResolver.Length(TextCompositionChangedEventArgs e) => e.Length;
            int ITextCompositionChangedEventArgsResolver.StartIndex(TextCompositionChangedEventArgs e) => e.StartIndex;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TextCompositionChangedEventArgs"/>.
    /// </summary>
    public interface ITextCompositionChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the length of the portion of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionChangedEventArgs"/>.</param>
        /// <returns>The length of the protion of the text that the user is composing with an IME.</returns>
        int Length(TextCompositionChangedEventArgs e);

        /// <summary>
        /// Gets the starting location of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionChangedEventArgs"/>.</param>
        /// <returns>The starting location of the text that the user is composing with an IME.</returns>
        int StartIndex(TextCompositionChangedEventArgs e);
    }
}
