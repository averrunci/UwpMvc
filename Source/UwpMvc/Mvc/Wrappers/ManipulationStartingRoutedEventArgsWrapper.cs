// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ManipulationStartingRoutedEventArgs"/>
    /// resolved by <see cref="IManipulationStartingRoutedEventArgsResolver"/>.
    /// </summary>
    public static class ManipulationStartingRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IManipulationStartingRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="ManipulationStartingRoutedEventArgs"/>.
        /// </summary>
        public static IManipulationStartingRoutedEventArgsResolver Resolver { get; set; } = new DefaultManipulationStartingRoutedEventArgsResolver();

        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        public static UIElement Container(this ManipulationStartingRoutedEventArgs e) => Resolver.Container(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this ManipulationStartingRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this ManipulationStartingRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets which types of manipulations are possible.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>One of the <see cref="ManipulationModes"/> enumeration values.</returns>
        public static ManipulationModes Mode(this ManipulationStartingRoutedEventArgs e) => Resolver.Mode(e);

        /// <summary>
        /// Sets which types of manipulations are possible.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <param name="mode">One of the <see cref="ManipulationModes"/> enumeration values.</param>
        public static void Mode(this ManipulationStartingRoutedEventArgs e, ManipulationModes mode) => Resolver.Mode(e, mode);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ManipulationStartingRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets an object that describes the pivot for a single-point manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>An object that describes the pivot for a single-point manipulation.</returns>
        public static ManipulationPivot Pivot(this ManipulationStartingRoutedEventArgs e) => Resolver.Pivot(e);

        /// <summary>
        /// Sets an object that describes the pivot for a single-point manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <param name="pivot">An object that describes the pivot for a single-point manipulation.</param>
        public static void Pivot(this ManipulationStartingRoutedEventArgs e, ManipulationPivot pivot) => Resolver.Pivot(e, pivot);

        private sealed class DefaultManipulationStartingRoutedEventArgsResolver : IManipulationStartingRoutedEventArgsResolver
        {
            UIElement IManipulationStartingRoutedEventArgsResolver.Container(ManipulationStartingRoutedEventArgs e) => e.Container;
            bool IManipulationStartingRoutedEventArgsResolver.Handled(ManipulationStartingRoutedEventArgs e) => e.Handled;
            void IManipulationStartingRoutedEventArgsResolver.Handled(ManipulationStartingRoutedEventArgs e, bool handled) => e.Handled = handled;
            ManipulationModes IManipulationStartingRoutedEventArgsResolver.Mode(ManipulationStartingRoutedEventArgs e) => e.Mode;
            void IManipulationStartingRoutedEventArgsResolver.Mode(ManipulationStartingRoutedEventArgs e, ManipulationModes mode) => e.Mode = mode;
            object IManipulationStartingRoutedEventArgsResolver.OriginalSource(ManipulationStartingRoutedEventArgs e) => e.OriginalSource;
            ManipulationPivot IManipulationStartingRoutedEventArgsResolver.Pivot(ManipulationStartingRoutedEventArgs e) => e.Pivot;
            void IManipulationStartingRoutedEventArgsResolver.Pivot(ManipulationStartingRoutedEventArgs e, ManipulationPivot pivot) => e.Pivot = pivot;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ManipulationStartingRoutedEventArgs"/>.
    /// </summary>
    public interface IManipulationStartingRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets the <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>
        /// The <see cref="UIElement"/> that is considered the container of the manipulation.
        /// </returns>
        UIElement Container(ManipulationStartingRoutedEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(ManipulationStartingRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(ManipulationStartingRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets which types of manipulations are possible.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>One of the <see cref="ManipulationModes"/> enumeration values.</returns>
        ManipulationModes Mode(ManipulationStartingRoutedEventArgs e);

        /// <summary>
        /// Sets which types of manipulations are possible.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <param name="mode">One of the <see cref="ManipulationModes"/> enumeration values.</param>
        void Mode(ManipulationStartingRoutedEventArgs e, ManipulationModes mode);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ManipulationStartingRoutedEventArgs e);

        /// <summary>
        /// Gets an object that describes the pivot for a single-point manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <returns>An object that describes the pivot for a single-point manipulation.</returns>
        ManipulationPivot Pivot(ManipulationStartingRoutedEventArgs e);

        /// <summary>
        /// Sets an object that describes the pivot for a single-point manipulation.
        /// </summary>
        /// <param name="e">The requested <see cref="ManipulationStartingRoutedEventArgs"/>.</param>
        /// <param name="pivot">An object that describes the pivot for a single-point manipulation.</param>
        void Pivot(ManipulationStartingRoutedEventArgs e, ManipulationPivot pivot);
    }
}
