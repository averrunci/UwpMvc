// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Devices.Input;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ManipulationInertiaStartingRoutedEventArgs"/>
    /// resolved by <see cref="IManipulationInertiaStartingRoutedEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationInertiaStartingRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationInertiaStartingRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.
        /// </summary>
        public static IManipulationInertiaStartingRoutedEventArgsResolver Resolver { get; set; } = new DefaultManipulationInertiaStartingRoutedEventArgsResolver();

        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        public static UIElement Container(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.Container(e);

        /// <summary>
        /// Gets the overall changes since the beginning of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The overall changes since the beginning of the manipulation.</returns>
        public static ManipulationDelta Cumulative(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.Cumulative(e);

        /// <summary>
        /// Gets the most recent changes of the current manipulation, as a <see cref="ManipulationDelta"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The most recent changes of the current manipulation.</returns>
        public static ManipulationDelta Delta(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.Delta(e);

        /// <summary>
        /// Gets the rate of slowdown of expansion inertial movement.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The rate of slowdown of expansion inertial movement</returns>
        public static InertiaExpansionBehavior ExpansionBehavior(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.ExpansionBehavior(e);

        /// <summary>
        /// Sets the rate of slowdown of expansion inertial movement.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <param name="behavior">the rate of slowdown expansion inertial movement.</param>
        public static void ExpansionBehavior(this ManipulationInertiaStartingRoutedEventArgs e, InertiaExpansionBehavior expansionBehavior) => Resolver.ExpansionBehavior(e, expansionBehavior);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this ManipulationInertiaStartingRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// involved in the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>A value of the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> enumeration.</returns>
        public static PointerDeviceType PointerDeviceType(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.PointerDeviceType(e);

        /// <summary>
        /// Gets information about the rotation information associated with the manipulation for this event occurrence.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>Manipulation rotation information.</returns>
        public static InertiaRotationBehavior RotationBehavior(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.RotationBehavior(e);

        /// <summary>
        /// Sets information about the rotation information associated with the manipulation for this event occurrence.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <param name="rotationBehavior">Manipulation rotation information.</param>
        public static void RotationBehavior(this ManipulationInertiaStartingRoutedEventArgs e, InertiaRotationBehavior rotationBehavior) => Resolver.RotationBehavior(e, rotationBehavior);

        /// <summary>
        /// Gets information about the translation information associated with the manipulation for this event occurrence.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>Manipulation translation information.</returns>
        public static InertiaTranslationBehavior TranslationBehavior(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.TranslationBehavior(e);

        /// <summary>
        /// Sets information about the translation information associated with the manipulation for this event occurrence.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <param name="translationBehavior">Manipulation translation information.</param>
        public static void TranslationBehavior(ManipulationInertiaStartingRoutedEventArgs e, InertiaTranslationBehavior translationBehavior) => Resolver.TranslationBehavior(e, translationBehavior);

        /// <summary>
        /// Gets the rates of the most recent changes to the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The rates of the most recent changes to the manipulation.</returns>
        public static ManipulationVelocities Velocities(this ManipulationInertiaStartingRoutedEventArgs e) => Resolver.Velocities(e);

        private sealed class DefaultManipulationInertiaStartingRoutedEventArgsResolver : IManipulationInertiaStartingRoutedEventArgsResolver
        {
            UIElement IManipulationInertiaStartingRoutedEventArgsResolver.Container(ManipulationInertiaStartingRoutedEventArgs e) => e.Container;
            ManipulationDelta IManipulationInertiaStartingRoutedEventArgsResolver.Cumulative(ManipulationInertiaStartingRoutedEventArgs e) => e.Cumulative;
            ManipulationDelta IManipulationInertiaStartingRoutedEventArgsResolver.Delta(ManipulationInertiaStartingRoutedEventArgs e) => e.Delta;
            InertiaExpansionBehavior IManipulationInertiaStartingRoutedEventArgsResolver.ExpansionBehavior(ManipulationInertiaStartingRoutedEventArgs e) => e.ExpansionBehavior;
            void IManipulationInertiaStartingRoutedEventArgsResolver.ExpansionBehavior(ManipulationInertiaStartingRoutedEventArgs e, InertiaExpansionBehavior expansionBehavior) => e.ExpansionBehavior = expansionBehavior;
            bool IManipulationInertiaStartingRoutedEventArgsResolver.Handled(ManipulationInertiaStartingRoutedEventArgs e) => e.Handled;
            void IManipulationInertiaStartingRoutedEventArgsResolver.Handled(ManipulationInertiaStartingRoutedEventArgs e, bool handled) => e.Handled = handled;
            object IManipulationInertiaStartingRoutedEventArgsResolver.OriginalSource(ManipulationInertiaStartingRoutedEventArgs e) => e.OriginalSource;
            PointerDeviceType IManipulationInertiaStartingRoutedEventArgsResolver.PointerDeviceType(ManipulationInertiaStartingRoutedEventArgs e) => e.PointerDeviceType;
            InertiaRotationBehavior IManipulationInertiaStartingRoutedEventArgsResolver.RotationBehavior(ManipulationInertiaStartingRoutedEventArgs e) => e.RotationBehavior;
            void IManipulationInertiaStartingRoutedEventArgsResolver.RotationBehavior(ManipulationInertiaStartingRoutedEventArgs e, InertiaRotationBehavior rotationBehavior) => e.RotationBehavior = rotationBehavior;
            InertiaTranslationBehavior IManipulationInertiaStartingRoutedEventArgsResolver.TranslationBehavior(ManipulationInertiaStartingRoutedEventArgs e) => e.TranslationBehavior;
            void IManipulationInertiaStartingRoutedEventArgsResolver.TranslationBehavior(ManipulationInertiaStartingRoutedEventArgs e, InertiaTranslationBehavior translationBehavior) => e.TranslationBehavior = translationBehavior;
            ManipulationVelocities IManipulationInertiaStartingRoutedEventArgsResolver.Velocities(ManipulationInertiaStartingRoutedEventArgs e) => e.Velocities;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.
    /// </summary>
    public interface IManipulationInertiaStartingRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        UIElement Container(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Gets the overall changes since the beginning of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The overall changes since the beginning of the manipulation.</returns>
        ManipulationDelta Cumulative(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Gets the most recent changes of the current manipulation, as a <see cref="ManipulationDelta"/>.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The most recent changes of the current manipulation.</returns>
        ManipulationDelta Delta(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Gets the rate of slowdown of expansion inertial movement.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The rate of slowdown of expansion inertial movement</returns>
        InertiaExpansionBehavior ExpansionBehavior(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Sets the rate of slowdown of expansion inertial movement.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <param name="behavior">the rate of slowdown expansion inertial movement.</param>
        void ExpansionBehavior(ManipulationInertiaStartingRoutedEventArgs e, InertiaExpansionBehavior expansionBehavior);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(ManipulationInertiaStartingRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Gets the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> for the pointer device
        /// involved in the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>A value of the <see cref="global::Windows.Devices.Input.PointerDeviceType"/> enumeration.</returns>
        PointerDeviceType PointerDeviceType(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Gets information about the rotation information associated with the manipulation for this event occurrence.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>Manipulation rotation information.</returns>
        InertiaRotationBehavior RotationBehavior(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Sets information about the rotation information associated with the manipulation for this event occurrence.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <param name="rotationBehavior">Manipulation rotation information.</param>
        void RotationBehavior(ManipulationInertiaStartingRoutedEventArgs e, InertiaRotationBehavior rotationBehavior);

        /// <summary>
        /// Gets information about the translation information associated with the manipulation for this event occurrence.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>Manipulation translation information.</returns>
        InertiaTranslationBehavior TranslationBehavior(ManipulationInertiaStartingRoutedEventArgs e);

        /// <summary>
        /// Sets information about the translation information associated with the manipulation for this event occurrence.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <param name="translationBehavior">Manipulation translation information.</param>
        void TranslationBehavior(ManipulationInertiaStartingRoutedEventArgs e, InertiaTranslationBehavior translationBehavior);

        /// <summary>
        /// Gets the rates of the most recent changes to the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationInertiaStartingRoutedEventArgs"/>.</param>
        /// <returns>The rates of the most recent changes to the manipulation.</returns>
        ManipulationVelocities Velocities(ManipulationInertiaStartingRoutedEventArgs e);
    }
}
