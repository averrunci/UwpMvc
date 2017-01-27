// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

namespace Fievus.Windows.Mvc
{
    /// <summary>
    /// Provides the function to create a UWP controller.
    /// </summary>
    public interface IUwpControllerFactory
    {
        /// <summary>
        /// Creates a UWP controller.
        /// </summary>
        /// <param name="controllerType">The type of a UWP controller.</param>
        /// <returns>The new instance of a UWP controller.</returns>
        object Create(Type controllerType);
    }
}
