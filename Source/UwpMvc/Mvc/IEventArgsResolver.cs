// Copyright (C) 2019 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Provider actions of an event args resolver.
    /// </summary>
    public interface IEventArgsResolver : IDisposable
    {
        /// <summary>
        /// Configures the resolver.
        /// </summary>
        void Configure();

        /// <summary>
        /// Applies the resolver action.
        /// </summary>
        void Apply();
    }
}
