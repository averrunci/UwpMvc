// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TextCompositionStartedEventArgs"/>
    /// resolved by <see cref="ITextCompositionStartedEventArgsResolver"/>.
    /// </summary>
    public static class TextCompositionStartedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITextCompositionStartedEventArgsResolver"/>
        /// that resolves data of the <see cref="TextCompositionStartedEventArgs"/>.
        /// </summary>
        public static ITextCompositionStartedEventArgsResolver Resolver { get; set; } = new DefaultTextCompositionStartedEventArgsResolver();

        /// <summary>
        /// Gets the length of the portion of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionStartedEventArgs"/>.</param>
        /// <returns>The length of the protion of the text that the user is composing with an IME.</returns>
        public static int Length(this TextCompositionStartedEventArgs e) => Resolver.Length(e);

        /// <summary>
        /// Gets the starting location of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionStartedEventArgs"/>.</param>
        /// <returns>The starting location of the text that the user is composing with an IME.</returns>
        public static int StartIndex(this TextCompositionStartedEventArgs e) => Resolver.StartIndex(e);

        private sealed class DefaultTextCompositionStartedEventArgsResolver : ITextCompositionStartedEventArgsResolver
        {
            int ITextCompositionStartedEventArgsResolver.Length(TextCompositionStartedEventArgs e) => e.Length;
            int ITextCompositionStartedEventArgsResolver.StartIndex(TextCompositionStartedEventArgs e) => e.StartIndex;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TextCompositionStartedEventArgs"/>.
    /// </summary>
    public interface ITextCompositionStartedEventArgsResolver
    {
        /// <summary>
        /// Gets the length of the portion of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionStartedEventArgs"/>.</param>
        /// <returns>The length of the protion of the text that the user is composing with an IME.</returns>
        int Length(TextCompositionStartedEventArgs e);

        /// <summary>
        /// Gets the starting location of the text that the user is composing with an Input Method Editor (IME).
        /// </summary>
        /// <param name="e">The requested <see cref="TextCompositionStartedEventArgs"/>.</param>
        /// <returns>The starting location of the text that the user is composing with an IME.</returns>
        int StartIndex(TextCompositionStartedEventArgs e);
    }
}
