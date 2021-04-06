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
    /// Provides data of the <see cref="ManipulationInertiaStartingEventArgs"/>
    /// resolved by <see cref="IManipulationInertiaStartingEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationInertiaStartingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationInertiaStartingEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationInertiaStartingEventArgs"/>.
        /// </summary>
        public static IManipulationInertiaStartingEventArgsResolver Resolver { get; set; } = new DefaultManipulationInertiaStartingEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this ManipulationInertiaStartingEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the pointer associated with the manipulation for the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this ManipulationInertiaStartingEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets values that indicate the changes in the transformation deltas (translation, rotation, scale)
        /// of a manipulation since the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The changes in transformation values since the last event.</returns>
        public static ManipulationDelta Delta(this ManipulationInertiaStartingEventArgs e) => Resolver.Delta(e);

        /// <summary>
        /// Gets values that indicate the accumulated transformation deltas (translation, rotation, scale)
        /// for a manipulation before inertia begins.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The accumulated transformation values up to the ManipulationInertiaStarting event.</returns>
        public static ManipulationDelta Cumulative(this ManipulationInertiaStartingEventArgs e) => Resolver.Cumulative(e);

        /// <summary>
        /// Gets values that indicate the velocities of the transformation deltas (translation, rotation, scale)
        /// for a manipulation at the <see cref="GestureRecognizer.ManipulationInertiaStarting"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// 
        /// <returns>The velocities of the transformations before inertia begins.</returns>
        public static ManipulationVelocities Velocities(this ManipulationInertiaStartingEventArgs e) => Resolver.Velocities(e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.ManipulationInertiaStarting"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this ManipulationInertiaStartingEventArgs e) => Resolver.ContactCount(e);

        private sealed class DefaultManipulationInertiaStartingEventArgsResolver : IManipulationInertiaStartingEventArgsResolver
        {
            PointerDeviceType IManipulationInertiaStartingEventArgsResolver.PointerDeviceType(ManipulationInertiaStartingEventArgs e) => e.PointerDeviceType;
            Point IManipulationInertiaStartingEventArgsResolver.Position(ManipulationInertiaStartingEventArgs e) => e.Position;
            ManipulationDelta IManipulationInertiaStartingEventArgsResolver.Delta(ManipulationInertiaStartingEventArgs e) => e.Delta;
            ManipulationDelta IManipulationInertiaStartingEventArgsResolver.Cumulative(ManipulationInertiaStartingEventArgs e) => e.Cumulative;
            ManipulationVelocities IManipulationInertiaStartingEventArgsResolver.Velocities(ManipulationInertiaStartingEventArgs e) => e.Velocities;
            uint IManipulationInertiaStartingEventArgsResolver.ContactCount(ManipulationInertiaStartingEventArgs e) => e.ContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationInertiaStartingEventArgs"/>.
    /// </summary>
    public interface IManipulationInertiaStartingEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(ManipulationInertiaStartingEventArgs e);

        /// <summary>
        /// Gets the location of the pointer associated with the manipulation for the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(ManipulationInertiaStartingEventArgs e);

        /// <summary>
        /// Gets values that indicate the changes in the transformation deltas (translation, rotation, scale)
        /// of a manipulation since the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The changes in transformation values since the last event.</returns>
        ManipulationDelta Delta(ManipulationInertiaStartingEventArgs e);

        /// <summary>
        /// Gets values that indicate the accumulated transformation deltas (translation, rotation, scale)
        /// for a manipulation before inertia begins.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The accumulated transformation values up to the ManipulationInertiaStarting event.</returns>
        ManipulationDelta Cumulative(ManipulationInertiaStartingEventArgs e);

        /// <summary>
        /// Gets values that indicate the velocities of the transformation deltas (translation, rotation, scale)
        /// for a manipulation at the <see cref="GestureRecognizer.ManipulationInertiaStarting"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// 
        /// <returns>The velocities of the transformations before inertia begins.</returns>
        ManipulationVelocities Velocities(ManipulationInertiaStartingEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.ManipulationInertiaStarting"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(ManipulationInertiaStartingEventArgs e);
    }
}
