// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Provides the function to find a type of a controller that controls the view.
    /// </summary>
    public interface IUwpControllerTypeFinder : IControllerTypeFinder<FrameworkElement>
    {
        /// <summary>
        /// Gets the container that contains all controller that is defined in a project.
        /// </summary>
        IUwpControllerTypeContainer ControllerTypeContainer { get; set; }
    }
}
