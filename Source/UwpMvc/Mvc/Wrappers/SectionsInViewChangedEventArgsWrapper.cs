// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SectionsInViewChangedEventArgs"/>
    /// resolved by <see cref="ISectionsInViewChangedEventArgsResolver"/>.
    /// </summary>
    public static class SectionsInViewChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISectionsInViewChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="SectionsInViewChangedEventArgs"/>.
        /// </summary>
        public static ISectionsInViewChangedEventArgsResolver Resolver { get; set; } = new DefaultSectionsInViewChangedEventArgsResolver();

        /// <summary>
        /// Gets a collection that contains the hub sections that moved into view.
        /// </summary>
        /// <param name="e">The requested <see cref="SectionsInViewChangedEventArgs"/>.</param>
        /// <returns>A collection that contains the hub sections that moved into view.</returns>
        public static IList<HubSection> AddedSections(this SectionsInViewChangedEventArgs e) => Resolver.AddedSections(e);

        /// <summary>
        /// Gets a collection that contains the hub sections that moved out of view.
        /// </summary>
        /// <param name="e">The requested <see cref="SectionsInViewChangedEventArgs"/>.</param>
        /// <returns>A collection that contains the hub sections that moved into view.</returns>
        public static IList<HubSection> RemovedSections(this SectionsInViewChangedEventArgs e) => Resolver.RemovedSections(e);

        private sealed class DefaultSectionsInViewChangedEventArgsResolver : ISectionsInViewChangedEventArgsResolver
        {
            IList<HubSection> ISectionsInViewChangedEventArgsResolver.AddedSections(SectionsInViewChangedEventArgs e) => e.AddedSections;
            IList<HubSection> ISectionsInViewChangedEventArgsResolver.RemovedSections(SectionsInViewChangedEventArgs e) => e.RemovedSections;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SectionsInViewChangedEventArgs"/>.
    /// </summary>
    public interface ISectionsInViewChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a collection that contains the hub sections that moved into view.
        /// </summary>
        /// <param name="e">The requested <see cref="SectionsInViewChangedEventArgs"/>.</param>
        /// <returns>A collection that contains the hub sections that moved into view.</returns>
        IList<HubSection> AddedSections(SectionsInViewChangedEventArgs e);

        /// <summary>
        /// Gets a collection that contains the hub sections that moved out of view.
        /// </summary>
        /// <param name="e">The requested <see cref="SectionsInViewChangedEventArgs"/>.</param>
        /// <returns>A collection that contains the hub sections that moved into view.</returns>
        IList<HubSection> RemovedSections(SectionsInViewChangedEventArgs e);
    }
}
