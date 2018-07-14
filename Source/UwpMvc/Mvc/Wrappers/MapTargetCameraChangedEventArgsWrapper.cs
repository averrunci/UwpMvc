// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Maps;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="MapTargetCameraChangedEventArgs"/>
    /// resolved by <see cref="IMapTargetCameraChangedEventArgsResolver"/>.
    /// </summary>
    public static class MapTargetCameraChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapTargetCameraChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="MapTargetCameraChangedEventArgs"/>.
        /// </summary>
        public static IMapTargetCameraChangedEventArgsResolver Resolver { get; set; } = new DefaultMapTargetCameraChangedEventArgsResolver();

        /// <summary>
        /// Gets the camera position corresponding to the <see cref="MapControl.TargetCameraChanged"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="MapTargetCameraChangedEventArgs"/>.</param>
        /// <returns>The camera position corresponding to the <see cref="MapControl.TargetCameraChanged"/> event.</returns>
        public static MapCamera Camera(this MapTargetCameraChangedEventArgs e) => Resolver.Camera(e);

        /// <summary>
        /// Gets the camera change reason.
        /// </summary>
        /// <param name="e">The requested <see cref="MapTargetCameraChangedEventArgs"/>.</param>
        /// <returns>The reason the camera changed.</returns>
        public static MapCameraChangeReason ChangeReason(this MapTargetCameraChangedEventArgs e) => Resolver.ChangeReason(e);

        private sealed class DefaultMapTargetCameraChangedEventArgsResolver : IMapTargetCameraChangedEventArgsResolver
        {
            MapCamera IMapTargetCameraChangedEventArgsResolver.Camera(MapTargetCameraChangedEventArgs e) => e.Camera;
            MapCameraChangeReason IMapTargetCameraChangedEventArgsResolver.ChangeReason(MapTargetCameraChangedEventArgs e) => e.ChangeReason;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapTargetCameraChangedEventArgs"/>.
    /// </summary>
    public interface IMapTargetCameraChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the camera position corresponding to the <see cref="MapControl.TargetCameraChanged"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="MapTargetCameraChangedEventArgs"/>.</param>
        /// <returns>The camera position corresponding to the <see cref="MapControl.TargetCameraChanged"/> event.</returns>
        MapCamera Camera(MapTargetCameraChangedEventArgs e);

        /// <summary>
        /// Gets the camera change reason.
        /// </summary>
        /// <param name="e">The requested <see cref="MapTargetCameraChangedEventArgs"/>.</param>
        /// <returns>The reason the camera changed.</returns>
        MapCameraChangeReason ChangeReason(MapTargetCameraChangedEventArgs e);
    }
}
