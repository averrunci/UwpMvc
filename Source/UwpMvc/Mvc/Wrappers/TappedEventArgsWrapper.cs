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
    /// Provides data of the <see cref="TappedEventArgs"/>
    /// resolved by <see cref="ITappedEventArgsResolver"/>.
    /// </summary>
    public static class TappedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITappedEventArgsResolver"/>
        /// that resolves data of the <see cref="TappedEventArgs"/>.
        /// </summary>
        public static ITappedEventArgsResolver Resolver { get; set; } = new DefaultTappedEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this TappedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the touch, mouse, or pen/stylus contact.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this TappedEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets the number of times the tap interaction was detected.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedEventArgs"/>.</param>
        /// <returns>The total number of taps.</returns>
        public static uint TapCount(this TappedEventArgs e) => Resolver.TapCount(e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.Tapped"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this TappedEventArgs e) => Resolver.ContactCount(e);

        private sealed class DefaultTappedEventArgsResolver : ITappedEventArgsResolver
        {
            PointerDeviceType ITappedEventArgsResolver.PointerDeviceType(TappedEventArgs e) => e.PointerDeviceType;
            Point ITappedEventArgsResolver.Position(TappedEventArgs e) => e.Position;
            uint ITappedEventArgsResolver.TapCount(TappedEventArgs e) => e.TapCount;
            uint ITappedEventArgsResolver.ContactCount(TappedEventArgs e) => e.ContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TappedEventArgs"/>.
    /// </summary>
    public interface ITappedEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(TappedEventArgs e);

        /// <summary>
        /// Gets the location of the touch, mouse, or pen/stylus contact.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(TappedEventArgs e);

        /// <summary>
        /// Gets the number of times the tap interaction was detected.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedEventArgs"/>.</param>
        /// <returns>The total number of taps.</returns>
        uint TapCount(TappedEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.Tapped"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(TappedEventArgs e);
    }
}
