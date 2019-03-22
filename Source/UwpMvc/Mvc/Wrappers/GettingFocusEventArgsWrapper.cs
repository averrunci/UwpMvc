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
    /// Provides data of the <see cref="GettingFocusEventArgs"/>
    /// resolved by <see cref="IGettingFocusEventArgsResolver"/>.
    /// </summary>
    public static class GettingFocusEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IGettingFocusEventArgsResolver"/>
        /// that resolves data of the <see cref="GettingFocusEventArgs"/>.
        /// </summary>
        public static IGettingFocusEventArgsResolver Resolver { get; set; } = new DefaultGettingFocusEventArgsResolver();

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this GettingFocusEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets the last focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The last focused object.</returns>
        public static DependencyObject OldFocusedElement(this GettingFocusEventArgs e) => Resolver.OldFocusedElement(e);

        /// <summary>
        /// Gets the most recent focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The most recent focused object.</returns>
        public static DependencyObject NewFocusedElement(this GettingFocusEventArgs e) => Resolver.NewFocusedElement(e);

        /// <summary>
        /// Sets the most recent focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <param name="newFocusedElement">The most recent focused object.</param>
        public static void NewFocusedElement(this GettingFocusEventArgs e, DependencyObject newFocusedElement) => Resolver.NewFocusedElement(e, newFocusedElement);

        /// <summary>
        /// Gets the input mode through which an element obtained focus.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>How the element obtained focus.</returns>
        public static FocusState FocusState(this GettingFocusEventArgs e) => Resolver.FocusState(e);

        /// <summary>
        /// Gets the direction that focus moved from element to element within the app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The direction of focus movement.</returns>
        public static FocusNavigationDirection Direction(this GettingFocusEventArgs e) => Resolver.Direction(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value for <see cref="GettingFocusEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        public static bool Handled(this GettingFocusEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value for <see cref="GettingFocusEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>
        public static void Handled(this GettingFocusEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the input device type from which input events are received.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The input device type.</returns>
        public static FocusInputDeviceKind InputDevice(this GettingFocusEventArgs e) => Resolver.InputDevice(e);

        /// <summary>
        /// Gets whether focus navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns><c>true</c> if focus navigation should be canceled. Otherwise, <c>false</c>.</returns>
        public static bool Cancel(this GettingFocusEventArgs e) => Resolver.Cancel(e);

        /// <summary>
        /// Sets whether focus navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> if focus navigation should be canceled. Otherwise, <c>false</c>.</param>
        public static void Cancel(this GettingFocusEventArgs e, bool cancel) => Resolver.Cancel(e, cancel);

        /// <summary>
        /// Attempts to cancel the ongoing focus action.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns><c>true</c>, if the focus action is canceled; otherwise, <c>false</c>.</returns>
        public static bool TryCancelWrapped(this GettingFocusEventArgs e) => Resolver.TryCancel(e);

        /// <summary>
        /// Attempts to redirect focus to the specified element instead of the original targeted element.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <param name="element">The object on which to set focus.</param>
        /// <returns><c>true</c>, if the focus action is redirected; otherwise, <c>false</c>.</returns>
        public static bool TrySetNewFocusedElementWrapped(this GettingFocusEventArgs e, DependencyObject element) => Resolver.TrySetNewFocusedElement(e, element);

        /// <summary>
        /// Gets the unique ID generated when a focus movement event is initiated.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The unique ID, if any. Otherwise, <c>null</c>. The default is <c>null</c>.</returns>
        public static Guid CorrelationId(this GettingFocusEventArgs e) => Resolver.CorrelationId(e);

        private sealed class DefaultGettingFocusEventArgsResolver : IGettingFocusEventArgsResolver
        {
            object IGettingFocusEventArgsResolver.OriginalSource(GettingFocusEventArgs e) => e.OriginalSource;
            DependencyObject IGettingFocusEventArgsResolver.OldFocusedElement(GettingFocusEventArgs e) => e.OldFocusedElement;
            DependencyObject IGettingFocusEventArgsResolver.NewFocusedElement(GettingFocusEventArgs e) => e.NewFocusedElement;
            void IGettingFocusEventArgsResolver.NewFocusedElement(GettingFocusEventArgs e, DependencyObject newFocusedElement) => e.NewFocusedElement = newFocusedElement;
            FocusState IGettingFocusEventArgsResolver.FocusState(GettingFocusEventArgs e) => e.FocusState;
            FocusNavigationDirection IGettingFocusEventArgsResolver.Direction(GettingFocusEventArgs e) => e.Direction;
            bool IGettingFocusEventArgsResolver.Handled(GettingFocusEventArgs e) => e.Handled;
            void IGettingFocusEventArgsResolver.Handled(GettingFocusEventArgs e, bool handled) => e.Handled = handled;
            FocusInputDeviceKind IGettingFocusEventArgsResolver.InputDevice(GettingFocusEventArgs e) => e.InputDevice;
            bool IGettingFocusEventArgsResolver.Cancel(GettingFocusEventArgs e) => e.Cancel;
            void IGettingFocusEventArgsResolver.Cancel(GettingFocusEventArgs e, bool cancel) => e.Cancel = cancel;
            bool IGettingFocusEventArgsResolver.TryCancel(GettingFocusEventArgs e) => e.TryCancel();
            bool IGettingFocusEventArgsResolver.TrySetNewFocusedElement(GettingFocusEventArgs e, DependencyObject element) => e.TrySetNewFocusedElement(element);
            Guid IGettingFocusEventArgsResolver.CorrelationId(GettingFocusEventArgs e) => e.CorrelationId;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="GettingFocusEventArgs"/>.
    /// </summary>
    public interface IGettingFocusEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(GettingFocusEventArgs e);

        /// <summary>
        /// Gets the last focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The last focused object.</returns>
        DependencyObject OldFocusedElement(GettingFocusEventArgs e);

        /// <summary>
        /// Gets the most recent focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The most recent focused object.</returns>
        DependencyObject NewFocusedElement(GettingFocusEventArgs e);

        /// <summary>
        /// Sets the most recent focused object.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <param name="newFocusedElement">The most recent focused object.</param>
        void NewFocusedElement(GettingFocusEventArgs e, DependencyObject newFocusedElement);

        /// <summary>
        /// Gets the input mode through which an element obtained focus.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>How the element obtained focus.</returns>
        FocusState FocusState(GettingFocusEventArgs e);

        /// <summary>
        /// Gets the direction that focus moved from element to element within the app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The direction of focus movement.</returns>
        FocusNavigationDirection Direction(GettingFocusEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value for <see cref="GettingFocusEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        bool Handled(GettingFocusEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value for <see cref="GettingFocusEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>
        void Handled(GettingFocusEventArgs e, bool handled);

        /// <summary>
        /// Gets the input device type from which input events are received.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The input device type.</returns>
        FocusInputDeviceKind InputDevice(GettingFocusEventArgs e);

        /// <summary>
        /// Gets whether focus navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns><c>true</c> if focus navigation should be canceled. Otherwise, <c>false</c>.</returns>
        bool Cancel(GettingFocusEventArgs e);

        /// <summary>
        /// Sets whether focus navigation should be canceled.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <param name="cancel"><c>true</c> if focus navigation should be canceled. Otherwise, <c>false</c>.</param>
        void Cancel(GettingFocusEventArgs e, bool cancel);

        /// <summary>
        /// Attempts to cancel the ongoing focus action.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns><c>true</c>, if the focus action is canceled; otherwise, <c>false</c>.</returns>
        bool TryCancel(GettingFocusEventArgs e);

        /// <summary>
        /// Attempts to redirect focus to the specified element instead of the original targeted element.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <param name="element">The object on which to set focus.</param>
        /// <returns><c>true</c>, if the focus action is redirected; otherwise, <c>false</c>.</returns>
        bool TrySetNewFocusedElement(GettingFocusEventArgs e, DependencyObject element);

        /// <summary>
        /// Gets the unique ID generated when a focus movement event is initiated.
        /// </summary>
        /// <param name="e">The requested <see cref="GettingFocusEventArgs"/>.</param>
        /// <returns>The unique ID, if any. Otherwise, <c>null</c>. The default is <c>null</c>.</returns>
        Guid CorrelationId(GettingFocusEventArgs e);
    }
}
