// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="LosingFocusEventArgs"/>
    /// resolved by <see cref="ILosingFocusEventArgsResolver"/>.
    /// </summary>
    public static class LosingFocusEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ILosingFocusEventArgsResolver"/>
        /// that resolves data of the <see cref="LosingFocusEventArgs"/>.
        /// </summary>
        public static ILosingFocusEventArgsResolver Resolver { get; set; } = new DefaultLosingFocusEventArgsResolver();

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this LosingFocusEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the last focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The last focused object.</returns>
        public static DependencyObject OldFocusedElement(this LosingFocusEventArgs e) => Resolver.OldFocusedElement(e);

        /// <summary>
        /// Gets the most recent focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The most recent focused object.</returns>
        public static DependencyObject NewFocusedElement(this LosingFocusEventArgs e) => Resolver.NewFocusedElement(e);

        /// <summary>
        /// Sets the most recent focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <param name="newFocusedElement">The most recent focused object.</param>
        public static void NewFocusedElement(this LosingFocusEventArgs e, DependencyObject newFocusedElement) => Resolver.NewFocusedElement(e, newFocusedElement);

        /// <summary>
        /// Gets the input mode through which an element obtained focus.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>How the element obtained focus.</returns>
        public static FocusState FocusState(this LosingFocusEventArgs e) => Resolver.FocusState(e);

        /// <summary>
        /// Gets the direction that focus moved from element to element within the app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The direction of focus movement.</returns>
        public static FocusNavigationDirection Direction(this LosingFocusEventArgs e) => Resolver.Direction(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value for <see cref="LosingFocusEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        public static bool Handled(LosingFocusEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value for <see cref="LosingFocusEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>
        public static void Handled(this LosingFocusEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the input device type from which input events are received.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The input device type.</returns>
        public static FocusInputDeviceKind InputDevice(this LosingFocusEventArgs e) => Resolver.InputDevice(e);

        /// <summary>
        /// Gets whether focus navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns><c>true</c> if focus navigation should be canceled. Otherwise, <c>false</c>.</returns>
        public static bool Cancel(this LosingFocusEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets whether focus navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> if focus navigation should be canceled. Otherwise, <c>false</c>.</param>
        public static void Cancel(this LosingFocusEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Attempts to cancel the ongoing focus action.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns><c>true</c>, if the focus action is canceled; otherwise, <c>false</c>.</returns>
        public static bool TryCancelWrapped(this LosingFocusEventArgs e) => Resolver.TryCancel(e);

        /// <summary>
        /// Attempts to redirect focus from the targeted element to the specified element.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <param name="element">The object on which to set focus.</param>
        /// <returns><c>true</c>, if the focus action is redirected; otherwise, <c>false</c>.</returns>
        public static bool TrySetNewFocusedElementWrapped(this LosingFocusEventArgs e, DependencyObject element) => Resolver.TrySetNewFocusedElement(e, element);

        /// <summary>
        /// Gets the unique ID generated when a focus movement event is initiated.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The unique ID, if any. Otherwise, <c>null</c>. The default is <c>null</c>.</returns>
        public static Guid CorrelationId(LosingFocusEventArgs e) => Resolver.CorrelationId(e);

        private sealed class DefaultLosingFocusEventArgsResolver : ILosingFocusEventArgsResolver
        {
            object ILosingFocusEventArgsResolver.OriginalSource(LosingFocusEventArgs e) => e.OriginalSource;
            DependencyObject ILosingFocusEventArgsResolver.OldFocusedElement(LosingFocusEventArgs e) => e.OldFocusedElement;
            DependencyObject ILosingFocusEventArgsResolver.NewFocusedElement(LosingFocusEventArgs e) => e.NewFocusedElement;
            void ILosingFocusEventArgsResolver.NewFocusedElement(LosingFocusEventArgs e, DependencyObject newFocusedElement) => e.NewFocusedElement = newFocusedElement;
            FocusState ILosingFocusEventArgsResolver.FocusState(LosingFocusEventArgs e) => e.FocusState;
            FocusNavigationDirection ILosingFocusEventArgsResolver.Direction(LosingFocusEventArgs e) => e.Direction;
            bool ILosingFocusEventArgsResolver.Handled(LosingFocusEventArgs e) => e.Handled;
            void ILosingFocusEventArgsResolver.Handled(LosingFocusEventArgs e, bool handled) => e.Handled = handled;
            FocusInputDeviceKind ILosingFocusEventArgsResolver.InputDevice(LosingFocusEventArgs e) => e.InputDevice;
            bool ILosingFocusEventArgsResolver.Cancel(LosingFocusEventArgs e) => e.Cancel;
            void ILosingFocusEventArgsResolver.Cancel(LosingFocusEventArgs e, bool cancel) => e.Cancel = cancel;
            bool ILosingFocusEventArgsResolver.TryCancel(LosingFocusEventArgs e) => e.TryCancel();
            bool ILosingFocusEventArgsResolver.TrySetNewFocusedElement(LosingFocusEventArgs e, DependencyObject element) => e.TrySetNewFocusedElement(element);
            Guid ILosingFocusEventArgsResolver.CorrelationId(LosingFocusEventArgs e) => e.CorrelationId;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="LosingFocusEventArgs"/>.
    /// </summary>
    public interface ILosingFocusEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(LosingFocusEventArgs e);

        /// <summary>
        /// Gets the last focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The last focused object.</returns>
        DependencyObject OldFocusedElement(LosingFocusEventArgs e);

        /// <summary>
        /// Gets the most recent focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The most recent focused object.</returns>
        DependencyObject NewFocusedElement(LosingFocusEventArgs e);

        /// <summary>
        /// Sets the most recent focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <param name="newFocusedElement">The most recent focused object.</param>
        void NewFocusedElement(LosingFocusEventArgs e, DependencyObject newFocusedElement);

        /// <summary>
        /// Gets the input mode through which an element obtained focus.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>How the element obtained focus.</returns>
        FocusState FocusState(LosingFocusEventArgs e);

        /// <summary>
        /// Gets the direction that focus moved from element to element within the app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The direction of focus movement.</returns>
        FocusNavigationDirection Direction(LosingFocusEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value for <see cref="LosingFocusEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        bool Handled(LosingFocusEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value for <see cref="LosingFocusEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>
        void Handled(LosingFocusEventArgs e, bool handled);

        /// <summary>
        /// Gets the input device type from which input events are received.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The input device type.</returns>
        FocusInputDeviceKind InputDevice(LosingFocusEventArgs e);

        /// <summary>
        /// Gets whether focus navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns><c>true</c> if focus navigation should be canceled. Otherwise, <c>false</c>.</returns>
        bool Cancel(LosingFocusEventArgs e);

        /// <summary>
        /// Sets whether focus navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> if focus navigation should be canceled. Otherwise, <c>false</c>.</param>
        void Cancel(LosingFocusEventArgs e, bool cancel);

        /// <summary>
        /// Attempts to cancel the ongoing focus action.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns><c>true</c>, if the focus action is canceled; otherwise, <c>false</c>.</returns>
        bool TryCancel(LosingFocusEventArgs e);

        /// <summary>
        /// Attempts to redirect focus from the targeted element to the specified element.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <param name="element">The object on which to set focus.</param>
        /// <returns><c>true</c>, if the focus action is redirected; otherwise, <c>false</c>.</returns>
        bool TrySetNewFocusedElement(LosingFocusEventArgs e, DependencyObject element);

        /// <summary>
        /// Gets the unique ID generated when a focus movement event is initiated.
        /// </summary>
        /// <param name="e">The requested <see cref="LosingFocusEventArgs"/>.</param>
        /// <returns>The unique ID, if any. Otherwise, <c>null</c>. The default is <c>null</c>.</returns>
        Guid CorrelationId(LosingFocusEventArgs e);
    }
}
