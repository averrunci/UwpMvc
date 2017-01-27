// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="KeyRoutedEventArgs"/>
    /// resolved by <see cref="IKeyRoutedEventArgsResolver"/>.
    /// </summary>
    public static class KeyRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="KeyIRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="KeyRoutedEventArgs"/>.
        /// </summary>
        public static IKeyRoutedEventArgsResolver Resolver { get; set; } = new DefaultKeyRoutedEventArgsResolver();

        /// <summary>
        /// Gets a unique ID for the input device that generated this key event.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>
        /// A unique identifier for the input device associated with the key event,
        /// or an empty string for an unsupported device.
        /// </returns>
        public static string DeviceId(this KeyRoutedEventArgs e) => Resolver.DeviceId(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this KeyRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this KeyRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the input button associated with the event.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>A system value that indicates the code for the key referenced by the event.</returns>
        public static VirtualKey Key(this KeyRoutedEventArgs e) => Resolver.Key(e);

        /// <summary>
        /// Gets a structure value that reports various system-detected characteristics of the key press,
        /// including repeat count and menu status.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>A structure value with flags that report status.</returns>
        public static CorePhysicalKeyStatus KeyStatus(this KeyRoutedEventArgs e) => Resolver.KeyStatus(e);

        /// <summary>
        /// Gets the original, unmapped input button associated with the event.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>A system value that indicates the code for the key referenced by the event.</returns>
        public static VirtualKey OriginalKey(this KeyRoutedEventArgs e) => Resolver.OriginalKey(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this KeyRoutedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultKeyRoutedEventArgsResolver : IKeyRoutedEventArgsResolver
        {
            string IKeyRoutedEventArgsResolver.DeviceId(KeyRoutedEventArgs e) => e.DeviceId;
            bool IKeyRoutedEventArgsResolver.Handled(KeyRoutedEventArgs e) => e.Handled;
            void IKeyRoutedEventArgsResolver.Handled(KeyRoutedEventArgs e, bool handled) => e.Handled = handled;
            VirtualKey IKeyRoutedEventArgsResolver.Key(KeyRoutedEventArgs e) => e.Key;
            CorePhysicalKeyStatus IKeyRoutedEventArgsResolver.KeyStatus(KeyRoutedEventArgs e) => e.KeyStatus;
            VirtualKey IKeyRoutedEventArgsResolver.OriginalKey(KeyRoutedEventArgs e) => e.OriginalKey;
            object IKeyRoutedEventArgsResolver.OriginalSource(KeyRoutedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="KeyRoutedEventArgs"/>.
    /// </summary>
    public interface IKeyRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets a unique ID for the input device that generated this key event.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>
        /// A unique identifier for the input device associated with the key event,
        /// or an empty string for an unsupported device.
        /// </returns>
        string DeviceId(KeyRoutedEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(KeyRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(KeyRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets the input button associated with the event.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>A system value that indicates the code for the key referenced by the event.</returns>
        VirtualKey Key(KeyRoutedEventArgs e);

        /// <summary>
        /// Gets a structure value that reports various system-detected characteristics of the key press,
        /// including repeat count and menu status.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>A structure value with flags that report status.</returns>
        CorePhysicalKeyStatus KeyStatus(KeyRoutedEventArgs e);

        /// <summary>
        /// Gets the original, unmapped input button associated with the event.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>A system value that indicates the code for the key referenced by the event.</returns>
        VirtualKey OriginalKey(KeyRoutedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="KeyRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(KeyRoutedEventArgs e);
    }
}
