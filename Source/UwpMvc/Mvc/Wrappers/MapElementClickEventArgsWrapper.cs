// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Maps;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="MapElementClickEventArgs"/>
    /// resolved by <see cref="IMapElementClickEventArgsResolver"/>.
    /// </summary>
    public static class MapElementClickEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapElementClickEventArgsResolver"/>
        /// that resolves data of the <see cref="MapElementClickEventArgs"/>.
        /// </summary>
        public static IMapElementClickEventArgsResolver Resolver { get; set; } = new DefaultMapElementClickEventArgsResolver();

        /// <summary>
        /// Gets the geographic location that corresponds to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementClickEventArgs"/>.</param>
        /// <returns>The geographic location that corresponds to where the <see cref="MapControl"/> received user input.</returns>
        public static Geopoint Location(this MapElementClickEventArgs e) => Resolver.Location(e);

        /// <summary>
        /// Gets a list of map elements that correspond to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementClickEventArgs"/>.</param>
        /// <returns>A list of map elements that correspond to where the <see cref="MapControl"/> received user input.</returns>
        public static IList<MapElement> MapElements(this MapElementClickEventArgs e) => Resolver.MapElements(e);

        /// <summary>
        /// Gets the physical position on the <see cref="MapControl"/> where it received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementClickEventArgs"/>.</param>
        /// <returns>
        /// The physical position on the <see cref="MapControl"/> where it received user input,
        /// in terms of X and Y coordinates.
        /// </returns>
        public static Point Position(this MapElementClickEventArgs e) => Resolver.Position(e);

        private sealed class DefaultMapElementClickEventArgsResolver : IMapElementClickEventArgsResolver
        {
            Geopoint IMapElementClickEventArgsResolver.Location(MapElementClickEventArgs e) => e.Location;
            IList<MapElement> IMapElementClickEventArgsResolver.MapElements(MapElementClickEventArgs e) => e.MapElements;
            Point IMapElementClickEventArgsResolver.Position(MapElementClickEventArgs e) => e.Position;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapElementClickEventArgs"/>.
    /// </summary>
    public interface IMapElementClickEventArgsResolver
    {
        /// <summary>
        /// Gets the geographic location that corresponds to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementClickEventArgs"/>.</param>
        /// <returns>The geographic location that corresponds to where the <see cref="MapControl"/> received user input.</returns>
        Geopoint Location(MapElementClickEventArgs e);

        /// <summary>
        /// Gets a list of map elements that correspond to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementClickEventArgs"/>.</param>
        /// <returns>A list of map elements that correspond to where the <see cref="MapControl"/> received user input.</returns>
        IList<MapElement> MapElements(MapElementClickEventArgs e);

        /// <summary>
        /// Gets the physical position on the <see cref="MapControl"/> where it received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementClickEventArgs"/>.</param>
        /// <returns>
        /// The physical position on the <see cref="MapControl"/> where it received user input,
        /// in terms of X and Y coordinates.
        /// </returns>
        Point Position(MapElementClickEventArgs e);
    }
}
