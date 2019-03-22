// Copyright (C) 2018-2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="FocusEngagedEventArgs"/>
    /// resolved by <see cref="IFocusEngagedEventArgsResolver"/>.
    /// </summary>
    public static class FocusEngagedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IFocusEngagedEventArgsResolver"/>
        /// that resolves data of the <see cref="FocusEngagedEventArgs"/>.
        /// </summary>
        public static IFocusEngagedEventArgsResolver Resolver { get; set; } = new DefaultFocusEngagedEventArgsResolver();

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusEngagedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(this FocusEngagedEventArgs e) => Resolver.OriginalSource(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value for Handled
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusEngagedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        public static bool Handled(this FocusEngagedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value for Handled
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusEngagedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>
        public static void Handled(this FocusEngagedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        private sealed class DefaultFocusEngagedEventArgsResolver : IFocusEngagedEventArgsResolver
        {
            object IFocusEngagedEventArgsResolver.OriginalSource(FocusEngagedEventArgs e) => e.OriginalSource;
            bool IFocusEngagedEventArgsResolver.Handled(FocusEngagedEventArgs e) => e.Handled;
            void IFocusEngagedEventArgsResolver.Handled(FocusEngagedEventArgs e, bool handled) => e.Handled = handled;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="FocusEngagedEventArgs"/>.
    /// </summary>
    public interface IFocusEngagedEventArgsResolver
    {
        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusEngagedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(FocusEngagedEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value for Handled
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusEngagedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        bool Handled(FocusEngagedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value for Handled
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="FocusEngagedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>
        void Handled(FocusEngagedEventArgs e, bool handled);
    }
}
