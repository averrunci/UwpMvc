// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.Devices.Geolocation;
using Windows.Foundation;
using Windows.UI.Xaml.Controls.Maps;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="MapContextRequestedEventArgs"/>
    /// resolved by <see cref="IMapContextRequestedEventArgsResolver"/>.
    /// </summary>
    public static class MapContextRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IMapContextRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="MapContextRequestedEventArgs"/>.
        /// </summary>
        public static IMapContextRequestedEventArgsResolver Resolver { get; set; } = new DefaultMapContextRequestedEventArgsResolver();

        /// <summary>
        /// Gets a geolocation on the map of a context input gesture, such as a right-click.
        /// </summary>
        /// <param name="e">The requested <see cref="MapContextRequestedEventArgs"/>.</param>
        /// <returns>The geolocation on the map of a context input gesture, such as a right-click.</returns>
        public static Geopoint Location(this MapContextRequestedEventArgs e) => Resolver.Location(e);

        /// <summary>
        /// Gets a collection of MapElement objects at the point on the map specified by the Location property.
        /// </summary>
        /// <param name="e">The requested <see cref="MapContextRequestedEventArgs"/>.</param>
        /// <returns>A collection of MapElement objects at the point on the map specified by the Location property.</returns>
        public static IReadOnlyList<MapElement> MapElements(this MapContextRequestedEventArgs e) => Resolver.MapElements(e);

        /// <summary>
        /// Gets the x- and y-coordinate values that define the point on the map of a context input gesture, such as a right-click.
        /// </summary>
        /// <param name="e">The requested <see cref="MapContextRequestedEventArgs"/>.</param>
        /// <returns>The x- and y-coordinate values that define the point on the map of a context input gesture, such as a right-click.</returns>
        public static Point Position(this MapContextRequestedEventArgs e) => Resolver.Position(e);

        private sealed class DefaultMapContextRequestedEventArgsResolver : IMapContextRequestedEventArgsResolver
        {
            Geopoint IMapContextRequestedEventArgsResolver.Location(MapContextRequestedEventArgs e) => e.Location;
            IReadOnlyList<MapElement> IMapContextRequestedEventArgsResolver.MapElements(MapContextRequestedEventArgs e) => e.MapElements;
            Point IMapContextRequestedEventArgsResolver.Position(MapContextRequestedEventArgs e) => e.Position;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="MapContextRequestedEventArgs"/>.
    /// </summary>
    public interface IMapContextRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets a geolocation on the map of a context input gesture, such as a right-click.
        /// </summary>
        /// <param name="e">The requested <see cref="MapContextRequestedEventArgs"/>.</param>
        /// <returns>The geolocation on the map of a context input gesture, such as a right-click.</returns>
        Geopoint Location(MapContextRequestedEventArgs e);

        /// <summary>
        /// Gets a collection of MapElement objects at the point on the map specified by the Location property.
        /// </summary>
        /// <param name="e">The requested <see cref="MapContextRequestedEventArgs"/>.</param>
        /// <returns>A collection of MapElement objects at the point on the map specified by the Location property.</returns>
        IReadOnlyList<MapElement> MapElements(MapContextRequestedEventArgs e);

        /// <summary>
        /// Gets the x- and y-coordinate values that define the point on the map of a context input gesture, such as a right-click.
        /// </summary>
        /// <param name="e">The requested <see cref="MapContextRequestedEventArgs"/>.</param>
        /// <returns>The x- and y-coordinate values that define the point on the map of a context input gesture, such as a right-click.</returns>
        Point Position(MapContextRequestedEventArgs e);
    }
}
