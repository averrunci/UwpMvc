// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ProcessKeyboardAcceleratorEventArgs"/>
    /// resolved by <see cref="IProcessKeyboardAcceleratorEventArgsResolver"/>.
    /// </summary>
    public static class ProcessKeyboardAcceleratorEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IProcessKeyboardAcceleratorEventArgsResolver"/>
        /// that resolves data of the <see cref="ProcessKeyboardAcceleratorEventArgs"/>.
        /// </summary>
        public static IProcessKeyboardAcceleratorEventArgsResolver Resolver { get; set; } = new DefaultProcessKeyboardAcceleratorEventArgsResolver();

        /// <summary>
        /// Gets the virtual key (used in conjunction with one or more modifier keys) for a keyboard shortcut (accelerator).
        /// </summary>
        /// <param name="e">The requested <see cref="ProcessKeyboardAcceleratorEventArgs"/>.</param>
        /// <returns>The virtual key.</returns>
        public static VirtualKey Key(this ProcessKeyboardAcceleratorEventArgs e) => Resolver.Key(e);

        /// <summary>
        /// Gets the virtual key used to modify another keypress for a keyboard shortcut (accelerator).
        /// </summary>
        /// <param name="e">The requested <see cref="ProcessKeyboardAcceleratorEventArgs"/>.</param>
        /// <returns>The virtual key.</returns>
        public static VirtualKeyModifiers Modifiers(this ProcessKeyboardAcceleratorEventArgs e) => Resolver.Modifiers(e);

        /// <summary>
        /// Gets a value that marks the event as handled.
        /// </summary>
        /// <param name="e">The requested <see cref="ProcessKeyboardAcceleratorEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the event handled. <c>false</c> to leave the event unhandled. The default is <c>false</c>.
        /// </returns>
        public static bool Handled(this ProcessKeyboardAcceleratorEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the event as handled.
        /// </summary>
        /// <param name="e">The requested <see cref="ProcessKeyboardAcceleratorEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the event handled. <c>false</c> to leave the event unhandled. The default is <c>false</c>.
        /// </param>
        public static void Handled(this ProcessKeyboardAcceleratorEventArgs e, bool handled) => Resolver.Handled(e, handled);

        private sealed class DefaultProcessKeyboardAcceleratorEventArgsResolver : IProcessKeyboardAcceleratorEventArgsResolver
        {
            VirtualKey IProcessKeyboardAcceleratorEventArgsResolver.Key(ProcessKeyboardAcceleratorEventArgs e) => e.Key;
            VirtualKeyModifiers IProcessKeyboardAcceleratorEventArgsResolver.Modifiers(ProcessKeyboardAcceleratorEventArgs e) => e.Modifiers;
            bool IProcessKeyboardAcceleratorEventArgsResolver.Handled(ProcessKeyboardAcceleratorEventArgs e) => e.Handled;
            void IProcessKeyboardAcceleratorEventArgsResolver.Handled(ProcessKeyboardAcceleratorEventArgs e, bool handled) => e.Handled = handled;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ProcessKeyboardAcceleratorEventArgs"/>.
    /// </summary>
    public interface IProcessKeyboardAcceleratorEventArgsResolver
    {
        /// <summary>
        /// Gets the virtual key (used in conjunction with one or more modifier keys) for a keyboard shortcut (accelerator).
        /// </summary>
        /// <param name="e">The requested <see cref="ProcessKeyboardAcceleratorEventArgs"/>.</param>
        /// <returns>The virtual key.</returns>
        VirtualKey Key(ProcessKeyboardAcceleratorEventArgs e);

        /// <summary>
        /// Gets the virtual key used to modify another keypress for a keyboard shortcut (accelerator).
        /// </summary>
        /// <param name="e">The requested <see cref="ProcessKeyboardAcceleratorEventArgs"/>.</param>
        /// <returns>The virtual key.</returns>
        VirtualKeyModifiers Modifiers(ProcessKeyboardAcceleratorEventArgs e);

        /// <summary>
        /// Gets a value that marks the event as handled.
        /// </summary>
        /// <param name="e">The requested <see cref="ProcessKeyboardAcceleratorEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the event handled. <c>false</c> to leave the event unhandled. The default is <c>false</c>.
        /// </returns>
        bool Handled(ProcessKeyboardAcceleratorEventArgs e);

        /// <summary>
        /// Sets a value that marks the event as handled.
        /// </summary>
        /// <param name="e">The requested <see cref="ProcessKeyboardAcceleratorEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the event handled. <c>false</c> to leave the event unhandled. The default is <c>false</c>.
        /// </param>
        void Handled(ProcessKeyboardAcceleratorEventArgs e, bool handled);
    }
}
