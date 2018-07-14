// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="PointerPointProperties"/>
    /// resolved by <see cref="IPointerPointPropertiesResolver"/>.
    /// </summary>
    public static class PointerPointPropertiesWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IPointerPointPropertiesResolver"/>
        /// that resolves data of the <see cref="PointerPointProperties"/>.
        /// </summary>
        public static IPointerPointPropertiesResolver Resolver { get; set; } = new DefaultPointerPointPropertiesResolver();

        /// <summary>
        /// Gets the bounding rectangle of the contact area (typically from touch input).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The bounding rectangle of the contact area, using client window coordinates in
        /// device-independent pixels (DIPs).
        /// </returns>
        public static Rect ContactRect(this PointerPointProperties properties) => Resolver.ContactRect(properties);

        /// <summary>
        /// Gets the bounding rectangle of the raw input (typically from touch input).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The bounding rectangle of the raw input, in device-independent pixels (DIPs).
        /// </returns>
        public static Rect ContactRectRaw(this PointerPointProperties properties) => Resolver.ContactRectRaw(properties);

        /// <summary>
        /// Gets a value that indicates whether the barrel button of the pen/stylus device is pressed.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the barrel button is pressed; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsBarrelButtonPressed(this PointerPointProperties properties) => Resolver.IsBarrelButtonPressed(properties);

        /// <summary>
        /// Gets a value that indicates whether the input was canceled by the pointer device.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the input was canceled; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsCanceled(this PointerPointProperties properties) => Resolver.IsCanceled(properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from a digitizer eraser.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the input is from a digitizer eraser; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEraser(this PointerPointProperties properties) => Resolver.IsEraser(properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from a mouse tilt wheel.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the input is from a mouse tilt wheel; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsHorizontalMouseWheel(this PointerPointProperties properties) => Resolver.IsHorizontalMouseWheel(properties);

        /// <summary>
        /// Gets a value that indicates whether the pointer device is within detection range
        /// of a sensor or digitizer.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if touch or pen is within detection range or mouse is over; otherwise <c>false</c>.
        /// </returns>
        public static bool IsInRange(this PointerPointProperties properties) => Resolver.IsInRange(properties);

        /// <summary>
        /// Gets a value that indicates whether the digitizer pen is inverted.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if inverted; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsInverted(this PointerPointProperties properties) => Resolver.IsInverted(properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from the left button of a mouse
        /// or other input method.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the left button is pressed; otherwise <c>false</c>.
        /// </returns>
        public static bool IsLeftButtonPressed(this PointerPointProperties properties) => Resolver.IsLeftButtonPressed(properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from the middle button of a mouse
        /// or other input method.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the middle button is pressed; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsMiddleButtonPressed(this PointerPointProperties properties) => Resolver.IsMiddleButtonPressed(properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from the primary pointer when multiple
        /// pointers are registered.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the input is from the pointer designated as primary; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsPrimary(this PointerPointProperties properties) => Resolver.IsPrimary(properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from the right button of a mouse
        /// or other input method.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the right button is pressed; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsRightButtonPressed(this PointerPointProperties properties) => Resolver.IsRightButtonPressed(properties);

        /// <summary>
        /// Gets the pressed state of the first extended mouse button.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the first extended button is pressed; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsXButton1Pressed(this PointerPointProperties properties) => Resolver.IsXButton1Pressed(properties);

        /// <summary>
        /// Gets the pressed state of the second extended mouse button.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the second extended button is pressed; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsXButton2Pressed(this PointerPointProperties properties) => Resolver.IsXButton2Pressed(properties);

        /// <summary>
        /// Gets a value (the raw value reported by the deivce) that indicates the change in wheel button
        /// input from the last pointer event.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The number of notches or distance thresholds crossed since the last pointer event.
        /// </returns>
        public static int MouseWheelDelta(this PointerPointProperties properties) => Resolver.MouseWheelDelta(properties);

        /// <summary>
        /// Gets the counter-clockwise angle of rotation around the major axis of the pointer device
        /// (the z-axis, perpendicular to the surface of the digitizer).
        /// A value of 0.0 degrees indicates the device is oriented towards the top of the digitizer.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>A value between 0.0 and 359.0 in degrees of rotation.</returns>
        public static float Orientation(this PointerPointProperties properties) => Resolver.Orientation(properties);

        /// <summary>
        /// Gets the kind of pointer state change.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>One of the values from <see cref="global::Windows.UI.Input.PointerUpdateKind"/>.</returns>
        public static PointerUpdateKind PointerUpdateKind(this PointerPointProperties properties) => Resolver.PointerUpdateKind(properties);

        /// <summary>
        /// Gets a value that indicates the force that the pointer device (typically a pen/stylus)
        /// exerts on the surface of the digitizer.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>A value from 0.0 to 1.0.</returns>
        public static float Pressure(this PointerPointProperties properties) => Resolver.Pressure(properties);

        /// <summary>
        /// Gets a value that indicates whether the pointer device rejected the touch contact.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the touch contact was accepted; otherwise, <c>false</c>.
        /// </returns>
        public static bool TouchConfidence(this PointerPointProperties properties) => Resolver.TouchConfidence(properties);

        /// <summary>
        /// Gets the clockwise rotation in degrees of a pen device around its own major axis
        /// (such as when the user spins the pen in their fingers).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>A value between 0.0 and 359.0 in degrees of rotation.</returns>
        public static float Twist(this PointerPointProperties properties) => Resolver.Twist(properties);

        /// <summary>
        /// Gets the plane angle between the Y-Z plane and the plane that contains the Y axis and
        /// the axis of the input device (typically a pen/stylus).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The value is 0.0 when the finger or pen is perpendicular to the digitizer surface,
        /// between 0.0 and 90.0 when tilted to the right of perpendicular, and between 0.0 and
        /// -90.0 when tilted to the left of perpendicular.
        /// </returns>
        public static float XTilt(this PointerPointProperties properties) => Resolver.XTilt(properties);

        /// <summary>
        /// Gets the plane angle between the X-Z plane and the plane that contains the X axis and
        /// the axis of the input device (typically a pen/ stylus).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The value is 0.0 when the finger or pen is perpendicular to the digitizer surface,
        /// between 0.0 and -90.0 when tilted towards the user, and between 0.0 and 90.0 when
        /// tilted away from the user.
        /// </returns>
        public static float YTilt(this PointerPointProperties properties) => Resolver.YTilt(properties);

        /// <summary>
        /// Gets the z-coordinate (or distance) of the pointer from the screen surface,
        /// in device-independent pixels.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The z-coordinate (or distance) of the pointer from the screen surface, in device-independent pixels.
        /// </returns>
        public static float? ZDistance(this PointerPointProperties properties) => Resolver.ZDistance(properties);

        /// <summary>
        /// Gets the Human Interface Device (HID) usage value of the raw input.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <param name="usagePage">
        /// The HID usage page of the pointer device.
        /// Usage pages specify the class of device. For example, touch digitizers (0x0D) and
        /// generic input (0x01).
        /// </param>
        /// <param name="usageId">
        /// Indicates a usage in a usage page.
        /// Usage IDs specify a device or property in the <paramref name="usagePage"/>.
        /// For example, for touch digitizers this includes tip switch (0x42) to indicate
        /// finger contact or tip pressure (0x30).
        /// </param>
        /// <returns>The extended usage of the raw input pointer.</returns>
        public static int GetUsageValueWrapped(PointerPointProperties properties, uint usagePage, uint usageId) => Resolver.GetUsageValue(properties, usagePage, usageId);

        /// <summary>
        /// Gets a value that indicates whether the input data from the pointer device contains
        /// the specified Human Interface Device (HID) usage information.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <param name="usagePage">
        /// The HID usage page of the pointer device.
        /// Usage pages specify the class of device. For example, touch digitizer (0x0D) and
        /// generic input (0x01).
        /// </param>
        /// <param name="usageId">
        /// Indicates a usage in a usage page.
        /// UsageIDs specify a device or property in the <paramref name="usagePage"/>.
        /// For example, for touch digitizers this includes tip switch (0x42) to indicate
        /// finger contact or tip pressure (0x30).
        /// </param>
        /// <returns>
        /// <c>true</c> if the input data includes usage information; otherwise, <c>false</c>.
        /// </returns>
        public static bool HasUsageWrapped(PointerPointProperties properties, uint usagePage, uint usageId) => Resolver.HasUsage(properties, usagePage, usageId);

        private sealed class DefaultPointerPointPropertiesResolver : IPointerPointPropertiesResolver
        {
            Rect IPointerPointPropertiesResolver.ContactRect(PointerPointProperties properties) => properties.ContactRect;
            Rect IPointerPointPropertiesResolver.ContactRectRaw(PointerPointProperties properties) => properties.ContactRectRaw;
            bool IPointerPointPropertiesResolver.IsBarrelButtonPressed(PointerPointProperties properties) => properties.IsBarrelButtonPressed;
            bool IPointerPointPropertiesResolver.IsCanceled(PointerPointProperties properties) => properties.IsCanceled;
            bool IPointerPointPropertiesResolver.IsEraser(PointerPointProperties properties) => properties.IsEraser;
            bool IPointerPointPropertiesResolver.IsHorizontalMouseWheel(PointerPointProperties properties) => properties.IsHorizontalMouseWheel;
            bool IPointerPointPropertiesResolver.IsInRange(PointerPointProperties properties) => properties.IsInRange;
            bool IPointerPointPropertiesResolver.IsInverted(PointerPointProperties properties) => properties.IsInverted;
            bool IPointerPointPropertiesResolver.IsLeftButtonPressed(PointerPointProperties properties) => properties.IsLeftButtonPressed;
            bool IPointerPointPropertiesResolver.IsMiddleButtonPressed(PointerPointProperties properties) => properties.IsMiddleButtonPressed;
            bool IPointerPointPropertiesResolver.IsPrimary(PointerPointProperties properties) => properties.IsPrimary;
            bool IPointerPointPropertiesResolver.IsRightButtonPressed(PointerPointProperties properties) => properties.IsRightButtonPressed;
            bool IPointerPointPropertiesResolver.IsXButton1Pressed(PointerPointProperties properties) => properties.IsXButton1Pressed;
            bool IPointerPointPropertiesResolver.IsXButton2Pressed(PointerPointProperties properties) => properties.IsXButton2Pressed;
            int IPointerPointPropertiesResolver.MouseWheelDelta(PointerPointProperties properties) => properties.MouseWheelDelta;
            float IPointerPointPropertiesResolver.Orientation(PointerPointProperties properties) => properties.Orientation;
            PointerUpdateKind IPointerPointPropertiesResolver.PointerUpdateKind(PointerPointProperties properties) => properties.PointerUpdateKind;
            float IPointerPointPropertiesResolver.Pressure(PointerPointProperties properties) => properties.Pressure;
            bool IPointerPointPropertiesResolver.TouchConfidence(PointerPointProperties properties) => properties.TouchConfidence;
            float IPointerPointPropertiesResolver.Twist(PointerPointProperties properties) => properties.Twist;
            float IPointerPointPropertiesResolver.XTilt(PointerPointProperties properties) => properties.XTilt;
            float IPointerPointPropertiesResolver.YTilt(PointerPointProperties properties) => properties.YTilt;
            float? IPointerPointPropertiesResolver.ZDistance(PointerPointProperties properties) => properties.ZDistance;
            int IPointerPointPropertiesResolver.GetUsageValue(PointerPointProperties properties, uint usagePage, uint usageId) => properties.GetUsageValue(usagePage, usageId);
            bool IPointerPointPropertiesResolver.HasUsage(PointerPointProperties properties, uint usagePage, uint usageId) => properties.HasUsage(usagePage, usageId);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="PointerPointProperties"/>.
    /// </summary>
    public interface IPointerPointPropertiesResolver
    {
        /// <summary>
        /// Gets the bounding rectangle of the contact area (typically from touch input).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The bounding rectangle of the contact area, using client window coordinates in
        /// device-independent pixels (DIPs).
        /// </returns>
        Rect ContactRect(PointerPointProperties properties);

        /// <summary>
        /// Gets the bounding rectangle of the raw input (typically from touch input).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The bounding rectangle of the raw input, in device-independent pixels (DIPs).
        /// </returns>
        Rect ContactRectRaw(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the barrel button of the pen/stylus device is pressed.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the barrel button is pressed; otherwise, <c>false</c>.
        /// </returns>
        bool IsBarrelButtonPressed(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the input was canceled by the pointer device.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the input was canceled; otherwise, <c>false</c>.
        /// </returns>
        bool IsCanceled(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from a digitizer eraser.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the input is from a digitizer eraser; otherwise, <c>false</c>.
        /// </returns>
        bool IsEraser(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from a mouse tilt wheel.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the input is from a mouse tilt wheel; otherwise, <c>false</c>.
        /// </returns>
        bool IsHorizontalMouseWheel(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the pointer device is within detection range
        /// of a sensor or digitizer.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if touch or pen is within detection range or mouse is over; otherwise <c>false</c>.
        /// </returns>
        bool IsInRange(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the digitizer pen is inverted.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if inverted; otherwise, <c>false</c>.
        /// </returns>
        bool IsInverted(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from the left button of a mouse
        /// or other input method.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the left button is pressed; otherwise <c>false</c>.
        /// </returns>
        bool IsLeftButtonPressed(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from the middle button of a mouse
        /// or other input method.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the middle button is pressed; otherwise, <c>false</c>.
        /// </returns>
        bool IsMiddleButtonPressed(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from the primary pointer when multiple
        /// pointers are registered.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the input is from the pointer designated as primary; otherwise, <c>false</c>.
        /// </returns>
        bool IsPrimary(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the input is from the right button of a mouse
        /// or other input method.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the right button is pressed; otherwise, <c>false</c>.
        /// </returns>
        bool IsRightButtonPressed(PointerPointProperties properties);

        /// <summary>
        /// Gets the pressed state of the first extended mouse button.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the first extended button is pressed; otherwise, <c>false</c>.
        /// </returns>
        bool IsXButton1Pressed(PointerPointProperties properties);

        /// <summary>
        /// Gets the pressed state of the second extended mouse button.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the second extended button is pressed; otherwise, <c>false</c>.
        /// </returns>
        bool IsXButton2Pressed(PointerPointProperties properties);

        /// <summary>
        /// Gets a value (the raw value reported by the deivce) that indicates the change in wheel button
        /// input from the last pointer event.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The number of notches or distance thresholds crossed since the last pointer event.
        /// </returns>
        int MouseWheelDelta(PointerPointProperties properties);

        /// <summary>
        /// Gets the counter-clockwise angle of rotation around the major axis of the pointer device
        /// (the z-axis, perpendicular to the surface of the digitizer).
        /// A value of 0.0 degrees indicates the device is oriented towards the top of the digitizer.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>A value between 0.0 and 359.0 in degrees of rotation.</returns>
        float Orientation(PointerPointProperties properties);

        /// <summary>
        /// Gets the kind of pointer state change.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>One of the values from <see cref="global::Windows.UI.Input.PointerUpdateKind"/>.</returns>
        PointerUpdateKind PointerUpdateKind(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates the force that the pointer device (typically a pen/stylus)
        /// exerts on the surface of the digitizer.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>A value from 0.0 to 1.0.</returns>
        float Pressure(PointerPointProperties properties);

        /// <summary>
        /// Gets a value that indicates whether the pointer device rejected the touch contact.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// <c>true</c> if the touch contact was accepted; otherwise, <c>false</c>.
        /// </returns>
        bool TouchConfidence(PointerPointProperties properties);

        /// <summary>
        /// Gets the clockwise rotation in degrees of a pen device around its own major axis
        /// (such as when the user spins the pen in their fingers).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>A value between 0.0 and 359.0 in degrees of rotation.</returns>
        float Twist(PointerPointProperties properties);

        /// <summary>
        /// Gets the plane angle between the Y-Z plane and the plane that contains the Y axis and
        /// the axis of the input device (typically a pen/stylus).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The value is 0.0 when the finger or pen is perpendicular to the digitizer surface,
        /// between 0.0 and 90.0 when tilted to the right of perpendicular, and between 0.0 and
        /// -90.0 when tilted to the left of perpendicular.
        /// </returns>
        float XTilt(PointerPointProperties properties);

        /// <summary>
        /// Gets the plane angle between the X-Z plane and the plane that contains the X axis and
        /// the axis of the input device (typically a pen/ stylus).
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The value is 0.0 when the finger or pen is perpendicular to the digitizer surface,
        /// between 0.0 and -90.0 when tilted towards the user, and between 0.0 and 90.0 when
        /// tilted away from the user.
        /// </returns>
        float YTilt(PointerPointProperties properties);

        /// <summary>
        /// Gets the z-coordinate (or distance) of the pointer from the screen surface,
        /// in device-independent pixels.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <returns>
        /// The z-coordinate (or distance) of the pointer from the screen surface, in device-independent pixels.
        /// </returns>
        float? ZDistance(PointerPointProperties properties);

        /// <summary>
        /// Gets the Human Interface Device (HID) usage value of the raw input.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <param name="usagePage">
        /// The HID usage page of the pointer device.
        /// Usage pages specify the class of device. For example, touch digitizers (0x0D) and
        /// generic input (0x01).
        /// </param>
        /// <param name="usageId">
        /// Indicates a usage in a usage page.
        /// Usage IDs specify a device or property in the <paramref name="usagePage"/>.
        /// For example, for touch digitizers this includes tip switch (0x42) to indicate
        /// finger contact or tip pressure (0x30).
        /// </param>
        /// <returns>The extended usage of the raw input pointer.</returns>
        int GetUsageValue(PointerPointProperties properties, uint usagePage, uint usageId);

        /// <summary>
        /// Gets a value that indicates whether the input data from the pointer device contains
        /// the specified Human Interface Device (HID) usage information.
        /// </summary>
        /// <param name="properties">The requested <see cref="PointerPointProperties"/>.</param>
        /// <param name="usagePage">
        /// The HID usage page of the pointer device.
        /// Usage pages specify the class of device. For example, touch digitizer (0x0D) and
        /// generic input (0x01).
        /// </param>
        /// <param name="usageId">
        /// Indicates a usage in a usage page.
        /// UsageIDs specify a device or property in the <paramref name="usagePage"/>.
        /// For example, for touch digitizers this includes tip switch (0x42) to indicate
        /// finger contact or tip pressure (0x30).
        /// </param>
        /// <returns>
        /// <c>true</c> if the input data includes usage information; otherwise, <c>false</c>.
        /// </returns>
        bool HasUsage(PointerPointProperties properties, uint usagePage, uint usageId);
    }
}
