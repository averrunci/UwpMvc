// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.UI.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="PointerPoint"/>
    /// resolved by <see cref="IPointerPointResolver"/>.
    /// </summary>
    public static class PointerPointWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IPointerPointResolver"/>
        /// that resolves data of the <see cref="PointerPoint"/>.
        /// </summary>
        public static IPointerPointResolver Resolver { get; set; } = new DefaultPointerPointResolver();

        /// <summary>
        /// Gets the ID of an input frame.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The frame ID.</returns>
        public static uint FrameId(this PointerPoint pointerPoint) => Resolver.FrameId(pointerPoint);

        /// <summary>
        /// Gets a value that indicates whether the physical entity (touch, pen/stylus, or mouse button)
        /// is pressed down.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>
        /// <c>true</c> if pressed down; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsInContact(this PointerPoint pointerPoint) => Resolver.IsInContact(pointerPoint);

        /// <summary>
        /// Gets information about the device associated with the input pointer.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The input device.</returns>
        public static PointerDevice PointerDevice(this PointerPoint pointerPoint) => Resolver.PointerDevice(pointerPoint);

        /// <summary>
        /// Gets a unique identifier for the input pointer.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>A unique value that identifiers the input pointer.</returns>
        public static uint PointerId(this PointerPoint pointerPoint) => Resolver.PointerId(pointerPoint);

        /// <summary>
        /// Gets the location of the pointer input in client coordinates.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The client coordinates, in device-independent pixels (DIPs).</returns>
        public static Point Position(this PointerPoint pointerPoint) => Resolver.Position(pointerPoint);

        /// <summary>
        /// Gets extended information about the input pointer.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The extended properties exposed by the input device.</returns>
        public static PointerPointProperties Properties(this PointerPoint pointerPoint) => Resolver.Properties(pointerPoint);

        /// <summary>
        /// Gets the raw location of the pointer input in client coordinates.
        /// </summary>
        /// <param name="pointerPoint">The request <see cref="PointerPoint"/>.</param>
        /// <returns>The client coordinates, in device-independent pixels (DIPs).</returns>
        public static Point RawPosition(this PointerPoint pointerPoint) => Resolver.RawPosition(pointerPoint);

        /// <summary>
        /// Gets the time when the input occurred.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The time, relative to the system boot time, in microseconds.</returns>
        public static ulong Timestamp(this PointerPoint pointerPoint) => Resolver.Timestamp(pointerPoint);

        private sealed class DefaultPointerPointResolver : IPointerPointResolver
        {
            uint IPointerPointResolver.FrameId(PointerPoint pointerPoint) => pointerPoint.FrameId;
            bool IPointerPointResolver.IsInContact(PointerPoint pointerPoint) => pointerPoint.IsInContact;
            PointerDevice IPointerPointResolver.PointerDevice(PointerPoint pointerPoint) => pointerPoint.PointerDevice;
            uint IPointerPointResolver.PointerId(PointerPoint pointerPoint) => pointerPoint.PointerId;
            Point IPointerPointResolver.Position(PointerPoint pointerPoint) => pointerPoint.Position;
            PointerPointProperties IPointerPointResolver.Properties(PointerPoint pointerPoint) => pointerPoint.Properties;
            Point IPointerPointResolver.RawPosition(PointerPoint pointerPoint) => pointerPoint.RawPosition;
            ulong IPointerPointResolver.Timestamp(PointerPoint pointerPoint) => pointerPoint.Timestamp;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="PointerPoint"/>.
    /// </summary>
    public interface IPointerPointResolver
    {
        /// <summary>
        /// Gets the ID of an input frame.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The frame ID.</returns>
        uint FrameId(PointerPoint pointerPoint);

        /// <summary>
        /// Gets a value that indicates whether the physical entity (touch, pen/stylus, or mouse button)
        /// is pressed down.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>
        /// <c>true</c> if pressed down; otherwise, <c>false</c>.
        /// </returns>
        bool IsInContact(PointerPoint pointerPoint);

        /// <summary>
        /// Gets information about the device associated with the input pointer.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The input device.</returns>
        PointerDevice PointerDevice(PointerPoint pointerPoint);

        /// <summary>
        /// Gets a unique identifier for the input pointer.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>A unique value that identifiers the input pointer.</returns>
        uint PointerId(PointerPoint pointerPoint);

        /// <summary>
        /// Gets the location of the pointer input in client coordinates.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The client coordinates, in device-independent pixels (DIPs).</returns>
        Point Position(PointerPoint pointerPoint);

        /// <summary>
        /// Gets extended information about the input pointer.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The extended properties exposed by the input device.</returns>
        PointerPointProperties Properties(PointerPoint pointerPoint);

        /// <summary>
        /// Gets the raw location of the pointer input in client coordinates.
        /// </summary>
        /// <param name="pointerPoint">The request <see cref="PointerPoint"/>.</param>
        /// <returns>The client coordinates, in device-independent pixels (DIPs).</returns>
        Point RawPosition(PointerPoint pointerPoint);

        /// <summary>
        /// Gets the time when the input occurred.
        /// </summary>
        /// <param name="pointerPoint">The requested <see cref="PointerPoint"/>.</param>
        /// <returns>The time, relative to the system boot time, in microseconds.</returns>
        ulong Timestamp(PointerPoint pointerPoint);
    }
}
