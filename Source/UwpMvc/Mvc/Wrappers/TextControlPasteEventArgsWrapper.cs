// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TextControlPasteEventArgs"/>
    /// resolved by <see cref="ITextControlPasteEventArgsResolver"/>.
    /// </summary>
    public static class TextControlPasteEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITextControlPasteEventArgsResolver"/>
        /// that resolves data of the <see cref="TextControlPasteEventArgs"/>.
        /// </summary>
        public static ITextControlPasteEventArgsResolver Resolver { get; set; } = new DefaultTextControlPasteEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TextControlPasteEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(TextControlPasteEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TextControlPasteEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this TextControlPasteEventArgs e, bool handled) => Resolver.Handled(e, handled);

        private sealed class DefaultTextControlPasteEventArgsResolver : ITextControlPasteEventArgsResolver
        {
            bool ITextControlPasteEventArgsResolver.Handled(TextControlPasteEventArgs e) => e.Handled;
            void ITextControlPasteEventArgsResolver.Handled(TextControlPasteEventArgs e, bool handled) => e.Handled = handled;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TextControlPasteEventArgs"/>.
    /// </summary>
    public interface ITextControlPasteEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TextControlPasteEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(TextControlPasteEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TextControlPasteEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(TextControlPasteEventArgs e, bool handled);
    }
}
