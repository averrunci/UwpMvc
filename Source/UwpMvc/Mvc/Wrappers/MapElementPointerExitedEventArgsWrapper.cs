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
    /// Provides data of the <see cref="MapElementPointerExitedEventArgs"/>
    /// resolved by <see cref="IMapElementPointerExitedEventArgsResolver"/>.
    /// </summary>
    public static class MapElementPointerExitedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapElementPointerExitedEventArgsResolver"/>
        /// that resolves data of the <see cref="MapElementPointerExitedEventArgs"/>.
        /// </summary>
        public static IMapElementPointerExitedEventArgsResolver Resolver { get; set; } = new DefaultMapElementPointerExitedEventArgsResolver();

        /// <summary>
        /// Gets the geographic location that corresponds to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerExitedEventArgs"/>.</param>
        /// <returns>The geographic location that corresponds to where the <see cref="MapControl"/> received user input.</returns>
        public static Geopoint Location(this MapElementPointerExitedEventArgs e) => Resolver.Location(e);

        /// <summary>
        /// Gets the map element that correspond to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerExitedEventArgs"/>.</param>
        /// <returns>The map element that correspond to where the <see cref="MapControl"/> received user input.</returns>
        public static MapElement MapElement(this MapElementPointerExitedEventArgs e) => Resolver.MapElement(e);

        /// <summary>
        /// Gets the physical position on the <see cref="MapControl"/> where it received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerExitedEventArgs"/>.</param>
        /// <returns>
        /// The physical position on the <see cref="MapControl"/> where it received user input,
        /// in terms of X and Y coordinates.
        /// </returns>
        public static Point Position(this MapElementPointerExitedEventArgs e) => Resolver.Position(e);

        private sealed class DefaultMapElementPointerExitedEventArgsResolver : IMapElementPointerExitedEventArgsResolver
        {
            Geopoint IMapElementPointerExitedEventArgsResolver.Location(MapElementPointerExitedEventArgs e) => e.Location;
            MapElement IMapElementPointerExitedEventArgsResolver.MapElement(MapElementPointerExitedEventArgs e) => e.MapElement;
            Point IMapElementPointerExitedEventArgsResolver.Position(MapElementPointerExitedEventArgs e) => e.Position;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapElementPointerExitedEventArgs"/>.
    /// </summary>
    public interface IMapElementPointerExitedEventArgsResolver
    {
        /// <summary>
        /// Gets the geographic location that corresponds to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerExitedEventArgs"/>.</param>
        /// <returns>The geographic location that corresponds to where the <see cref="MapControl"/> received user input.</returns>
        Geopoint Location(MapElementPointerExitedEventArgs e);

        /// <summary>
        /// Gets the map element that correspond to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerExitedEventArgs"/>.</param>
        /// <returns>The map element that correspond to where the <see cref="MapControl"/> received user input.</returns>
        MapElement MapElement(MapElementPointerExitedEventArgs e);

        /// <summary>
        /// Gets the physical position on the <see cref="MapControl"/> where it received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapElementPointerExitedEventArgs"/>.</param>
        /// <returns>
        /// The physical position on the <see cref="MapControl"/> where it received user input,
        /// in terms of X and Y coordinates.
        /// </returns>
        Point Position(MapElementPointerExitedEventArgs e);
    }
}
