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
    /// Provides data of the <see cref="CrossSlidingEventArgs"/>
    /// resolved by <see cref="ICrossSlidingEventArgsResolver"/>.
    /// </summary>
    public static class CrossSlidingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ICrossSlidingEventArgsResolver"/>
        /// that resolves data of the <see cref="CrossSlidingEventArgs"/>.
        /// </summary>
        public static ICrossSlidingEventArgsResolver Resolver { get; set; } = new DefaultCrossSlidingEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="CrossSlidingEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this CrossSlidingEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the touch contact.
        /// </summary>
        /// <param name="e">The requested <see cref="CrossSlidingEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this CrossSlidingEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets the state of the CrossSliding event.
        /// </summary>
        /// <param name="e">The requested <see cref="CrossSlidingEventArgs"/>.</param>
        /// <returns>State of the CrossSliding event.</returns>
        public static CrossSlidingState CrossSlidingState(this CrossSlidingEventArgs e) => Resolver.CrossSlidingState(e);

        /// <summary>
        /// Gets the number of contact points at the time the CrossSliding event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="CrossSlidingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this CrossSlidingEventArgs e) => Resolver.ContactCount(e);

        private sealed class DefaultCrossSlidingEventArgsResolver : ICrossSlidingEventArgsResolver
        {
            PointerDeviceType ICrossSlidingEventArgsResolver.PointerDeviceType(CrossSlidingEventArgs e) => e.PointerDeviceType;
            Point ICrossSlidingEventArgsResolver.Position(CrossSlidingEventArgs e) => e.Position;
            CrossSlidingState ICrossSlidingEventArgsResolver.CrossSlidingState(CrossSlidingEventArgs e) => e.CrossSlidingState;
            uint ICrossSlidingEventArgsResolver.ContactCount(CrossSlidingEventArgs e) => e.ContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="CrossSlidingEventArgs"/>.
    /// </summary>
    public interface ICrossSlidingEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="CrossSlidingEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(CrossSlidingEventArgs e);

        /// <summary>
        /// Gets the location of the touch contact.
        /// </summary>
        /// <param name="e">The requested <see cref="CrossSlidingEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(CrossSlidingEventArgs e);

        /// <summary>
        /// Gets the state of the CrossSliding event.
        /// </summary>
        /// <param name="e">The requested <see cref="CrossSlidingEventArgs"/>.</param>
        /// <returns>State of the CrossSliding event.</returns>
        CrossSlidingState CrossSlidingState(CrossSlidingEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the CrossSliding event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="CrossSlidingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(CrossSlidingEventArgs e);
    }
}
