// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ContextMenuEventArgs"/>
    /// resolved by <see cref="IContextMenuEventArgsResolver"/>.
    /// </summary>
    public static class ContextMenuEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IContextMenuEventArgsResolver"/>
        /// that resolves data of the <see cref="ContextMenuEventArgs"/>.
        /// </summary>
        public static IContextMenuEventArgsResolver Resolver { get; set; } = new DefaultContextMenuEventArgsResolver();

        /// <summary>
        /// Gets the pixel offset of the text cursor horizontal position.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <returns>A value in pixels.</returns>
        public static double CursorLeft(this ContextMenuEventArgs e) => Resolver.CursorLeft(e);

        /// <summary>
        /// Gets the pixel offset of the text cursor vertical position.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <returns>A value in pixels.</returns>
        public static double CursorTop(this ContextMenuEventArgs e) => Resolver.CursorTop(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this ContextMenuEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this ContextMenuEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this ContextMenuEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultContextMenuEventArgsResolver : IContextMenuEventArgsResolver
        {
            double IContextMenuEventArgsResolver.CursorLeft(ContextMenuEventArgs e) => e.CursorLeft;
            double IContextMenuEventArgsResolver.CursorTop(ContextMenuEventArgs e) => e.CursorTop;
            bool IContextMenuEventArgsResolver.Handled(ContextMenuEventArgs e) => e.Handled;
            void IContextMenuEventArgsResolver.Handled(ContextMenuEventArgs e, bool handled) => e.Handled = handled;
            object IContextMenuEventArgsResolver.OriginalSource(ContextMenuEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ContextMenuEventArgs"/>.
    /// </summary>
    public interface IContextMenuEventArgsResolver
    {
        /// <summary>
        /// Gets the pixel offset of the text cursor horizontal position.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <returns>A value in pixels.</returns>
        double CursorLeft(ContextMenuEventArgs e);

        /// <summary>
        /// Gets the pixel offset of the text cursor vertical position.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <returns>A value in pixels.</returns>
        double CursorTop(ContextMenuEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(ContextMenuEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(ContextMenuEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextMenuEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(ContextMenuEventArgs e);
    }
}
