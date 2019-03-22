// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="RefreshStateChangedEventArgs"/>
    /// resolved by <see cref="IRefreshStateChangedEventArgsResolver"/>.
    /// </summary>
    public static class RefreshStateChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IRefreshStateChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="RefreshStateChangedEventArgs"/>.
        /// </summary>
        public static IRefreshStateChangedEventArgsResolver Resolver { get; set; } = new DefaultRefreshStateChangedEventArgsResolver();

        /// <summary>
        /// Gets a value that indicates the new state of the RefreshVisualizer.
        /// </summary>
        /// <param name="e">The requested <see cref="RefreshStateChangedEventArgs"/>.</param>
        /// <returns>An enumeration value that indicates the new state of the RefreshVisualizer.</returns>
        public static RefreshVisualizerState NewState(this RefreshStateChangedEventArgs e) => Resolver.NewState(e);

        /// <summary>
        /// Gets a value that indicates the previous state of the RefreshVisualizer.
        /// </summary>
        /// <param name="e">The requested <see cref="RefreshStateChangedEventArgs"/>.</param>
        /// <returns>An enumeration value that indicates the previous state of the RefreshVisualizer.</returns>
        public static RefreshVisualizerState OldState(this RefreshStateChangedEventArgs e) => Resolver.OldState(e);

        private sealed class DefaultRefreshStateChangedEventArgsResolver : IRefreshStateChangedEventArgsResolver
        {
            RefreshVisualizerState IRefreshStateChangedEventArgsResolver.NewState(RefreshStateChangedEventArgs e) => e.NewState;
            RefreshVisualizerState IRefreshStateChangedEventArgsResolver.OldState(RefreshStateChangedEventArgs e) => e.OldState;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="RefreshStateChangedEventArgs"/>.
    /// </summary>
    public interface IRefreshStateChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that indicates the new state of the RefreshVisualizer.
        /// </summary>
        /// <param name="e">The requested <see cref="RefreshStateChangedEventArgs"/>.</param>
        /// <returns>An enumeration value that indicates the new state of the RefreshVisualizer.</returns>
        RefreshVisualizerState NewState(RefreshStateChangedEventArgs e);

        /// <summary>
        /// Gets a value that indicates the previous state of the RefreshVisualizer.
        /// </summary>
        /// <param name="e">The requested <see cref="RefreshStateChangedEventArgs"/>.</param>
        /// <returns>An enumeration value that indicates the previous state of the RefreshVisualizer.</returns>
        RefreshVisualizerState OldState(RefreshStateChangedEventArgs e);
    }
}
