// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TextControlCopyingToClipboardEventArgs"/>
    /// resolved by <see cref="ITextControlCopyingToClipboardEventArgsResolver"/>.
    /// </summary>
    public static class TextControlCopyingToClipboardEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITextControlCopyingToClipboardEventArgsResolver"/>
        /// that resolves data of the <see cref="TextControlCopyingToClipboardEventArgs"/>.
        /// </summary>
        public static ITextControlCopyingToClipboardEventArgsResolver Resolver { get; set; } = new DefaultTextControlCopyingToClipboardEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value for Handled prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TextControlCopyingToClipboardEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which causes the default copy action to be performed.
        /// The default is <c>false</c>.
        /// </returns>
        public static bool Handled(this TextControlCopyingToClipboardEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value for Handled prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TextControlCopyingToClipboardEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which causes the default copy action to be performed.
        /// The default is <c>false</c>.
        /// </param>
        public static void Handled(this TextControlCopyingToClipboardEventArgs e, bool handled) => Resolver.Handled(e, handled);

        private sealed class DefaultTextControlCopyingToClipboardEventArgsResolver : ITextControlCopyingToClipboardEventArgsResolver
        {
            bool ITextControlCopyingToClipboardEventArgsResolver.Handled(TextControlCopyingToClipboardEventArgs e) => e.Handled;
            void ITextControlCopyingToClipboardEventArgsResolver.Handled(TextControlCopyingToClipboardEventArgs e, bool handled) => e.Handled = handled;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TextControlCopyingToClipboardEventArgs"/>.
    /// </summary>
    public interface ITextControlCopyingToClipboardEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value for Handled prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TextControlCopyingToClipboardEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which causes the default copy action to be performed.
        /// The default is <c>false</c>.
        /// </returns>
        bool Handled(TextControlCopyingToClipboardEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value for Handled prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TextControlCopyingToClipboardEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which causes the default copy action to be performed.
        /// The default is <c>false</c>.
        /// </param>
        void Handled(TextControlCopyingToClipboardEventArgs e, bool handled);
    }
}
