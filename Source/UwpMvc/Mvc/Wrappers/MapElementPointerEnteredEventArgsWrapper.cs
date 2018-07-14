// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Maps;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="MapElementPointerEnteredEventArgs"/>
    /// resolved by <see cref="IMapElementPointerEnteredEventArgsResolver"/>.
    /// </summary>
    public static class MapElementPointerEnteredEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapElementPointerEnteredEventArgsResolver"/>
        /// that resolves data of the <see cref="MapElementPointerEnteredEventArgs"/>.
        /// </summary>
        public static IMapElementPointerEnteredEventArgsResolver Resolver { get; set; } = new DefaultMapElementPointerEnteredEventArgsResolver();

        /// <summary>
        /// Gets the geographic location that corresponds to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerEnteredEventArgs"/>.</param>
        /// <returns>The geographic location that corresponds to where the <see cref="MapControl"/> received user input.</returns>
        public static Geopoint Location(this MapElementPointerEnteredEventArgs e) => Resolver.Location(e);

        /// <summary>
        /// Gets the map element that correspond to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerEnteredEventArgs"/>.</param>
        /// <returns>The map element that correspond to where the <see cref="MapControl"/> received user input.</returns>
        public static MapElement MapElement(this MapElementPointerEnteredEventArgs e) => Resolver.MapElement(e);

        /// <summary>
        /// Gets the physical position on the <see cref="MapControl"/> where it received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerEnteredEventArgs"/>.</param>
        /// <returns>
        /// The physical position on the <see cref="MapControl"/> where it received user input,
        /// in terms of X and Y coordinates.
        /// </returns>
        public static Point Position(this MapElementPointerEnteredEventArgs e) => Resolver.Position(e);

        private sealed class DefaultMapElementPointerEnteredEventArgsResolver : IMapElementPointerEnteredEventArgsResolver
        {
            Geopoint IMapElementPointerEnteredEventArgsResolver.Location(MapElementPointerEnteredEventArgs e) => e.Location;
            MapElement IMapElementPointerEnteredEventArgsResolver.MapElement(MapElementPointerEnteredEventArgs e) => e.MapElement;
            Point IMapElementPointerEnteredEventArgsResolver.Position(MapElementPointerEnteredEventArgs e) => e.Position;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapElementPointerEnteredEventArgs"/>.
    /// </summary>
    public interface IMapElementPointerEnteredEventArgsResolver
    {
        /// <summary>
        /// Gets the geographic location that corresponds to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerEnteredEventArgs"/>.</param>
        /// <returns>The geographic location that corresponds to where the <see cref="MapControl"/> received user input.</returns>
        Geopoint Location(MapElementPointerEnteredEventArgs e);

        /// <summary>
        /// Gets the map element that correspond to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerEnteredEventArgs"/>.</param>
        /// <returns>The map element that correspond to where the <see cref="MapControl"/> received user input.</returns>
        MapElement MapElement(MapElementPointerEnteredEventArgs e);

        /// <summary>
        /// Gets the physical position on the <see cref="MapControl"/> where it received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerEnteredEventArgs"/>.</param>
        /// <returns>
        /// The physical position on the <see cref="MapControl"/> where it received user input,
        /// in terms of X and Y coordinates.
        /// </returns>
        Point Position(MapElementPointerEnteredEventArgs e);
    }
}
