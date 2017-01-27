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
    /// Provides data of the <see cref="ManipulationStartedRoutedEventArgs"/>
    /// resolved by <see cref="IManipulationStartedRoutedEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationStartedRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationStartedRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationStartedRoutedEventArgs"/>.
        /// </summary>
        public static IManipulationStartedRoutedEventArgsResolver Resolver { get; set; } = new DefaultManipulationStartedRoutedEventArgsResolver();

        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        public static UIElement Container(ManipulationStartedRoutedEventArgs e) => Resolver.Container(e);

        /// <summary>
        /// Gets the overall changes since the beginning of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>The overall changes since the beginning of the manipulation.</returns>
        public static ManipulationDelta Cumulative(this ManipulationStartedRoutedEventArgs e) => Resolver.Cumulative(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this ManipulationStartedRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this ManipulationStartedRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ManipulationStartedRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// involved in the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>A value of the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> enumeration.</returns>
        public static PointerDeviceType PointerDeviceType(this ManipulationStartedRoutedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the point from which the manipulation originated.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>The point from which the manipulation originated.</returns>
        public static Point Position(this ManipulationStartedRoutedEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Completes the manipulation without inertia.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        public static void Complete(this ManipulationStartedRoutedEventArgs e) => Resolver.Complete(e);

        private sealed class DefaultManipulationStartedRoutedEventArgsResolver : IManipulationStartedRoutedEventArgsResolver
        {
            UIElement IManipulationStartedRoutedEventArgsResolver.Container(ManipulationStartedRoutedEventArgs e) => e.Container;
            ManipulationDelta IManipulationStartedRoutedEventArgsResolver.Cumulative(ManipulationStartedRoutedEventArgs e) => e.Cumulative;
            bool IManipulationStartedRoutedEventArgsResolver.Handled(ManipulationStartedRoutedEventArgs e) => e.Handled;
            void IManipulationStartedRoutedEventArgsResolver.Handled(ManipulationStartedRoutedEventArgs e, bool handled) => e.Handled = handled;
            object IManipulationStartedRoutedEventArgsResolver.OriginalSource(ManipulationStartedRoutedEventArgs e) => e.OriginalSource;
            PointerDeviceType IManipulationStartedRoutedEventArgsResolver.PointerDeviceType(ManipulationStartedRoutedEventArgs e) => e.PointerDeviceType;
            Point IManipulationStartedRoutedEventArgsResolver.Position(ManipulationStartedRoutedEventArgs e) => e.Position;
            void IManipulationStartedRoutedEventArgsResolver.Complete(ManipulationStartedRoutedEventArgs e) => e.Complete();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationStartedRoutedEventArgs"/>.
    /// </summary>
    public interface IManipulationStartedRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        UIElement Container(ManipulationStartedRoutedEventArgs e);

        /// <summary>
        /// Gets the overall changes since the beginning of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>The overall changes since the beginning of the manipulation.</returns>
        ManipulationDelta Cumulative(ManipulationStartedRoutedEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(ManipulationStartedRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(ManipulationStartedRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ManipulationStartedRoutedEventArgs e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// involved in the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>A value of the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> enumeration.</returns>
        PointerDeviceType PointerDeviceType(ManipulationStartedRoutedEventArgs e);

        /// <summary>
        /// Gets the point from which the manipulation originated.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        /// <returns>The point from which the manipulation originated.</returns>
        Point Position(ManipulationStartedRoutedEventArgs e);

        /// <summary>
        /// Completes the manipulation without inertia.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartedRoutedEventArgs"/>.</param>
        void Complete(ManipulationStartedRoutedEventArgs e);
    }
}
