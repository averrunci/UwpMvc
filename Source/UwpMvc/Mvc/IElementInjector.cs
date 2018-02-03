// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc
{
    /// <summary>
    /// Provides the function to inject elements in a view to a UWP controller.
    /// </summary>
    public interface IElementInjector
    {
        /// <summary>
        /// Injects elements in the specified element to the specified UWP controller.
        /// </summary>
        /// <param name="rootElement">The element that contains elements that are injected to the UWP controller.</param>
        /// <param name="controller">The UWP controller to inject elements.</param>
        /// <param name="foundElementOnly">
        /// If <c>true</c>, an element is not set to the UWP controller when it is not found in the specified element;
        /// otherwise, <c>null</c> is set.
        /// </param>
        void Inject(FrameworkElement rootElement, object controller, bool foundElementOnly = false);
    }
}
