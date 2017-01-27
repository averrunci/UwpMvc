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
    /// Provides data of the <see cref="MapRightTappedEventArgs"/>
    /// resolved by <see cref="IMapRightTappedEventArgsResolver"/>.
    /// </summary>
    public static class MapRightTappedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapRightTappedEventArgsResolver"/>
        /// that resolves data of the <see cref="MapRightTappedEventArgs"/>.
        /// </summary>
        public static IMapRightTappedEventArgsResolver Resolver { get; set; } = new DefaultMapRightTappedEventArgsResolver();

        /// <summary>
        /// Gets the geographic location that corresponds to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapRightTappedEventArgs"/>.</param>
        /// <returns>The geographic location that corresponds to where the <see cref="MapControl"/> received user input.</returns>
        public static Geopoint Location(this MapRightTappedEventArgs e) => Resolver.Location(e);

        /// <summary>
        /// Gets the physical position on the <see cref="MapControl"/> where it received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapRightTappedEventArgs"/>.</param>
        /// <returns>
        /// The physical position on the <see cref="MapControl"/> where it received user input,
        /// in terms of X and Y coordinates.
        /// </returns>
        public static Point Position(this MapRightTappedEventArgs e) => Resolver.Position(e);

        private sealed class DefaultMapRightTappedEventArgsResolver : IMapRightTappedEventArgsResolver
        {
            Geopoint IMapRightTappedEventArgsResolver.Location(MapRightTappedEventArgs e) => e.Location;
            Point IMapRightTappedEventArgsResolver.Position(MapRightTappedEventArgs e) => e.Position;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapRightTappedEventArgs"/>.
    /// </summary>
    public interface IMapRightTappedEventArgsResolver
    {
        /// <summary>
        /// Gets the geographic location that corresponds to where the <see cref="MapControl"/> received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapRightTappedEventArgs"/>.</param>
        /// <returns>The geographic location that corresponds to where the <see cref="MapControl"/> received user input.</returns>
        Geopoint Location(MapRightTappedEventArgs e);

        /// <summary>
        /// Gets the physical position on the <see cref="MapControl"/> where it received user input.
        /// </summary>
        /// <param name="e">The requested <see cref="MapRightTappedEventArgs"/>.</param>
        /// <returns>
        /// The physical position on the <see cref="MapControl"/> where it received user input,
        /// in terms of X and Y coordinates.
        /// </returns>
        Point Position(MapRightTappedEventArgs e);
    }
}
