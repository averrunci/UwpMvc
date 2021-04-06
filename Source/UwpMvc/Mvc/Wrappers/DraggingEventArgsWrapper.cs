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
    /// Provides data of the <see cref="DraggingEventArgs"/>
    /// resolved by <see cref="IDraggingEventArgsResolver"/>.
    /// </summary>
    public static class DraggingEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDraggingEventArgsResolver"/>
        /// that resolves data of the <see cref="DraggingEventArgs"/>.
        /// </summary>
        public static IDraggingEventArgsResolver Resolver { get; set; } = new DefaultDraggingEventArgsResolver();

        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="DraggingEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        public static PointerDeviceType PointerDeviceType(this DraggingEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the location of the mouse or pen/stylus contact.
        /// </summary>
        /// <param name="e">The requested <see cref="DraggingEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        public static Point Position(this DraggingEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets the state of the Dragging event.
        /// </summary>
        /// <param name="e">The requested <see cref="DraggingEventArgs"/>.</param>
        /// <returns>State of the Dragging event.</returns>
        public static DraggingState DraggingState(this DraggingEventArgs e) => Resolver.DraggingState(e);

        /// <summary>
        /// Gets the number of contact points at the time the Dragging event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="DraggingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        public static uint ContactCount(this DraggingEventArgs e) => Resolver.ContactCount(e);

        private sealed class DefaultDraggingEventArgsResolver : IDraggingEventArgsResolver
        {
            PointerDeviceType IDraggingEventArgsResolver.PointerDeviceType(DraggingEventArgs e) => e.PointerDeviceType;
            Point IDraggingEventArgsResolver.Position(DraggingEventArgs e) => e.Position;
            DraggingState IDraggingEventArgsResolver.DraggingState(DraggingEventArgs e) => e.DraggingState;
            uint IDraggingEventArgsResolver.ContactCount(DraggingEventArgs e) => e.ContactCount;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DraggingEventArgs"/>.
    /// </summary>
    public interface IDraggingEventArgsResolver
    {
        /// <summary>
        /// Gets the device type of the input source.
        /// </summary>
        /// <param name="e">The requested <see cref="DraggingEventArgs"/>.</param>
        /// <returns>The device type.</returns>
        PointerDeviceType PointerDeviceType(DraggingEventArgs e);

        /// <summary>
        /// Gets the location of the mouse or pen/stylus contact.
        /// </summary>
        /// <param name="e">The requested <see cref="DraggingEventArgs"/>.</param>
        /// <returns>The screen coordinates, in device-independent pixel (DIP).</returns>
        Point Position(DraggingEventArgs e);

        /// <summary>
        /// Gets the state of the Dragging event.
        /// </summary>
        /// <param name="e">The requested <see cref="DraggingEventArgs"/>.</param>
        /// <returns>State of the Dragging event.</returns>
        DraggingState DraggingState(DraggingEventArgs e);

        /// <summary>
        /// Gets the number of contact points at the time the Dragging event is recognized.
        /// </summary>
        /// <param name="e">The requested <see cref="DraggingEventArgs"/>.</param>
        /// <returns>The number of contact points.</returns>
        uint ContactCount(DraggingEventArgs e);
    }
}
