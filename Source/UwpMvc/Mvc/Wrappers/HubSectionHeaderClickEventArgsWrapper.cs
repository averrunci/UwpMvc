// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="HubSectionHeaderClickEventArgs"/>
    /// resolved by <see cref="IHubSectionHeaderClickEventArgsResolver"/>.
    /// </summary>
    public static class HubSectionHeaderClickEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IHubSectionHeaderClickEventArgsResolver"/>
        /// that resolves data of the <see cref="HubSectionHeaderClickEventArgs"/>.
        /// </summary>
        public static IHubSectionHeaderClickEventArgsResolver Resolver { get; set; } = new DefaultHubSectionHeaderClickEventArgsResolver();

        /// <summary>
        /// Gets the <see cref="HubSection"/> for the header that was clicked.
        /// </summary>
        /// <param name="e">The requested <see cref="HubSectionHeaderClickEventArgs"/>.</param>
        /// <returns>The <see cref="HubSection"/> for the header that was clicked.</returns>
        public static HubSection Section(this HubSectionHeaderClickEventArgs e) => Resolver.Section(e);

        private sealed class DefaultHubSectionHeaderClickEventArgsResolver : IHubSectionHeaderClickEventArgsResolver
        {
            HubSection IHubSectionHeaderClickEventArgsResolver.Section(HubSectionHeaderClickEventArgs e) => e.Section;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="HubSectionHeaderClickEventArgs"/>.
    /// </summary>
    public interface IHubSectionHeaderClickEventArgsResolver
    {
        /// <summary>
        /// Gets the <see cref="HubSection"/> for the header that was clicked.
        /// </summary>
        /// <param name="e">The requested <see cref="HubSectionHeaderClickEventArgs"/>.</param>
        /// <returns>The <see cref="HubSection"/> for the header that was clicked.</returns>
        HubSection Section(HubSectionHeaderClickEventArgs e);
    }
}
