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
    /// Provides data of the <see cref="ManipulationCompletedRoutedEventArgs"/>
    /// resolved by <see cref="IManipulationCompletedRoutedEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationCompletedRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationCompletedRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationCompletedRoutedEventArgs"/>.
        /// </summary>
        public static IManipulationCompletedRoutedEventArgsResolver Resolver { get; set; } = new DefaultManipulationCompletedRoutedEventArgsResolver();

        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        public static UIElement Container(this ManipulationCompletedRoutedEventArgs e) => Resolver.Container(e);

        /// <summary>
        /// Gets the overall changes since the beginning of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>The overall changes since the beginning of the manipulation.</returns>
        public static ManipulationDelta Cumulative(this ManipulationCompletedRoutedEventArgs e) => Resolver.Cumulative(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this ManipulationCompletedRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this ManipulationCompletedRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets whether the <see cref="UIElement.ManipulationCompleted"/> event occurs during inertia.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the <see cref="UIElement.ManipulationCompleted"/> event occurs during inertia;
        /// <c>false</c> if the event occurs while the user's input device has contact with the element.
        /// </returns>
        public static bool IsInertial(this ManipulationCompletedRoutedEventArgs e) => Resolver.IsInertial(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ManipulationCompletedRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// involved in the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"s/>.</param>
        /// <returns>A value of the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> enumeration.</returns>
        public static PointerDeviceType PointerDeviceType(this ManipulationCompletedRoutedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets the x- and y- screen coordinates of the touch input at completed position.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"s/>.</param>
        /// <returns>The x- and y- screen coordinates of the touch input at completed position.</returns>
        public static Point Position(this ManipulationCompletedRoutedEventArgs e) => Resolver.Position(e);

        /// <summary>
        /// Gets the velocities that are used for the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"s/>.</param>
        /// <returns>The velocities that are used for the manipulation.</returns>
        public static ManipulationVelocities Velocities(this ManipulationCompletedRoutedEventArgs e) => Resolver.Velocities(e);

        private sealed class DefaultManipulationCompletedRoutedEventArgsResolver : IManipulationCompletedRoutedEventArgsResolver
        {
            UIElement IManipulationCompletedRoutedEventArgsResolver.Container(ManipulationCompletedRoutedEventArgs e) => e.Container;
            ManipulationDelta IManipulationCompletedRoutedEventArgsResolver.Cumulative(ManipulationCompletedRoutedEventArgs e) => e.Cumulative;
            bool IManipulationCompletedRoutedEventArgsResolver.Handled(ManipulationCompletedRoutedEventArgs e) => e.Handled;
            void IManipulationCompletedRoutedEventArgsResolver.Handled(ManipulationCompletedRoutedEventArgs e, bool handled) => e.Handled = handled;
            bool IManipulationCompletedRoutedEventArgsResolver.IsInertial(ManipulationCompletedRoutedEventArgs e) => e.IsInertial;
            object IManipulationCompletedRoutedEventArgsResolver.OriginalSource(ManipulationCompletedRoutedEventArgs e) => e.OriginalSource;
            PointerDeviceType IManipulationCompletedRoutedEventArgsResolver.PointerDeviceType(ManipulationCompletedRoutedEventArgs e) => e.PointerDeviceType;
            Point IManipulationCompletedRoutedEventArgsResolver.Position(ManipulationCompletedRoutedEventArgs e) => e.Position;
            ManipulationVelocities IManipulationCompletedRoutedEventArgsResolver.Velocities(ManipulationCompletedRoutedEventArgs e) => e.Velocities;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationCompletedRoutedEventArgs"/>.
    /// </summary>
    public interface IManipulationCompletedRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        UIElement Container(ManipulationCompletedRoutedEventArgs e);

        /// <summary>
        /// Gets the overall changes since the beginning of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>The overall changes since the beginning of the manipulation.</returns>
        ManipulationDelta Cumulative(ManipulationCompletedRoutedEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(ManipulationCompletedRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(ManipulationCompletedRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets whether the <see cref="UIElement.ManipulationCompleted"/> event occurs during inertia.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> if the <see cref="UIElement.ManipulationCompleted"/> event occurs during inertia;
        /// <c>false</c> if the event occurs while the user's input device has contact with the element.
        /// </returns>
        bool IsInertial(ManipulationCompletedRoutedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ManipulationCompletedRoutedEventArgs e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// involved in the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"s/>.</param>
        /// <returns>A value of the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> enumeration.</returns>
        PointerDeviceType PointerDeviceType(ManipulationCompletedRoutedEventArgs e);

        /// <summary>
        /// Gets the x- and y- screen coordinates of the touch input at completed position.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"s/>.</param>
        /// <returns>The x- and y- screen coordinates of the touch input at completed position.</returns>
        Point Position(ManipulationCompletedRoutedEventArgs e);

        /// <summary>
        /// Gets the velocities that are used for the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationCompletedRoutedEventArgs"s/>.</param>
        /// <returns>The velocities that are used for the manipulation.</returns>
        ManipulationVelocities Velocities(ManipulationCompletedRoutedEventArgs e);
    }
}
