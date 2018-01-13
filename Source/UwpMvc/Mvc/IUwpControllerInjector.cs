// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
namespace Fievus.Windows.Mvc
{
    /// <summary>
    /// Provides the function to inject dependency components to the specified UWP controller.
    /// </summary>
    public interface IUwpControllerInjector
    {
        /// <summary>
        /// Injects dependency components to the specified UWP controller.
        /// </summary>
        /// <param name="controller">The UWP controller to inject dependency components.</param>
        void Inject(object controller);
    }
}
