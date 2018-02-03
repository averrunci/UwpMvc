// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
namespace Fievus.Windows.Mvc
{
    /// <summary>
    /// Provides the function to inject a data context to a UWP controller.
    /// </summary>
    public interface IDataContextInjector
    {
        /// <summary>
        /// Injects the specified data context to the specified UWP controller.
        /// </summary>
        /// <param name="dataContext">The data context that is injected to the UWP controller.</param>
        /// <param name="controller">The UWP controller to inject a data context.</param>
        void Inject(object dataContext, object controller);
    }
}
