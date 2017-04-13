// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="HoldingRoutedEventArgs"/>
    /// resolved by <see cref="IHoldingRoutedEventArgsResolver"/>.
    /// </summary>
    public static class HoldingRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IHoldingRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="HoldingRoutedEventArgs"/>.
        /// </summary>
        public static IHoldingRoutedEventArgsResolver Resolver { get; set; } = new DefaultHoldingRoutedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this HoldingRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this HoldingRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the underlying <see cref="global::Windows.UI.Input.HoldingState"/> for the interaction.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <returns>A value of the <see cref="global::Windows.UI.Input.HoldingState"/> enumeration.</returns>
        public static HoldingState HoldingState(this HoldingRoutedEventArgs e) => Resolver.HoldingState(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this HoldingRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// that initiated the associated input event.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this event occurrence.
        /// </returns>
        public static PointerDeviceType PointerDeviceType(this HoldingRoutedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against
        /// a coordinate origin of a supplied <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system, use a
        /// <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <returns>
        /// A Point that represents the current x- and y-coordinates of the mouse position.
        /// If <c>null</c> was passed as <paramref name="relativeTo"/>, this coordinate is for the overall
        /// window. If a <paramref name="relativeTo"/> value other than <c>null</c> was passed, this
        /// coordinate is relative to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        public static Point GetPositionWrapped(HoldingRoutedEventArgs e, UIElement relativeTo) => Resolver.GetPosition(e, relativeTo);

        private sealed class DefaultHoldingRoutedEventArgsResolver : IHoldingRoutedEventArgsResolver
        {
            bool IHoldingRoutedEventArgsResolver.Handled(HoldingRoutedEventArgs e) => e.Handled;
            void IHoldingRoutedEventArgsResolver.Handled(HoldingRoutedEventArgs e, bool handled) => e.Handled = handled;
            HoldingState IHoldingRoutedEventArgsResolver.HoldingState(HoldingRoutedEventArgs e) => e.HoldingState;
            object IHoldingRoutedEventArgsResolver.OriginalSource(HoldingRoutedEventArgs e) => e.OriginalSource;
            PointerDeviceType IHoldingRoutedEventArgsResolver.PointerDeviceType(HoldingRoutedEventArgs e) => e.PointerDeviceType;
            Point IHoldingRoutedEventArgsResolver.GetPosition(HoldingRoutedEventArgs e, UIElement relativeTo) => e.GetPosition(relativeTo);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="HoldingRoutedEventArgs"/>.
    /// </summary>
    public interface IHoldingRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(HoldingRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(HoldingRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets the underlying <see cref="global::Windows.UI.Input.HoldingState"/> for the interaction.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <returns>A value of the <see cref="global::Windows.UI.Input.HoldingState"/> enumeration.</returns>
        HoldingState HoldingState(HoldingRoutedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(HoldingRoutedEventArgs e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// that initiated the associated input event.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for this event occurrence.
        /// </returns>
        PointerDeviceType PointerDeviceType(HoldingRoutedEventArgs e);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against
        /// a coordinate origin of a supplied <see cref="UIElement"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="HoldingRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system, use a
        /// <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <returns>
        /// A Point that represents the current x- and y-coordinates of the mouse position.
        /// If <c>null</c> was passed as <paramref name="relativeTo"/>, this coordinate is for the overall
        /// window. If a <paramref name="relativeTo"/> value other than <c>null</c> was passed, this
        /// coordinate is relative to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        Point GetPosition(HoldingRoutedEventArgs e, UIElement relativeTo);
    }
}
