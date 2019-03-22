// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="RefreshRequestedEventArgs"/>
    /// resolved by <see cref="IRefreshRequestedEventArgsResolver"/>.
    /// </summary>
    public static class RefreshRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IRefreshRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="RefreshRequestedEventArgs"/>.
        /// </summary>
        public static IRefreshRequestedEventArgsResolver Resolver { get; set; } = new DefaultRefreshRequestedEventArgsResolver();

        /// <summary>
        /// Gets a deferral object for managing the work done in the RefreshRequested event handler.
        /// </summary>
        /// <param name="e">The requested <see cref="RefreshRequestedEventArgs"/>.</param>
        /// <returns>A deferral object.</returns>
        public static Deferral GetDeferralWrapped(this RefreshRequestedEventArgs e) => Resolver.GetDeferral(e);

        private sealed class DefaultRefreshRequestedEventArgsResolver : IRefreshRequestedEventArgsResolver
        {
            public Deferral GetDeferral(RefreshRequestedEventArgs e) => e.GetDeferral();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="RefreshRequestedEventArgs"/>.
    /// </summary>
    public interface IRefreshRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets a deferral object for managing the work done in the RefreshRequested event handler.
        /// </summary>
        /// <param name="e">The requested <see cref="RefreshRequestedEventArgs"/>.</param>
        /// <returns>A deferral object.</returns>
        Deferral GetDeferral(RefreshRequestedEventArgs e);
    }
}
