// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="SemanticZoomViewChangedEventArgs"/>
    /// resolved by <see cref="ISemanticZoomViewChangedEventArgsResolver"/>.
    /// </summary>
    public static class SemanticZoomViewChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ISemanticZoomViewChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="SemanticZoomViewChangedEventArgs"/>.
        /// </summary>
        public static ISemanticZoomViewChangedEventArgsResolver Resolver { get; set; } = new DefaultSemanticZoomViewChangedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates whether the starting view is the ZoomedInView.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <returns><c>true</c> if the starting view is the ZoomedInView; otherwise, <c>false</c>.</returns>
        public static bool IsSourceZoomedInView(this SemanticZoomViewChangedEventArgs e) => Resolver.IsSourceZoomedInView(e);

        /// <summary>
        /// Sets a value that indicates whether the starting view is the ZoomedInView.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <param name="isSourceZoomedInView"><c>true</c> if the starting view is the ZoomedInView; otherwise, <c>false</c>.</param>
        public static void IsSourceZoomedInView(this SemanticZoomViewChangedEventArgs e, bool isSourceZoomedInView) => Resolver.IsSourceZoomedInView(e, isSourceZoomedInView);

        /// <summary>
        /// Provides information about the item and its bounds, for the item as represented in the previous view.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <returns>Information about the item and its bounds.</returns>
        public static SemanticZoomLocation SourceItem(this SemanticZoomViewChangedEventArgs e) => Resolver.SourceItem(e);

        /// <summary>
        /// Provides information about the item and its bounds, for the item as represented in the previous view.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <param name="sourceItem">Information about the item and its bounds.</param>
        public static void SourceItem(this SemanticZoomViewChangedEventArgs e, SemanticZoomLocation sourceItem) => Resolver.SourceItem(e, sourceItem);

        /// <summary>
        /// Provides information about the item and its bounds, once the view change is complete.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <returns>Information about the item and its bounds.</returns>
        public static SemanticZoomLocation DestinationItem(this SemanticZoomViewChangedEventArgs e) => Resolver.DestinationItem(e);

        /// <summary>
        /// Provides information about the item and its bounds, once the view change is complete.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <param name="destinationItem">Information about the item and its bounds.</param>
        public static void DestinationItem(this SemanticZoomViewChangedEventArgs e, SemanticZoomLocation destinationItem) => Resolver.DestinationItem(e, destinationItem);

        private sealed class DefaultSemanticZoomViewChangedEventArgsResolver : ISemanticZoomViewChangedEventArgsResolver
        {
            bool ISemanticZoomViewChangedEventArgsResolver.IsSourceZoomedInView(SemanticZoomViewChangedEventArgs e) => e.IsSourceZoomedInView;
            void ISemanticZoomViewChangedEventArgsResolver.IsSourceZoomedInView(SemanticZoomViewChangedEventArgs e, bool isSourceZoomedInView) => e.IsSourceZoomedInView = isSourceZoomedInView;
            SemanticZoomLocation ISemanticZoomViewChangedEventArgsResolver.SourceItem(SemanticZoomViewChangedEventArgs e) => e.SourceItem;
            void ISemanticZoomViewChangedEventArgsResolver.SourceItem(SemanticZoomViewChangedEventArgs e, SemanticZoomLocation sourceItem) => e.SourceItem = sourceItem;
            SemanticZoomLocation ISemanticZoomViewChangedEventArgsResolver.DestinationItem(SemanticZoomViewChangedEventArgs e) => e.DestinationItem;
            void ISemanticZoomViewChangedEventArgsResolver.DestinationItem(SemanticZoomViewChangedEventArgs e, SemanticZoomLocation destinationItem) => e.DestinationItem = destinationItem;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="SemanticZoomViewChangedEventArgs"/>.
    /// </summary>
    public interface ISemanticZoomViewChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates whether the starting view is the ZoomedInView.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <returns><c>true</c> if the starting view is the ZoomedInView; otherwise, <c>false</c>.</returns>
        bool IsSourceZoomedInView(SemanticZoomViewChangedEventArgs e);

        /// <summary>
        /// Sets a value that indicates whether the starting view is the ZoomedInView.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <param name="isSourceZoomedInView"><c>true</c> if the starting view is the ZoomedInView; otherwise, <c>false</c>.</param>
        void IsSourceZoomedInView(SemanticZoomViewChangedEventArgs e, bool isSourceZoomedInView);

        /// <summary>
        /// Provides information about the item and its bounds, for the item as represented in the previous view.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <returns>Information about the item and its bounds.</returns>
        SemanticZoomLocation SourceItem(SemanticZoomViewChangedEventArgs e);

        /// <summary>
        /// Provides information about the item and its bounds, for the item as represented in the previous view.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <param name="sourceItem">Information about the item and its bounds.</param>
        void SourceItem(SemanticZoomViewChangedEventArgs e, SemanticZoomLocation sourceItem);

        /// <summary>
        /// Provides information about the item and its bounds, once the view change is complete.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <returns>Information about the item and its bounds.</returns>
        SemanticZoomLocation DestinationItem(SemanticZoomViewChangedEventArgs e);

        /// <summary>
        /// Provides information about the item and its bounds, once the view change is complete.
        /// </summary>
        /// <param name="e">The requested <see cref="SemanticZoomViewChangedEventArgs"/>.</param>
        /// <param name="destinationItem">Information about the item and its bounds.</param>
        void DestinationItem(SemanticZoomViewChangedEventArgs e, SemanticZoomLocation destinationItem);
    }
}
