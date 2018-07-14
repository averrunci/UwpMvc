// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Input;
using Windows.Foundation;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ManipulationDeltaRoutedEventArgs"/>
    /// resolved by <see cref="IManipulationDeltaRoutedEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationDeltaRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationDeltaRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationDeltaRoutedEventArgs"/>.
        /// </summary>
        public static IManipulationDeltaRoutedEventArgsResolver Resolver { get; set; } = new DefaultManipulationDeltaRoutedEventArgsResolver();

        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        public static UIElement Container(this ManipulationDeltaRoutedEventArgs e) => Resolver.Container(e);

        /// <summary>
        /// Gets the overall changes since the beginning of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The overall changes since the beginning of the manipulation.</returns>
        public static ManipulationDelta Cumulative(this ManipulationDeltaRoutedEventArgs e) => Resolver.Cumulative(e);

        /// <summary>
        /// Gets the most recent changes of the current manipulation, as a <see cref="ManipulationDelta"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The most recent changes of the current manipulation.</returns>
        public static ManipulationDelta Delta(this ManipulationDeltaRoutedEventArgs e) => Resolver.Delta(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this ManipulationDeltaRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this ManipulationDeltaRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets whether the <see cref="UIElement.ManipulationDelta"/> event occurs during inertia.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the <see cref="UIElement.ManipulationDelta"/> event occurs during inertia;
        /// <c>false</c> if the event occurs while the user's input device has contact with the element.
        /// </returns>
        public static bool IsInertial(this ManipulationDeltaRoutedEventArgs e) => Resolver.IsInertial(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ManipulationDeltaRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// involved in the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>A value of the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> enumeration.</returns>
        public static PointerDeviceType PointerDeviceType(this ManipulationDeltaRoutedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the point from which the manipulation originated.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The point from which the manipulation originated.</returns>
        public static Point Position(this ManipulationDeltaRoutedEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets the rates of the most recent changes to the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The rates of the most recent changes to the manipulation.</returns>
        public static ManipulationVelocities Velocities(this ManipulationDeltaRoutedEventArgs e) => Resolver.Velocities(e);

        /// <summary>
        /// Completes the manipulation without inertia.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        public static void Complete(this ManipulationDeltaRoutedEventArgs e) => Resolver.Complete(e);

        private sealed class DefaultManipulationDeltaRoutedEventArgsResolver : IManipulationDeltaRoutedEventArgsResolver
        {
            UIElement IManipulationDeltaRoutedEventArgsResolver.Container(ManipulationDeltaRoutedEventArgs e) => e.Container;
            ManipulationDelta IManipulationDeltaRoutedEventArgsResolver.Cumulative(ManipulationDeltaRoutedEventArgs e) => e.Cumulative;
            ManipulationDelta IManipulationDeltaRoutedEventArgsResolver.Delta(ManipulationDeltaRoutedEventArgs e) => e.Delta;
            bool IManipulationDeltaRoutedEventArgsResolver.Handled(ManipulationDeltaRoutedEventArgs e) => e.Handled;
            void IManipulationDeltaRoutedEventArgsResolver.Handled(ManipulationDeltaRoutedEventArgs e, bool handled) => e.Handled = handled;
            bool IManipulationDeltaRoutedEventArgsResolver.IsInertial(ManipulationDeltaRoutedEventArgs e) => e.IsInertial;
            object IManipulationDeltaRoutedEventArgsResolver.OriginalSource(ManipulationDeltaRoutedEventArgs e) => e.OriginalSource;
            PointerDeviceType IManipulationDeltaRoutedEventArgsResolver.PointerDeviceType(ManipulationDeltaRoutedEventArgs e) => e.PointerDeviceType;
            Point IManipulationDeltaRoutedEventArgsResolver.Position(ManipulationDeltaRoutedEventArgs e) => e.Position;
            ManipulationVelocities IManipulationDeltaRoutedEventArgsResolver.Velocities(ManipulationDeltaRoutedEventArgs e) => e.Velocities;
            void IManipulationDeltaRoutedEventArgsResolver.Complete(ManipulationDeltaRoutedEventArgs e) => e.Complete();
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationDeltaRoutedEventArgs"/>.
    /// </summary>
    public interface IManipulationDeltaRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        UIElement Container(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Gets the overall changes since the beginning of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The overall changes since the beginning of the manipulation.</returns>
        ManipulationDelta Cumulative(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Gets the most recent changes of the current manipulation, as a <see cref="ManipulationDelta"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The most recent changes of the current manipulation.</returns>
        ManipulationDelta Delta(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(ManipulationDeltaRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets whether the <see cref="UIElement.ManipulationDelta"/> event occurs during inertia.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the <see cref="UIElement.ManipulationDelta"/> event occurs during inertia;
        /// <c>false</c> if the event occurs while the user's input device has contact with the element.
        /// </returns>
        bool IsInertial(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// involved in the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>A value of the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> enumeration.</returns>
        PointerDeviceType PointerDeviceType(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Gets the point from which the manipulation originated.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The point from which the manipulation originated.</returns>
        Point Position(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Gets the rates of the most recent changes to the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        /// <returns>The rates of the most recent changes to the manipulation.</returns>
        ManipulationVelocities Velocities(ManipulationDeltaRoutedEventArgs e);

        /// <summary>
        /// Completes the manipulation without inertia.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationDeltaRoutedEventArgs"/>.</param>
        void Complete(ManipulationDeltaRoutedEventArgs e);
    }
}
