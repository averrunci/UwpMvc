// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Input;
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="Pointer"/>
    /// resolved by <see cref="IPointerResolver"/>.
    /// </summary>
    public static class PointerWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IPointerResolver"/>
        /// that resolves data of the <see cref="Pointer"/>.
        /// </summary>
        public static IPointerResolver Resolver { get; set; } = new DefaultPointerResolver();

        /// <summary>
        /// Gets a value that determines whether the pointer device was in contact with a sensor
        /// or digitizer at the time that the event was reported.
        /// </summary>
        /// <param name="pointer">The requested <see cref="Pointer"/>.</param>
        /// <returns>
        /// <c>true</c> if the pointer device was in contact; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsInContact(this Pointer pointer) => Resolver.IsInContact(pointer);

        /// <summary>
        /// Gets a value that indicates whether the pointer device is within detection range
        /// of a sensor or digitizer.
        /// </summary>
        /// <param name="pointer">The requested <see cref="Pointer"/>.</param>
        /// <returns>
        /// <c>true</c> if touch or pen is within detection range or mouse is over; otherwise <c>false</c>.
        /// </returns>
        public static bool IsInRange(this Pointer pointer) => Resolver.IsInRange(pointer);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device.
        /// </summary>
        /// <param name="pointer">The requested <see cref="Pointer"/>.</param>
        /// <returns>The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this pointer reference.</returns>
        public static PointerDeviceType PointerDeviceType(this Pointer pointer) => Resolver.PointerDeviceType(pointer);

        /// <summary>
        /// Gets the system-generated identifier for this pointer reference.
        /// </summary>
        /// <param name="pointer">The requested <see cref="Pointer"/>.</param>
        /// <returns>The system-generated identifier.</returns>
        public static uint PointerId(this Pointer pointer) => Resolver.PointerId(pointer);

        private sealed class DefaultPointerResolver : IPointerResolver
        {
            bool IPointerResolver.IsInContact(Pointer pointer) => pointer.IsInContact;
            bool IPointerResolver.IsInRange(Pointer pointer) => pointer.IsInRange;
            PointerDeviceType IPointerResolver.PointerDeviceType(Pointer pointer) => pointer.PointerDeviceType;
            uint IPointerResolver.PointerId(Pointer pointer) => pointer.PointerId;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="Pointer"/>.
    /// </summary>
    public interface IPointerResolver
    {
        /// <summary>
        /// Gets a value that determines whether the pointer device was in contact with a sensor
        /// or digitizer at the time that the event was reported.
        /// </summary>
        /// <param name="pointer">The requested <see cref="Pointer"/>.</param>
        /// <returns>
        /// <c>true</c> if the pointer device was in contact; otherwise, <c>false</c>.
        /// </returns>
        bool IsInContact(Pointer pointer);

        /// <summary>
        /// Gets a value that indicates whether the pointer device is within detection range
        /// of a sensor or digitizer.
        /// </summary>
        /// <param name="pointer">The requested <see cref="Pointer"/>.</param>
        /// <returns>
        /// <c>true</c> if touch or pen is within detection range or mouse is over; otherwise <c>false</c>.
        /// </returns>
        bool IsInRange(Pointer pointer);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device.
        /// </summary>
        /// <param name="pointer">The requested <see cref="Pointer"/>.</param>
        /// <returns>The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this pointer reference.</returns>
        PointerDeviceType PointerDeviceType(Pointer pointer);

        /// <summary>
        /// Gets the system-generated identifier for this pointer reference.
        /// </summary>
        /// <param name="pointer">The requested <see cref="Pointer"/>.</param>
        /// <returns>The system-generated identifier.</returns>
        uint PointerId(Pointer pointer);
    }
}
