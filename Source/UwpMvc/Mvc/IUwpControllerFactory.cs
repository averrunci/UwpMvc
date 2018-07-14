// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Provides the function to create a controller.
    /// </summary>
    public interface IUwpControllerFactory
    {
        /// <summary>
        /// Creates a controller.
        /// </summary>
        /// <param name="controllerType">The type of a controller.</param>
        /// <returns>The new instance of a controller.</returns>
        object Create(Type controllerType);
    }
}
