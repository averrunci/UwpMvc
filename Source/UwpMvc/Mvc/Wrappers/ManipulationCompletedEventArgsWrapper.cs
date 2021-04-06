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
    /// Provides data of the <see cref="ManipulationCompletedEventArgs"/>
    /// resolved by <see cref="IManipulationCompletedEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationCompletedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationCompletedEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationCompletedEventArgs"/>.
        /// </summary>
        public static IManipulationCompletedEventArgsResolver Resolver { get; set; } = new DefaultManipulationCompletedEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this ManipulationCompletedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the pointer associated with the manipulation for the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this ManipulationCompletedEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets values that indicate the accumulated transformation deltas (translation, rotation, scale)
        /// of a completed manipulation (from the start of the manipulation to the end of inertia).
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The accumulated transformation values since a ManipulationStarted event.</returns>
        public static ManipulationDelta Cumulative(this ManipulationCompletedEventArgs e) => Resolver.Cumulative(e);

        /// <summary>
        /// Gets values that indicate the velocities of the transformation deltas (translation, rotation, scale)
        /// for a manipulation at the <see cref="GestureRecognizer.ManipulationCompleted"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The velocities of the accumulated transformations since a ManipulationStarted event.</returns>
        public static ManipulationVelocities Velocities(this ManipulationCompletedEventArgs e) => Resolver.Velocities(e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.ManipulationCompleted"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this ManipulationCompletedEventArgs e) => Resolver.ContactCount(e);

        /// <summary>
        /// Gets the current number of contact points for the ongoing <see cref="GestureRecognizer.ManipulationCompleted"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint CurrentContactCount(this ManipulationCompletedEventArgs e) => Resolver.CurrentContactCount(e);

        private sealed class DefaultManipulationCompletedEventArgsResolver : IManipulationCompletedEventArgsResolver
        {
            PointerDeviceType IManipulationCompletedEventArgsResolver.PointerDeviceType(ManipulationCompletedEventArgs e) => e.PointerDeviceType;
            Point IManipulationCompletedEventArgsResolver.Position(ManipulationCompletedEventArgs e) => e.Position;
            ManipulationDelta IManipulationCompletedEventArgsResolver.Cumulative(ManipulationCompletedEventArgs e) => e.Cumulative;
            ManipulationVelocities IManipulationCompletedEventArgsResolver.Velocities(ManipulationCompletedEventArgs e) => e.Velocities;
            uint IManipulationCompletedEventArgsResolver.ContactCount(ManipulationCompletedEventArgs e) => e.ContactCount;
            uint IManipulationCompletedEventArgsResolver.CurrentContactCount(ManipulationCompletedEventArgs e) => e.CurrentContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationCompletedEventArgs"/>.
    /// </summary>
    public interface IManipulationCompletedEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(ManipulationCompletedEventArgs e);

        /// <summary>
        /// Gets the location of the pointer associated with the manipulation for the last manipulation event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(ManipulationCompletedEventArgs e);

        /// <summary>
        /// Gets values that indicate the accumulated transformation deltas (translation, rotation, scale)
        /// of a completed manipulation (from the start of the manipulation to the end of inertia).
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The accumulated transformation values since a ManipulationStarted event.</returns>
        ManipulationDelta Cumulative(ManipulationCompletedEventArgs e);

        /// <summary>
        /// Gets values that indicate the velocities of the transformation deltas (translation, rotation, scale)
        /// for a manipulation at the <see cref="GestureRecognizer.ManipulationCompleted"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The velocities of the accumulated transformations since a ManipulationStarted event.</returns>
        ManipulationVelocities Velocities(ManipulationCompletedEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.ManipulationCompleted"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(ManipulationCompletedEventArgs e);

        /// <summary>
        /// Gets the current number of contact points for the ongoing <see cref="GestureRecognizer.ManipulationCompleted"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint CurrentContactCount(ManipulationCompletedEventArgs e);
    }
}
