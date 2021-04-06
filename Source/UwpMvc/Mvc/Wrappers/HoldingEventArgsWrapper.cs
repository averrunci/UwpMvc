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
    /// Provides data of the <see cref="HoldingEventArgs"/>
    /// resolved by <see cref="IHoldingEventArgsResolver"/>.
    /// </summary>
    public static class HoldingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IHoldingEventArgsResolver"/>
        /// that resolves data of the <see cref="HoldingEventArgs"/>.
        /// </summary>
        public static IHoldingEventArgsResolver Resolver { get; set; } = new DefaultHoldingEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this HoldingEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the touch, mouse, or pen/stylus contact.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this HoldingEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets the state of the Holding event.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>State of the Holding event.</returns>
        public static HoldingState HoldingState(this HoldingEventArgs e) => Resolver.HoldingState(e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.Holding"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this HoldingEventArgs e) => Resolver.ContactCount(e);

        /// <summary>
        /// Gets the current number of contact points for the ongoing <see cref="GestureRecognizer.Holding"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint CurrentContactCount(this HoldingEventArgs e) => Resolver.CurrentContactCount(e);

        private sealed class DefaultHoldingEventArgsResolver : IHoldingEventArgsResolver
        {
            PointerDeviceType IHoldingEventArgsResolver.PointerDeviceType(HoldingEventArgs e) => e.PointerDeviceType;
            Point IHoldingEventArgsResolver.Position(HoldingEventArgs e) => e.Position;
            HoldingState IHoldingEventArgsResolver.HoldingState(HoldingEventArgs e) => e.HoldingState;
            uint IHoldingEventArgsResolver.ContactCount(HoldingEventArgs e) => e.ContactCount;
            uint IHoldingEventArgsResolver.CurrentContactCount(HoldingEventArgs e) => e.CurrentContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="HoldingEventArgs"/>.
    /// </summary>
    public interface IHoldingEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(HoldingEventArgs e);

        /// <summary>
        /// Gets the location of the touch, mouse, or pen/stylus contact.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(HoldingEventArgs e);

        /// <summary>
        /// Gets the state of the Holding event.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>State of the Holding event.</returns>
        HoldingState HoldingState(HoldingEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.Holding"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(HoldingEventArgs e);

        /// <summary>
        /// Gets the current number of contact points for the ongoing <see cref="GestureRecognizer.Holding"/> event.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint CurrentContactCount(HoldingEventArgs e);
    }
}
