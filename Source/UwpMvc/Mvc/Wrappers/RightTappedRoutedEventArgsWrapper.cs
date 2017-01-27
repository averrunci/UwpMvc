// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="RightTappedRoutedEventArgs"/>
    /// resolved by <see cref="IRightTappedRoutedEventArgsResolver"/>.
    /// </summary>
    public static class RightTappedRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IRightTappedRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="RightTappedRoutedEventArgs"/>.
        /// </summary>
        public static IRightTappedRoutedEventArgsResolver Resolver { get; set; } = new DefaultRightTappedRoutedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this RightTappedRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this RightTappedRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this RightTappedRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// that initiated the associated input event.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <returns>The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this event occurrence.</returns>
        public static PointerDeviceType PointerDeviceType(this RightTappedRoutedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin
        /// of a supplied <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </returns>
        public static Point GetPositionWrapped(RightTappedRoutedEventArgs e, UIElement relativeTo) => Resolver.GetPosition(e, relativeTo);

        private sealed class DefaultRightTappedRoutedEventArgsResolver : IRightTappedRoutedEventArgsResolver
        {
            bool IRightTappedRoutedEventArgsResolver.Handled(RightTappedRoutedEventArgs e) => e.Handled;
            void IRightTappedRoutedEventArgsResolver.Handled(RightTappedRoutedEventArgs e, bool handled) => e.Handled = handled;
            object IRightTappedRoutedEventArgsResolver.OriginalSource(RightTappedRoutedEventArgs e) => e.OriginalSource;
            PointerDeviceType IRightTappedRoutedEventArgsResolver.PointerDeviceType(RightTappedRoutedEventArgs e) => e.PointerDeviceType;
            Point IRightTappedRoutedEventArgsResolver.GetPosition(RightTappedRoutedEventArgs e, UIElement relativeTo) => e.GetPosition(relativeTo);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="RightTappedRoutedEventArgs"/>.
    /// </summary>
    public interface IRightTappedRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(RightTappedRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(RightTappedRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(RightTappedRoutedEventArgs e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// that initiated the associated input event.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <returns>The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this event occurrence.</returns>
        PointerDeviceType PointerDeviceType(RightTappedRoutedEventArgs e);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin
        /// of a supplied <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">The requested <see cref="RightTappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </returns>
        Point GetPosition(RightTappedRoutedEventArgs e, UIElement relativeTo);
    }
}
