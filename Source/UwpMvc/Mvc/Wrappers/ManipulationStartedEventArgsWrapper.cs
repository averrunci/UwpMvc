// Copyright (C) 2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.UI.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ManipulationStartedEventArgs"/>
    /// resolved by <see cref="IManipulationStartedEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationStartedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationStartedEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationStartedEventArgs"/>.
        /// </summary>
        public static IManipulationStartedEventArgsResolver Resolver { get; set; } = new DefaultManipulationStartedEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this ManipulationStartedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the pointer associated with the manipulation for the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this ManipulationStartedEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets values that indicate the accumulated transformation deltas (translation, rotation, scale)
        /// for a manipulation before the <see cref="GestureRecognizer.ManipulationStarted"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedEventArgs"/>.</param>
        /// <returns>The accumulated transformation values up to the ManipulationStarted event.</returns>
        public static ManipulationDelta Cumulative(this ManipulationStartedEventArgs e) => Resolver.Cumulative(e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.ManipulationStarted"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this ManipulationStartedEventArgs e) => Resolver.ContactCount(e);

        private sealed class DefaultManipulationStartedEventArgsResolver : IManipulationStartedEventArgsResolver
        {
            PointerDeviceType IManipulationStartedEventArgsResolver.PointerDeviceType(ManipulationStartedEventArgs e) => e.PointerDeviceType;
            Point IManipulationStartedEventArgsResolver.Position(ManipulationStartedEventArgs e) => e.Position;
            ManipulationDelta IManipulationStartedEventArgsResolver.Cumulative(ManipulationStartedEventArgs e) => e.Cumulative;
            uint IManipulationStartedEventArgsResolver.ContactCount(ManipulationStartedEventArgs e) => e.ContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationStartedEventArgs"/>.
    /// </summary>
    public interface IManipulationStartedEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(ManipulationStartedEventArgs e);

        /// <summary>
        /// Gets the location of the pointer associated with the manipulation for the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(ManipulationStartedEventArgs e);

        /// <summary>
        /// Gets values that indicate the accumulated transformation deltas (translation, rotation, scale)
        /// for a manipulation before the <see cref="GestureRecognizer.ManipulationStarted"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedEventArgs"/>.</param>
        /// <returns>The accumulated transformation values up to the ManipulationStarted event.</returns>
        ManipulationDelta Cumulative(ManipulationStartedEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.ManipulationStarted"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(ManipulationStartedEventArgs e);
    }
}
