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
    /// Provides data of the <see cref="TappedRoutedEventArgs"/>
    /// resolved by <see cref="ITappedRoutedEventArgsResolver"/>.
    /// </summary>
    public static class TappedRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ITappedRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="TappedRoutedEventArgs"/>.
        /// </summary>
        public static ITappedRoutedEventArgsResolver Resolver { get; set; } = new DefaultTappedRoutedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this TappedRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this TappedRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this TappedRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// that initiated the associated input event.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <returns>The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this event occurrence.</returns>
        public static PointerDeviceType PointerDeviceType(this TappedRoutedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin
        /// of a supplied <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <returns>
        /// A Point that represents the current x- and y-coordinates of the mouse pointer position.
        /// If <c>null</c> was passed as <paramref name="relativeTo"/>, this coordinate is for the overall window.
        /// If a value other than <c>null</c> for <paramref name="relativeTo"/> was passed, this coordinate is relative
        /// to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        public static Point GetPositionWrapped(this TappedRoutedEventArgs e, UIElement relativeTo) => Resolver.GetPosition(e, relativeTo);

        private sealed class DefaultTappedRoutedEventArgsResolver : ITappedRoutedEventArgsResolver
        {
            bool ITappedRoutedEventArgsResolver.Handled(TappedRoutedEventArgs e) => e.Handled;
            void ITappedRoutedEventArgsResolver.Handled(TappedRoutedEventArgs e, bool handled) => e.Handled = handled;
            object ITappedRoutedEventArgsResolver.OriginalSource(TappedRoutedEventArgs e) => e.OriginalSource;
            PointerDeviceType ITappedRoutedEventArgsResolver.PointerDeviceType(TappedRoutedEventArgs e) => e.PointerDeviceType;
            Point ITappedRoutedEventArgsResolver.GetPosition(TappedRoutedEventArgs e, UIElement relativeTo) => e.GetPosition(relativeTo);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="TappedRoutedEventArgs"/>.
    /// </summary>
    public interface ITappedRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(TappedRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(TappedRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(TappedRoutedEventArgs e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// that initiated the associated input event.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <returns>The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this event occurrence.</returns>
        PointerDeviceType PointerDeviceType(TappedRoutedEventArgs e);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against a coordinate origin
        /// of a supplied <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="TappedRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <returns>
        /// A Point that represents the current x- and y-coordinates of the mouse pointer position.
        /// If <c>null</c> was passed as <paramref name="relativeTo"/>, this coordinate is for the overall window.
        /// If a value other than <c>null</c> for <paramref name="relativeTo"/> was passed, this coordinate is relative
        /// to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        Point GetPosition(TappedRoutedEventArgs e, UIElement relativeTo);
    }
}
