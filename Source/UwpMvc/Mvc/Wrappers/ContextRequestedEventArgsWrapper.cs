// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.Foundation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="ContextRequestedEventArgs"/>
    /// resolved by <see cref="IContextRequestedEventArgsResolver"/>.
    /// </summary>
    public static class ContextRequestedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IContextRequestedEventArgsResolver"/>
        /// that resolves data of the <see cref="ContextRequestedEventArgs"/>.
        /// </summary>
        public static IContextRequestedEventArgsResolver Resolver { get; set; }

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextRequestedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this ContextRequestedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextRequestedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this ContextRequestedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against
        /// a coordinate origin of a supplied UIElement.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextRequestedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <param name="point">
        /// A Point that represents the current x- and y-coordinates of the mouse
        /// pointer position. if <c>null</c> was passed as <paramref name="relativeTo"/>, this
        /// coordinate is for the overall window. If a <paramref name="relativeTo"/> value other than
        /// <c>null</c> was passed, this coordinate is relative to the object referenced by
        /// <paramref name="relativeTo"/>.
        /// </param>
        /// <returns>
        /// <c>true</c> if the context request was initiated by a pointer device; otherwise, <c>false</c>.
        /// </returns>
        public static bool TryGetPositionWrapped(this ContextRequestedEventArgs e, UIElement relativeTo, out Point point) => Resolver.TryGetPosition(e, relativeTo, out point);

        private sealed class DefaultContextRequestedEventArgsResolver : IContextRequestedEventArgsResolver
        {
            bool IContextRequestedEventArgsResolver.Handled(ContextRequestedEventArgs e) => e.Handled;
            void IContextRequestedEventArgsResolver.Handled(ContextRequestedEventArgs e, bool handled) => e.Handled = handled;
            bool IContextRequestedEventArgsResolver.TryGetPosition(ContextRequestedEventArgs e, UIElement relativeTo, out Point point) => e.TryGetPosition(relativeTo, out point);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="ContextRequestedEventArgs"/>.
    /// </summary>
    public interface IContextRequestedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextRequestedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(ContextRequestedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextRequestedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(ContextRequestedEventArgs e, bool handled);

        /// <summary>
        /// Gets the x- and y-coordinates of the pointer position, optionally evaluated against
        /// a coordinate origin of a supplied UIElement.
        /// </summary>
        /// <param name="e">The requested <see cref="ContextRequestedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <param name="point">
        /// A Point that represents the current x- and y-coordinates of the mouse
        /// pointer position. if <c>null</c> was passed as <paramref name="relativeTo"/>, this
        /// coordinate is for the overall window. If a <paramref name="relativeTo"/> value other than
        /// <c>null</c> was passed, this coordinate is relative to the object referenced by
        /// <paramref name="relativeTo"/>.
        /// </param>
        /// <returns>
        /// <c>true</c> if the context request was initiated by a pointer device; otherwise, <c>false</c>.
        /// </returns>
        bool TryGetPosition(ContextRequestedEventArgs e, UIElement relativeTo, out Point point);
    }
}
