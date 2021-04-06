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
    /// Provides data of the <see cref="ManipulationUpdatedEventArgs"/>
    /// resolved by <see cref="IManipulationUpdatedEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationUpdatedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationUpdatedEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationUpdatedEventArgs"/>.
        /// </summary>
        public static IManipulationUpdatedEventArgsResolver Resolver { get; set; } = new DefaultManipulationUpdatedEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this ManipulationUpdatedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the pointer associated with the manipulation for the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this ManipulationUpdatedEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets values that indicate the changes in the transformation deltas (translation, rotation, scale)
        /// of a manipulation since the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The changes in transformation values since the last event.</returns>
        public static ManipulationDelta Delta(this ManipulationUpdatedEventArgs e) => Resolver.Delta(e);

        /// <summary>
        /// Gets values that indicate the accumulated transformation deltas (translation, rotation, scale)
        /// for a manipulation from the beginning of the interaction to the <see cref="GestureRecognizer.ManipulationUpdated"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The accumulated transformation values up to the ManipulationUpdated event.</returns>
        public static ManipulationDelta Cumulative(this ManipulationUpdatedEventArgs e) => Resolver.Cumulative(e);

        /// <summary>
        /// Gets values that indicate the velocities of the transformation deltas (translation, rotation, scale)
        /// for a manipulation at the <see cref="GestureRecognizer.ManipulationUpdated"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The velocities of the accumulated transformations since a ManipulationStarted event.</returns>
        public static ManipulationVelocities Velocities(this ManipulationUpdatedEventArgs e) => Resolver.Velocities(e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.ManipulationUpdated"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this ManipulationUpdatedEventArgs e) => Resolver.ContactCount(e);

        /// <summary>
        /// Gets the current number of contact points for the ongoing <see cref="GestureRecognizer.ManipulationUpdated"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint CurrentContactCount(this ManipulationUpdatedEventArgs e) => Resolver.CurrentContactCount(e);

        private sealed class DefaultManipulationUpdatedEventArgsResolver : IManipulationUpdatedEventArgsResolver
        {
            PointerDeviceType IManipulationUpdatedEventArgsResolver.PointerDeviceType(ManipulationUpdatedEventArgs e) => e.PointerDeviceType;
            Point IManipulationUpdatedEventArgsResolver.Position(ManipulationUpdatedEventArgs e) => e.Position;
            ManipulationDelta IManipulationUpdatedEventArgsResolver.Delta(ManipulationUpdatedEventArgs e) => e.Delta;
            ManipulationDelta IManipulationUpdatedEventArgsResolver.Cumulative(ManipulationUpdatedEventArgs e) => e.Cumulative;
            ManipulationVelocities IManipulationUpdatedEventArgsResolver.Velocities(ManipulationUpdatedEventArgs e) => e.Velocities;
            uint IManipulationUpdatedEventArgsResolver.ContactCount(ManipulationUpdatedEventArgs e) => e.ContactCount;
            uint IManipulationUpdatedEventArgsResolver.CurrentContactCount(ManipulationUpdatedEventArgs e) => e.CurrentContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationUpdatedEventArgs"/>.
    /// </summary>
    public interface IManipulationUpdatedEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(ManipulationUpdatedEventArgs e);

        /// <summary>
        /// Gets the location of the pointer associated with the manipulation for the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(ManipulationUpdatedEventArgs e);

        /// <summary>
        /// Gets values that indicate the changes in the transformation deltas (translation, rotation, scale)
        /// of a manipulation since the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The changes in transformation values since the last event.</returns>
        ManipulationDelta Delta(ManipulationUpdatedEventArgs e);

        /// <summary>
        /// Gets values that indicate the accumulated transformation deltas (translation, rotation, scale)
        /// for a manipulation from the beginning of the interaction to the <see cref="GestureRecognizer.ManipulationUpdated"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The accumulated transformation values up to the ManipulationUpdated event.</returns>
        ManipulationDelta Cumulative(ManipulationUpdatedEventArgs e);

        /// <summary>
        /// Gets values that indicate the velocities of the transformation deltas (translation, rotation, scale)
        /// for a manipulation at the <see cref="GestureRecognizer.ManipulationUpdated"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The velocities of the accumulated transformations since a ManipulationStarted event.</returns>
        ManipulationVelocities Velocities(ManipulationUpdatedEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.ManipulationUpdated"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(ManipulationUpdatedEventArgs e);

        /// <summary>
        /// Gets the current number of contact points for the ongoing <see cref="GestureRecognizer.ManipulationUpdated"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationUpdatedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint CurrentContactCount(ManipulationUpdatedEventArgs e);
    }
}
