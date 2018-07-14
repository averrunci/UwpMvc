// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.Devices.Input;
using Windows.Foundation;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="PointerDevice"/>
    /// resolved by <see cref="IPointerDeviceResolver"/>.
    /// </summary>
    public static class PointerDeviceWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IPointerDeviceResolver"/>
        /// that resolves data of the <see cref="PointerDevice"/>.
        /// </summary>
        public static IPointerDeviceResolver Resolver { get; set; } = new DefaultPointerDeviceResolver();

        /// <summary>
        /// Gets a value indicating whether th pointer device is an integrated device.
        /// For example, a video display with an integrated touch digitizer compared to
        /// an external pen/stylus digitizer.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>
        /// <c>true</c> if the pointer device is integrated; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsIntegrated(this PointerDevice pointerDevice) => Resolver.IsIntegrated(pointerDevice);

        /// <summary>
        /// Gets a value indicating the maximum number of contacts supported by the input device.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>The number of contacts.</returns>
        public static uint MaxContacts(this PointerDevice pointerDevice) => Resolver.MaxContacts(pointerDevice);

        /// <summary>
        /// Gets the coordinates of the bounding rectangle supported by the input device.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>The bounding rectangle at 96 dpi.</returns>
        public static Rect PhysicalDeviceRect(this PointerDevice pointerDevice) => Resolver.PhysicalDeviceRect(pointerDevice);

        /// <summary>
        /// Gets the pointer device type.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>A pointer device type.</returns>
        public static PointerDeviceType PointerDeviceType(this PointerDevice pointerDevice) => Resolver.PointerDeviceType(pointerDevice);

        /// <summary>
        /// Gets the screen coordinates that are mapped to the bounding rectangle
        /// supported by the input device.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>The screen coordinates, in DIPs.</returns>
        public static Rect ScreenRect(this PointerDevice pointerDevice) => Resolver.ScreenRect(pointerDevice);

        /// <summary>
        /// Gets a collection containing the supported <see cref="PointerDeviceUsage"/>.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>A collection containing the supported pointer device usages.</returns>
        public static IReadOnlyList<PointerDeviceUsage> SupportedUsages(this PointerDevice pointerDevice) => Resolver.SupportedUsages(pointerDevice);

        private sealed class DefaultPointerDeviceResolver : IPointerDeviceResolver
        {
            bool IPointerDeviceResolver.IsIntegrated(PointerDevice pointerDevice) => pointerDevice.IsIntegrated;
            uint IPointerDeviceResolver.MaxContacts(PointerDevice pointerDevice) => pointerDevice.MaxContacts;
            Rect IPointerDeviceResolver.PhysicalDeviceRect(PointerDevice pointerDevice) => pointerDevice.PhysicalDeviceRect;
            PointerDeviceType IPointerDeviceResolver.PointerDeviceType(PointerDevice pointerDevice) => pointerDevice.PointerDeviceType;
            Rect IPointerDeviceResolver.ScreenRect(PointerDevice pointerDevice) => pointerDevice.ScreenRect;
            IReadOnlyList<PointerDeviceUsage> IPointerDeviceResolver.SupportedUsages(PointerDevice pointerDevice) => pointerDevice.SupportedUsages;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="PointerDevice"/>.
    /// </summary>
    public interface IPointerDeviceResolver
    {
        /// <summary>
        /// Gets a value indicating whether th pointer device is an integrated device.
        /// For example, a video display with an integrated touch digitizer compared to
        /// an external pen/stylus digitizer.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>
        /// <c>true</c> if the pointer device is integrated; otherwise, <c>false</c>.
        /// </returns>
        bool IsIntegrated(PointerDevice pointerDevice);

        /// <summary>
        /// Gets a value indicating the maximum number of contacts supported by the input device.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>The number of contacts.</returns>
        uint MaxContacts(PointerDevice pointerDevice);

        /// <summary>
        /// Gets the coordinates of the bounding rectangle supported by the input device.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>The bounding rectangle at 96 dpi.</returns>
        Rect PhysicalDeviceRect(PointerDevice pointerDevice);

        /// <summary>
        /// Gets the pointer device type.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>A pointer device type.</returns>
        PointerDeviceType PointerDeviceType(PointerDevice pointerDevice);

        /// <summary>
        /// Gets the screen coordinates that are mapped to the bounding rectangle
        /// supported by the input device.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>The screen coordinates, in DIPs.</returns>
        Rect ScreenRect(PointerDevice pointerDevice);

        /// <summary>
        /// Gets a collection containing the supported <see cref="PointerDeviceUsage"/>.
        /// </summary>
        /// <param name="pointerDevice">The requested <see cref="PointerDevice"/>.</param>
        /// <returns>A collection containing the supported pointer device usages.</returns>
        IReadOnlyList<PointerDeviceUsage> SupportedUsages(PointerDevice pointerDevice);
    }
}
