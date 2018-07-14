// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="DataContextChangedEventArgs"/>
    /// resolved by <see cref="IDataContextChangedEventArgsResolver"/>.
    /// </summary>
    public static class DataContextChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IDataContextChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="DataContextChangedEventArgs"/>.
        /// </summary>
        public static IDataContextChangedEventArgsResolver Resolver { get; set; } = new DefaultIDataContextChangedEventArgsResolver();

        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DataContextChangedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        public static bool Handled(this DataContextChangedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DataContextChangedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        public static void Handled(this DataContextChangedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets the new <see cref="FrameworkElement.DataContext"/> value for the element
        /// where the <see cref="FrameworkElement.DataContextChanged"/> event fired.
        /// </summary>
        /// <param name="e">The requested <see cref="DataContextChangedEventArgs"/></param>
        /// <returns>
        /// An object representing the new <see cref="FrameworkElement.DataContext"/> value for the element
        /// where the <see cref="FrameworkElement.DataContextChanged"/> event fired.
        /// </returns>
        public static object NewValue(this DataContextChangedEventArgs e) => Resolver.NewValue(e);

        private sealed class DefaultIDataContextChangedEventArgsResolver : IDataContextChangedEventArgsResolver
        {
            bool IDataContextChangedEventArgsResolver.Handled(DataContextChangedEventArgs e) => e.Handled;
            void IDataContextChangedEventArgsResolver.Handled(DataContextChangedEventArgs e, bool handled) => e.Handled = handled;
            object IDataContextChangedEventArgsResolver.NewValue(DataContextChangedEventArgs e) => e.NewValue;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="DataContextChangedEventArgs"/>.
    /// </summary>
    public interface IDataContextChangedEventArgsResolver
    {
        /// <summary>
        /// Gets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DataContextChangedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </returns>
        bool Handled(DataContextChangedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled.
        /// A <c>true</c> value prevents most handlers along the event
        /// route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="DataContextChangedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled.
        /// <c>false</c> to leave the routed event unhandled, which permits the event to potentially
        /// route further and be acted on by other handlers.
        /// </param>
        void Handled(DataContextChangedEventArgs e, bool handled);

        /// <summary>
        /// Gets the new <see cref="FrameworkElement.DataContext"/> value for the element
        /// where the <see cref="FrameworkElement.DataContextChanged"/> event fired.
        /// </summary>
        /// <param name="e">The requested <see cref="DataContextChangedEventArgs"/></param>
        /// <returns>
        /// An object representing the new <see cref="FrameworkElement.DataContext"/> value for the element
        /// where the <see cref="FrameworkElement.DataContextChanged"/> event fired.
        /// </returns>
        object NewValue(DataContextChangedEventArgs e);
    }
}
