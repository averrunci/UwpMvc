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
    /// Provides data of the <see cref="RightTappedEventArgs"/>
    /// resolved by <see cref="IRightTappedEventArgsResolver"/>.
    /// </summary>
    public static class RightTappedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IRightTappedEventArgsResolver"/>
        /// that resolves data of the <see cref="RightTappedEventArgs"/>.
        /// </summary>
        public static IRightTappedEventArgsResolver Resolver { get; set; } = new DefaultRightTappedEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this RightTappedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the touch, mouse, or pen/stylus contact.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this RightTappedEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.RightTapped"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this RightTappedEventArgs e) => Resolver.ContactCount(e);

        private sealed class DefaultRightTappedEventArgsResolver : IRightTappedEventArgsResolver
        {
            PointerDeviceType IRightTappedEventArgsResolver.PointerDeviceType(RightTappedEventArgs e) => e.PointerDeviceType;
            Point IRightTappedEventArgsResolver.Position(RightTappedEventArgs e) => e.Position;
            uint IRightTappedEventArgsResolver.ContactCount(RightTappedEventArgs e) => e.ContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="RightTappedEventArgs"/>.
    /// </summary>
    public interface IRightTappedEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(RightTappedEventArgs e);

        /// <summary>
        /// Gets the location of the touch, mouse, or pen/stylus contact.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(RightTappedEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the <see cref="GestureRecognizer.RightTapped"/> event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(RightTappedEventArgs e);
    }
}
