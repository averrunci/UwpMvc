// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="TextBoxBeforeTextChangingEventArgs"/>
    /// resolved by <see cref="ITextBoxBeforeTextChangingEventArgsResolver"/>.
    /// </summary>
    public static class TextBoxBeforeTextChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITextBoxBeforeTextChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="TextBoxBeforeTextChangingEventArgs"/>.
        /// </summary>
        public static ITextBoxBeforeTextChangingEventArgsResolver Resolver { get; set; } = new DefaultTextBoxBeforeTextChangingEventArgsResolver();

        /// <summary>
        /// Gets the new text that is entered into the text box.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxBeforeTextChangingEventArgs"/>.</param>
        /// <returns>The new text value that is entered into the text box.</returns>
        public static string NewText(this TextBoxBeforeTextChangingEventArgs e) => Resolver.NewText(e);

        /// <summary>
        /// Gets a value that indicates whether to cancel the text changes.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxBeforeTextChangingEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the text changes; otherwise, <c>false</c>. The default is <c>false</c>.</returns>
        public static bool Cancel(this TextBoxBeforeTextChangingEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets a value that indicates whether to cancel the text changes.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxBeforeTextChangingEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the text changes; otherwise, <c>false</c>. The default is <c>false</c>.</param>
        public static void Cancel(this TextBoxBeforeTextChangingEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        private sealed class DefaultTextBoxBeforeTextChangingEventArgsResolver : ITextBoxBeforeTextChangingEventArgsResolver
        {
            string ITextBoxBeforeTextChangingEventArgsResolver.NewText(TextBoxBeforeTextChangingEventArgs e) => e.NewText;
            bool ITextBoxBeforeTextChangingEventArgsResolver.Cancel(TextBoxBeforeTextChangingEventArgs e) => e.Cancel;
            void ITextBoxBeforeTextChangingEventArgsResolver.Cancel(TextBoxBeforeTextChangingEventArgs e, bool cancel) => e.Cancel = cancel;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TextBoxBeforeTextChangingEventArgs"/>.
    /// </summary>
    public interface ITextBoxBeforeTextChangingEventArgsResolver
    {
        /// <summary>
        /// Gets the new text that is entered into the text box.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxBeforeTextChangingEventArgs"/>.</param>
        /// <returns>The new text value that is entered into the text box.</returns>
        string NewText(TextBoxBeforeTextChangingEventArgs e);

        /// <summary>
        /// Gets a value that indicates whether to cancel the text changes.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxBeforeTextChangingEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the text changes; otherwise, <c>false</c>. The default is <c>false</c>.</returns>
        bool Cancel(TextBoxBeforeTextChangingEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether to cancel the text changes.
        /// </summary>
        /// <param name="e">The requested <see cref="TextBoxBeforeTextChangingEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> to cancel the text changes; otherwise, <c>false</c>. The default is <c>false</c>.</param>
        void Cancel(TextBoxBeforeTextChangingEventArgs e, bool cancel);
    }
}
