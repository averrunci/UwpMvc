// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ComboBoxTextSubmittedEventArgs"/>
    /// resolved by <see cref="IComboBoxTextSubmittedEventArgsResolver"/>.
    /// </summary>
    public static class ComboBoxTextSubmittedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IComboBoxTextSubmittedEventArgsResolver"/>
        /// that resolves data of the <see cref="ComboBoxTextSubmittedEventArgs"/>.
        /// </summary>
        public static IComboBoxTextSubmittedEventArgsResolver Resolver { get; set; } = new DefaultComboBoxTextSubmittedEventArgsResolver();

        /// <summary>
        /// Gets the custom text value entered by the user.
        /// </summary>
        /// <param name="e">The requested <see cref="ComboBoxTextSubmittedEventArgs"/>.</param>
        /// <returns>The custom text value entered by the user.</returns>
        public static string Text(this ComboBoxTextSubmittedEventArgs e) => Resolver.Text(e);

        /// <summary>
        /// Gets whether the TextSubmitted event was handled or not.
        /// If <c>true</c>, the framework will not automatically update the selected item of the ComboBox to the new value.
        /// </summary>
        /// <param name="e">The requested <see cref="ComboBoxTextSubmittedEventArgs"/>.</param>
        /// <returns><c>true</c> to mark the event as handled; otherwise, <c>false</c>.</returns>
        public static bool Handled(this ComboBoxTextSubmittedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets whether the TextSubmitted event was handled or not.
        /// If <c>true</c>, the framework will not automatically update the selected item of the ComboBox to the new value.
        /// </summary>
        /// <param name="e">The requested <see cref="ComboBoxTextSubmittedEventArgs"/>.</param>
        /// <param name="handled"><c>true</c> to mark the event as handled; otherwise, <c>false</c>.</param>
        public static void Handled(this ComboBoxTextSubmittedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        private sealed class DefaultComboBoxTextSubmittedEventArgsResolver : IComboBoxTextSubmittedEventArgsResolver
        {
            string IComboBoxTextSubmittedEventArgsResolver.Text(ComboBoxTextSubmittedEventArgs e) => e.Text;
            bool IComboBoxTextSubmittedEventArgsResolver.Handled(ComboBoxTextSubmittedEventArgs e) => e.Handled;
            void IComboBoxTextSubmittedEventArgsResolver.Handled(ComboBoxTextSubmittedEventArgs e, bool handled) => e.Handled = handled;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ComboBoxTextSubmittedEventArgs"/>.
    /// </summary>
    public interface IComboBoxTextSubmittedEventArgsResolver
    {
        /// <summary>
        /// Gets the custom text value entered by the user.
        /// </summary>
        /// <param name="e">The requested <see cref="ComboBoxTextSubmittedEventArgs"/>.</param>
        /// <returns>The custom text value entered by the user.</returns>
        string Text(ComboBoxTextSubmittedEventArgs e);

        /// <summary>
        /// Gets whether the TextSubmitted event was handled or not.
        /// If <c>true</c>, the framework will not automatically update the selected item of the ComboBox to the new value.
        /// </summary>
        /// <param name="e">The requested <see cref="ComboBoxTextSubmittedEventArgs"/>.</param>
        /// <returns><c>true</c> to mark the event as handled; otherwise, <c>false</c>.</returns>
        bool Handled(ComboBoxTextSubmittedEventArgs e);

        /// <summary>
        /// Sets whether the TextSubmitted event was handled or not.
        /// If <c>true</c>, the framework will not automatically update the selected item of the ComboBox to the new value.
        /// </summary>
        /// <param name="e">The requested <see cref="ComboBoxTextSubmittedEventArgs"/>.</param>
        /// <param name="handled"><c>true</c> to mark the event as handled; otherwise, <c>false</c>.</param>
        void Handled(ComboBoxTextSubmittedEventArgs e, bool handled);
    }
}
