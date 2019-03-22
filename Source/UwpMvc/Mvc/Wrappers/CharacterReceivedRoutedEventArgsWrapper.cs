// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Core;
using Windows.UI.Xaml.Input;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="CharacterReceivedRoutedEventArgs"/>
    /// resolved by <see cref="ICharacterReceivedRoutedEventArgsResolver"/>.
    /// </summary>
    public static class CharacterReceivedRoutedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="ICharacterReceivedRoutedEventArgsResolver"/>
        /// that resolves data of the <see cref="CharacterReceivedRoutedEventArgs"/>.
        /// </summary>
        public static ICharacterReceivedRoutedEventArgsResolver Resolver { get; set; } = new DefaultCharacterReceivedRoutedEventArgsResolver();

        /// <summary>
        /// Gets the composed character associated with the UIElement.CharacterReceived event.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <returns>
        /// The composed character associated with the UIElement.CharacterReceived event.
        /// </returns>
        public static char Character(this CharacterReceivedRoutedEventArgs e) => Resolver.Character(e);

        /// <summary>
        /// Gets the status of the physical key that raised the character-received event.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <returns>The status of the key that was pressed.</returns>
        public static CorePhysicalKeyStatus KeyStatus(this CharacterReceivedRoutedEventArgs e) => Resolver.KeyStatus(e);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value for <see cref="CharacterReceivedRoutedEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        public static bool Handled(this CharacterReceivedRoutedEventArgs e) => Resolver.Handled(e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value for <see cref="CharacterReceivedRoutedEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>
        public static void Handled(this CharacterReceivedRoutedEventArgs e, bool handled) => Resolver.Handled(e, handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        public static object OriginalSource(CharacterReceivedRoutedEventArgs e) => Resolver.OriginalSource(e);

        private sealed class DefaultCharacterReceivedRoutedEventArgsResolver : ICharacterReceivedRoutedEventArgsResolver
        {
            char ICharacterReceivedRoutedEventArgsResolver.Character(CharacterReceivedRoutedEventArgs e) => e.Character;
            CorePhysicalKeyStatus ICharacterReceivedRoutedEventArgsResolver.KeyStatus(CharacterReceivedRoutedEventArgs e) => e.KeyStatus;
            bool ICharacterReceivedRoutedEventArgsResolver.Handled(CharacterReceivedRoutedEventArgs e) => e.Handled;
            void ICharacterReceivedRoutedEventArgsResolver.Handled(CharacterReceivedRoutedEventArgs e, bool handled) => e.Handled = handled;
            object ICharacterReceivedRoutedEventArgsResolver.OriginalSource(CharacterReceivedRoutedEventArgs e) => e.OriginalSource;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="CharacterReceivedRoutedEventArgs"/>.
    /// </summary>
    public interface ICharacterReceivedRoutedEventArgsResolver
    {
        /// <summary>
        /// Gets the composed character associated with the UIElement.CharacterReceived event.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <returns>
        /// The composed character associated with the UIElement.CharacterReceived event.
        /// </returns>
        char Character(CharacterReceivedRoutedEventArgs e);

        /// <summary>
        /// Gets the status of the physical key that raised the character-received event.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <returns>The status of the key that was pressed.</returns>
        CorePhysicalKeyStatus KeyStatus(CharacterReceivedRoutedEventArgs e);

        /// <summary>
        /// Gets a value that marks the routed event as handled. A <c>true</c> value for <see cref="CharacterReceivedRoutedEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <returns>
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </returns>
        bool Handled(CharacterReceivedRoutedEventArgs e);

        /// <summary>
        /// Sets a value that marks the routed event as handled. A <c>true</c> value for <see cref="CharacterReceivedRoutedEventArgs.Handled"/>
        /// prevents most handlers along the event route from handling the same event again.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <param name="handled">
        /// <c>true</c> to mark the routed event handled. <c>false</c> to leave the routed event unhandled,
        /// which permits the event to potentially route further and be acted on by other handlers.
        /// The default is <c>false</c>.
        /// </param>
        void Handled(CharacterReceivedRoutedEventArgs e, bool handled);

        /// <summary>
        /// Gets a reference to the object that raised the event.
        /// This is often a template part of a control rather than an element that was declared in your app UI.
        /// </summary>
        /// <param name="e">The requested <see cref="CharacterReceivedRoutedEventArgs"/>.</param>
        /// <returns>The object that raised the event.</returns>
        object OriginalSource(CharacterReceivedRoutedEventArgs e);
    }
}
