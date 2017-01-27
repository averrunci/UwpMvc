// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.System;
using Windows.UI.Input;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="PointerRoutedEventArgs"/>
    /// resolved by <see cref="IPointerRoutedEventArgsResolver"/>.
    /// </summary>
    public static class PointerRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IPointerRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="PointerRoutedEventArgs"/>.
        /// </summary>
        public static IPointerRoutedEventArgsResolver Resolver { get; set; } = new DefaultPointerRoutedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this PointerRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this PointerRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a value that indicates which key modifiers were active at the time that the pointer event was initiated.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <returns>A value or values of the <see cref="VirtualKeyModifiers"/> enumeration.</returns>
        public static VirtualKeyModifiers KeyModifiers(this PointerRoutedEventArgs e) => Resolver.KeyModifiers(e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this PointerRoutedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets a reference to a pointer token.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <returns>A pointer token.</returns>
        public static Pointer Pointer(this PointerRoutedEventArgs e) => Resolver.Pointer(e);

        /// <summary>
        /// Gets a <see cref="PointerPoint"/> object that provides basic information on the pointer associated with the event.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <returns>
        /// A <see cref="PointerPoint"/> value that represents the pointer point associated with this event.
        /// If <c>null</c> was passed as <paramref name="relativeTo"/>, the coordinates are in the frame of
        /// reference of the overall window. If a <paramref name="relativeTo"/> value other than <c>null</c>
        /// was passed, the coordinates are relative to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        public static PointerPoint GetCurrentPointWrapped(this PointerRoutedEventArgs e, UIElement relativeTo) => Resolver.GetCurrentPoint(e, relativeTo);

        /// <summary>
        /// Gets a collection of <see cref="PointerPoint"/> objects that represent the pointer history from the last pointer
        /// event up to and including the current pointer event. Each <see cref="PointerPoint"/> in the collection provides
        /// basic information on the pointer associated with the event.
        /// <para>
        /// The last item in the collection is equivalent to the <see cref="PointerPoint"/> object
        /// returned by <see cref="GetCurrentPoint(PointerRoutedEventArgs, UIElement)"/>.
        /// </para>
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// If <c>null</c>, location coordinates are in the context of the app.
        /// </param>
        /// <returns>
        /// The collection of <see cref="PointerPoint"/> objects corresponding to the pointer history associated with the event.
        /// If <paramref name="relativeTo"/> is <c>null</c>, location coordinates are in the context of the app.
        /// Otherwise, the coordinates are relative to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        public static IList<PointerPoint> GetIntermediatePointsWrapped(PointerRoutedEventArgs e, UIElement relativeTo) => Resolver.GetIntermediatePoints(e, relativeTo);

        private sealed class DefaultPointerRoutedEventArgsResolver : IPointerRoutedEventArgsResolver
        {
            bool IPointerRoutedEventArgsResolver.Handled(PointerRoutedEventArgs e) => e.Handled;
            void IPointerRoutedEventArgsResolver.Handled(PointerRoutedEventArgs e, bool handled) => e.Handled = handled;
            VirtualKeyModifiers IPointerRoutedEventArgsResolver.KeyModifiers(PointerRoutedEventArgs e) => e.KeyModifiers;
            object IPointerRoutedEventArgsResolver.OriginalSource(PointerRoutedEventArgs e) => e.OriginalSource;
            Pointer IPointerRoutedEventArgsResolver.Pointer(PointerRoutedEventArgs e) => e.Pointer;
            PointerPoint IPointerRoutedEventArgsResolver.GetCurrentPoint(PointerRoutedEventArgs e, UIElement relativeTo) => e.GetCurrentPoint(relativeTo);
            IList<PointerPoint> IPointerRoutedEventArgsResolver.GetIntermediatePoints(PointerRoutedEventArgs e, UIElement relativeTo) => e.GetIntermediatePoints(relativeTo);
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="PointerRoutedEventArgs"/>.
    /// </summary>
    public interface IPointerRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(PointerRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(PointerRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets a value that indicates which key modifiers were active at the time that the pointer event was initiated.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <returns>A value or values of the <see cref="VirtualKeyModifiers"/> enumeration.</returns>
        VirtualKeyModifiers KeyModifiers(PointerRoutedEventArgs e);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(PointerRoutedEventArgs e);

        /// <summary>
        /// Gets a reference to a pointer token.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <returns>A pointer token.</returns>
        Pointer Pointer(PointerRoutedEventArgs e);

        /// <summary>
        /// Gets a <see cref="PointerPoint"/> object that provides basic information on the pointer associated with the event.
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// To specify the object relative to the overall coordinate system,
        /// use a <paramref name="relativeTo"/> value of <c>null</c>.
        /// </param>
        /// <returns>
        /// A <see cref="PointerPoint"/> value that represents the pointer point associated with this event.
        /// If <c>null</c> was passed as <paramref name="relativeTo"/>, the coordinates are in the frame of
        /// reference of the overall window. If a <paramref name="relativeTo"/> value other than <c>null</c>
        /// was passed, the coordinates are relative to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        PointerPoint GetCurrentPoint(PointerRoutedEventArgs e, UIElement relativeTo);

        /// <summary>
        /// Gets a collection of <see cref="PointerPoint"/> objects that represent the pointer history from the last pointer
        /// event up to and including the current pointer event. Each <see cref="PointerPoint"/> in the collection provides
        /// basic information on the pointer associated with the event.
        /// <para>
        /// The last item in the collection is equivalent to the <see cref="PointerPoint"/> object
        /// returned by <see cref="GetCurrentPoint(PointerRoutedEventArgs, UIElement)"/>.
        /// </para>
        /// </summary>
        /// <param name="e">The requested <see cref="PointerRoutedEventArgs"/>.</param>
        /// <param name="relativeTo">
        /// Any <see cref="UIElement"/>-derived object that is connected to the same object tree.
        /// If <c>null</c>, location coordinates are in the context of the app.
        /// </param>
        /// <returns>
        /// The collection of <see cref="PointerPoint"/> objects corresponding to the pointer history associated with the event.
        /// If <paramref name="relativeTo"/> is <c>null</c>, location coordinates are in the context of the app.
        /// Otherwise, the coordinates are relative to the object referenced by <paramref name="relativeTo"/>.
        /// </returns>
        IList<PointerPoint> GetIntermediatePoints(PointerRoutedEventArgs e, UIElement relativeTo);
    }
}
