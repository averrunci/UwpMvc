// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="BackClickEventArgs"/>
    /// resolved by <see cref="IBackClickEventArgsResolver"/>.
    /// </summary>
    public static class BackClickEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IBackClickEventArgsResolver"/>
        /// that resolves data of the <see cref="BackClickEventArgs"/>.
        /// </summary>
        public static IBackClickEventArgsResolver Resolver { get; set; } = new DefaultBackClickEventArgsResolver();

        /// <summary>
        /// Gets a value that can cancel the navigation. A <c>true</c> value for Handled cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="BackClickEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the navigation. <c>false</c> to use default behavior. The default is <c>false</c>.</returns>
        public static bool Handled(this BackClickEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that can cancel the navigation. A <c>true</c> value for Handled cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="BackClickEventArgs"/>.</param>
        /// <param name="handled"><c>true</c> to cancel the navigation. <c>false</c> to use default behavior.</param>
        public static void Handled(this BackClickEventArgs e, bool handled) => Resolver.Handled(e, handled);

        private sealed class DefaultBackClickEventArgsResolver : IBackClickEventArgsResolver
        {
            bool IBackClickEventArgsResolver.Handled(BackClickEventArgs e) => e.Handled;
            void IBackClickEventArgsResolver.Handled(BackClickEventArgs e, bool handled) => e.Handled = handled;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="BackClickEventArgs"/>.
    /// </summary>
    public interface IBackClickEventArgsResolver
    {
        /// <summary>
        /// Gets a value that can cancel the navigation. A <c>true</c> value for Handled cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="BackClickEventArgs"/>.</param>
        /// <returns><c>true</c> to cancel the navigation. <c>false</c> to use default behavior. The default is <c>false</c>.</returns>
        bool Handled(BackClickEventArgs e);

        /// <summary>
        /// Sets a value that can cancel the navigation. A <c>true</c> value for Handled cancels the default behavior.
        /// </summary>
        /// <param name="e">The requested <see cref="BackClickEventArgs"/>.</param>
        /// <param name="handled"><c>true</c> to cancel the navigation. <c>false</c> to use default behavior.</param>
        void Handled(BackClickEventArgs e, bool handled);
    }
}
