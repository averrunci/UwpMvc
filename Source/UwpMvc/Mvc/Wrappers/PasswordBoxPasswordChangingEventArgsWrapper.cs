// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="PasswordBoxPasswordChangingEventArgs"/>
    /// resolved by <see cref="IPasswordBoxPasswordChangingEventArgsResolver"/>.
    /// </summary>
    public static class PasswordBoxPasswordChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IPasswordBoxPasswordChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="PasswordBoxPasswordChangingEventArgs"/>.
        /// </summary>
        public static IPasswordBoxPasswordChangingEventArgsResolver Resolver { get; set; } = new DefaultPasswordBoxPasswordChangingEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the event occured due to a change in the text content.
        /// </summary>
        /// <param name="e">The requested <see cref="PasswordBoxPasswordChangingEventArgs"/>.</param>
        /// <returns><c>true</c> if a change to the text content caused the event; otherwise, <c>false</c>.</returns>
        public static bool IsContentChanging(this PasswordBoxPasswordChangingEventArgs e) => Resolver.IsContentChanging(e);

        private sealed class DefaultPasswordBoxPasswordChangingEventArgsResolver : IPasswordBoxPasswordChangingEventArgsResolver
        {
            bool IPasswordBoxPasswordChangingEventArgsResolver.IsContentChanging(PasswordBoxPasswordChangingEventArgs e) => e.IsContentChanging;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="PasswordBoxPasswordChangingEventArgs"/>.
    /// </summary>
    public interface IPasswordBoxPasswordChangingEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the event occured due to a change in the text content.
        /// </summary>
        /// <param name="e">The requested <see cref="PasswordBoxPasswordChangingEventArgs"/>.</param>
        /// <returns><c>true</c> if a change to the text content caused the event; otherwise, <c>false</c>.</returns>
        bool IsContentChanging(PasswordBoxPasswordChangingEventArgs e);
    }
}
