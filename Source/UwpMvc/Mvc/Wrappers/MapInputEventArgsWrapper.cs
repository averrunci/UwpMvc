// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Maps;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="MapInputEventArgs"/>
    /// resolved by <see cref="IMapInputEventArgsResolver"/>.
    /// </summary>
    public static class MapInputEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapInputEventArgsResolver"/>
        /// that resolves data of the <see cref="MapInputEventArgs"/>.
        /// </summary>
        public static IMapInputEventArgsResolver Resolver { get; set; } = new DefaultMapInputEventArgsResolver();

        /// <summary>
        /// Gets the geographic location on the <see cref="MapControl"/> that received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapInputEventArgs"/>.</param>
        /// <returns>The geographic location on the <see cref="MapControl"/> that received user input.</returns>
        public static Geopoint Location(this MapInputEventArgs e) => Resolver.Location(e);

        /// <summary>
        /// Gets the physical location on the <see cref="MapControl"/> that received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapInputEventArgs"/>.</param>
        /// <returns>The physical location on the <see cref="MapControl"/> that received user input.</returns>
        public static Point Position(this MapInputEventArgs e) => Resolver.Position(e);

        private sealed class DefaultMapInputEventArgsResolver : IMapInputEventArgsResolver
        {
            Geopoint IMapInputEventArgsResolver.Location(MapInputEventArgs e) => e.Location;
            Point IMapInputEventArgsResolver.Position(MapInputEventArgs e) => e.Position;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapInputEventArgs"/>.
    /// </summary>
    public interface IMapInputEventArgsResolver
    {
        /// <summary>
        /// Gets the geographic location on the <see cref="MapControl"/> that received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapInputEventArgs"/>.</param>
        /// <returns>The geographic location on the <see cref="MapControl"/> that received user input.</returns>
        Geopoint Location(MapInputEventArgs e);

        /// <summary>
        /// Gets the physical location on the <see cref="MapControl"/> that received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapInputEventArgs"/>.</param>
        /// <returns>The physical location on the <see cref="MapControl"/> that received user input.</returns>
        Point Position(MapInputEventArgs e);
    }
}
