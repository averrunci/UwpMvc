// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TextBoxSelectionChangingEventArgs"/>
    /// resolved by <see cref="ITextBoxSelectionChangingEventArgsResolver"/>.
    /// </summary>
    public static class TextBoxSelectionChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITextBoxSelectionChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="TextBoxSelectionChangingEventArgs"/>.
        /// </summary>
        public static ITextBoxSelectionChangingEventArgsResolver Resolver { get; set; } = new DefaultTextBoxSelectionChangingEventArgsResolver();

        /// <summary>
        /// Gets the starting index of the text selection.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxSelectionChangingEventArgs"/>.</param>
        /// <returns>The starting index of the text selection.</returns>
        public static int SelectionStart(this TextBoxSelectionChangingEventArgs e) => Resolver.SelectionStart(e);

        /// <summary>
        /// Gets the length of the text selection.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxSelectionChangingEventArgs"/>.</param>
        /// <returns>The length of the text selection.</returns>
        public static int SelectionLength(this TextBoxSelectionChangingEventArgs e) => Resolver.SelectionLength(e);

        /// <summary>
        /// Gets a value that indicates whether the selection operation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxSelectionChangingEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the selection operation; otherwise, <c>false</c>. The default is <c>false</c>.</returns>
        public static bool Cancel(this TextBoxSelectionChangingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that indicates whether the selection operation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxSelectionChangingEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the selection operation; otherwise, <c>false</c>. The default is <c>false</c>.</param>
        public static void Cancel(this TextBoxSelectionChangingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        private sealed class DefaultTextBoxSelectionChangingEventArgsResolver : ITextBoxSelectionChangingEventArgsResolver
        {
            int ITextBoxSelectionChangingEventArgsResolver.SelectionStart(TextBoxSelectionChangingEventArgs e) => e.SelectionStart;
            int ITextBoxSelectionChangingEventArgsResolver.SelectionLength(TextBoxSelectionChangingEventArgs e) => e.SelectionLength;
            bool ITextBoxSelectionChangingEventArgsResolver.Cancel(TextBoxSelectionChangingEventArgs e) => e.Cancel;
            void ITextBoxSelectionChangingEventArgsResolver.Cancel(TextBoxSelectionChangingEventArgs e, bool cancel) => e.Cancel = cancel;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TextBoxSelectionChangingEventArgs"/>.
    /// </summary>
    public interface ITextBoxSelectionChangingEventArgsResolver
    {
        /// <summary>
        /// Gets the starting index of the text selection.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxSelectionChangingEventArgs"/>.</param>
        /// <returns>The starting index of the text selection.</returns>
        int SelectionStart(TextBoxSelectionChangingEventArgs e);

        /// <summary>
        /// Gets the length of the text selection.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxSelectionChangingEventArgs"/>.</param>
        /// <returns>The length of the text selection.</returns>
        int SelectionLength(TextBoxSelectionChangingEventArgs e);

        /// <summary>
        /// Gets a value that indicates whether the selection operation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxSelectionChangingEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the selection operation; otherwise, <c>false</c>. The default is <c>false</c>.</returns>
        bool Cancel(TextBoxSelectionChangingEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the selection operation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxSelectionChangingEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the selection operation; otherwise, <c>false</c>. The default is <c>false</c>.</param>
        void Cancel(TextBoxSelectionChangingEventArgs e, bool cancel);
    }
}
