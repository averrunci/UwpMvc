// Copyright (C) 2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using Windows.System;

namespace Charites.Windows.Mvc.Wrappers
{
    /// <summary>
    /// Provides data of the <see cref="UserChangedEventArgs"/>
    /// resolved by <see cref="IUserChangedEventArgsResolver"/>.
    /// </summary>
    public static class UserChangedEventArgsWrapper
    {
        /// <summary>
        /// Gets or sets the <see cref="IUserChangedEventArgsResolver"/>
        /// that resolves data of the <see cref="UserChangedEventArgs"/>.
        /// </summary>
        public static IUserChangedEventArgsResolver Resolver { get; set; } = new DefaultUserChangedEventArgsResolver();

        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="e">The requested <see cref="UserChangedEventArgs"/>.</param>
        /// <returns>The user.</returns>
        public static User User(this UserChangedEventArgs e) => Resolver.User(e);

        /// <summary>
        /// Describes the kinds of changes that triggered the UserChangedEvent.
        /// </summary>
        /// <param name="e">The requested <see cref="UserChangedEventArgs"/>.</param>
        /// <returns>A list of <see cref="UserWatcherUpdateKind"/> that describe the changes to the user.</returns>
        public static IReadOnlyList<UserWatcherUpdateKind> ChangedPropertyKinds(this UserChangedEventArgs e) => Resolver.ChangedPropertyKinds(e);

        private sealed class DefaultUserChangedEventArgsResolver : IUserChangedEventArgsResolver
        {
            User IUserChangedEventArgsResolver.User(UserChangedEventArgs e) => e.User;
            IReadOnlyList<UserWatcherUpdateKind> IUserChangedEventArgsResolver.ChangedPropertyKinds(UserChangedEventArgs e) => e.ChangedPropertyKinds;
        }
    }

    /// <summary>
    /// Resolves data of the <see cref="UserChangedEventArgs"/>.
    /// </summary>
    public interface IUserChangedEventArgsResolver
    {
        /// <summary>
        /// Gets the user.
        /// </summary>
        /// <param name="e">The requested <see cref="UserChangedEventArgs"/>.</param>
        /// <returns>The user.</returns>
        User User(UserChangedEventArgs e);

        /// <summary>
        /// Describes the kinds of changes that triggered the UserChangedEvent.
        /// </summary>
        /// <param name="e">The requested <see cref="UserChangedEventArgs"/>.</param>
        /// <returns>A list of <see cref="UserWatcherUpdateKind"/> that describe the changes to the user.</returns>
        IReadOnlyList<UserWatcherUpdateKind> ChangedPropertyKinds(UserChangedEventArgs e);
    }
}
