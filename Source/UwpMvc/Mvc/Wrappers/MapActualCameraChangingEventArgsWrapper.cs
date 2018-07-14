// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Maps;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="MapActualCameraChangingEventArgs"/>
    /// resolved by <see cref="IMapActualCameraChangingEventArgsResolver"/>.
    /// </summary>
    public static class MapActualCameraChangingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapActualCameraChangingEventArgsResolver"/>
        /// that resolves data of the <see cref="MapActualCameraChangingEventArgs"/>.
        /// </summary>
        public static IMapActualCameraChangingEventArgsResolver Resolver { get; set; } = new DefaultMapActualCameraChangingEventArgsResolver();

        /// <summary>
        /// Gets the position of the map's camera before it started moving.
        /// </summary>
        /// <param name="e">The requested <see cref="MapActualCameraChangingEventArgs"/>.</param>
        /// <returns>The position of the map's camera before it started moving.</returns>
        public static MapCamera Camera(this MapActualCameraChangingEventArgs e) => Resolver.Camera(e);

        /// <summary>
        /// Indicates the reason the <see cref="MapControl.ActualCameraChanging"/> event was triggered.
        /// </summary>
        /// <param name="e">The requested <see cref="MapActualCameraChangingEventArgs"/>.</param>
        /// <returns>The reason the <see cref="MapControl.ActualCameraChanging"/> event was triggered.</returns>
        public static MapCameraChangeReason ChangeReason(this MapActualCameraChangingEventArgs e) => Resolver.ChangeReason(e);

        private sealed class DefaultMapActualCameraChangingEventArgsResolver : IMapActualCameraChangingEventArgsResolver
        {
            MapCamera IMapActualCameraChangingEventArgsResolver.Camera(MapActualCameraChangingEventArgs e) => e.Camera;
            MapCameraChangeReason IMapActualCameraChangingEventArgsResolver.ChangeReason(MapActualCameraChangingEventArgs e) => e.ChangeReason;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapActualCameraChangingEventArgs"/>.
    /// </summary>
    public interface IMapActualCameraChangingEventArgsResolver
    {
        /// <summary>
        /// Gets the position of the map's camera before it started moving.
        /// </summary>
        /// <param name="e">The requested <see cref="MapActualCameraChangingEventArgs"/>.</param>
        /// <returns>The position of the map's camera before it started moving.</returns>
        MapCamera Camera(MapActualCameraChangingEventArgs e);

        /// <summary>
        /// Indicates the reason the <see cref="MapControl.ActualCameraChanging"/> event was triggered.
        /// </summary>
        /// <param name="e">The requested <see cref="MapActualCameraChangingEventArgs"/>.</param>
        /// <returns>The reason the <see cref="MapControl.ActualCameraChanging"/> event was triggered.</returns>
        MapCameraChangeReason ChangeReason(MapActualCameraChangingEventArgs e);
    }
}
