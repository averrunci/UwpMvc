// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="AccessKeyDisplayRequestedEventArgs"/>
    /// resolved by <see cref="IAccessKeyDisplayRequestedEventArgsResolver"/>.
    /// </summary>
    public static class AccessKeyDisplayRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IAccessKeyDisplayRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="AccessKeyDisplayRequestedEventArgs"/>.
        /// </summary>
        public static IAccessKeyDisplayRequestedEventArgsResolver Resolver { get; set; } = new DefaultAccessKeyDisplayRequestedEventArgsResolver();

        /// <summary>
        /// Gets the keys that were pressed to start the access key sequence.
        /// </summary>
        /// <param name="e">The requested <see cref="AccessKeyDisplayRequestedEventArgs"/>.</param>
        /// <returns>The keys that were pressed to start the access key sequence.</returns>
        public static string PressedKeys(this AccessKeyDisplayRequestedEventArgs e) => Resolver.PressedKeys(e);

        private sealed class DefaultAccessKeyDisplayRequestedEventArgsResolver : IAccessKeyDisplayRequestedEventArgsResolver
        {
            string IAccessKeyDisplayRequestedEventArgsResolver.PressedKeys(AccessKeyDisplayRequestedEventArgs e) => e.PressedKeys;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="AccessKeyDisplayRequestedEventArgs"/>.
    /// </summary>
    public interface IAccessKeyDisplayRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets the keys that were pressed to start the access key sequence.
        /// </summary>
        /// <param name="e">The requested <see cref="AccessKeyDisplayRequestedEventArgs"/>.</param>
        /// <returns>The keys that were pressed to start the access key sequence.</returns>
        string PressedKeys(AccessKeyDisplayRequestedEventArgs e);
    }
}
