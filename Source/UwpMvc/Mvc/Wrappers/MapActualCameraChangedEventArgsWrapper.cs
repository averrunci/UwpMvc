// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Maps;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="MapActualCameraChangedEventArgs"/>
    /// resolved by <see cref="IMapActualCameraChangedEventArgsResolver"/>.
    /// </summary>
    public static class MapActualCameraChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapActualCameraChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="MapActualCameraChangedEventArgs"/>.
        /// </summary>
        public static IMapActualCameraChangedEventArgsResolver Resolver { get; set; } = new DefaultMapActualCameraChangedEventArgsResolver();

        /// <summary>
        /// Gets the current position of the map's camera.
        /// </summary>
        /// <param name="e">The requested <see cref="MapActualCameraChangedEventArgs"/>.</param>
        /// <returns>The current position of the map's camera.</returns>
        public static MapCamera Camera(this MapActualCameraChangedEventArgs e) => Resolver.Camera(e);

        /// <summary>
        /// Indicates the reason the <see cref="MapControl.ActualCameraChanged"/> event was triggered.
        /// </summary>
        /// <param name="e">The requested <see cref="MapActualCameraChangedEventArgs"/>.</param>
        /// <returns>The reason the <see cref="MapControl.ActualCameraChanged"/> event was triggered.</returns>
        public static MapCameraChangeReason ChangeReason(this MapActualCameraChangedEventArgs e) => Resolver.ChangeReason(e);

        private sealed class DefaultMapActualCameraChangedEventArgsResolver : IMapActualCameraChangedEventArgsResolver
        {
            MapCamera IMapActualCameraChangedEventArgsResolver.Camera(MapActualCameraChangedEventArgs e) => e.Camera;
            MapCameraChangeReason IMapActualCameraChangedEventArgsResolver.ChangeReason(MapActualCameraChangedEventArgs e) => e.ChangeReason;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapActualCameraChangedEventArgs"/>.
    /// </summary>
    public interface IMapActualCameraChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the current position of the map's camera.
        /// </summary>
        /// <param name="e">The requested <see cref="MapActualCameraChangedEventArgs"/>.</param>
        /// <returns>The current position of the map's camera.</returns>
        MapCamera Camera(MapActualCameraChangedEventArgs e);

        /// <summary>
        /// Indicates the reason the <see cref="MapControl.ActualCameraChanged"/> event was triggered.
        /// </summary>
        /// <param name="e">The requested <see cref="MapActualCameraChangedEventArgs"/>.</param>
        /// <returns>The reason the <see cref="MapControl.ActualCameraChanged"/> event was triggered.</returns>
        MapCameraChangeReason ChangeReason(MapActualCameraChangedEventArgs e);
    }
}
