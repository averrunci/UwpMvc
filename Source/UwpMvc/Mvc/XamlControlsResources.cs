// Copyright (C) 2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    /// <summary>
    /// Default styles for the controls in the UwpMvc.
    /// </summary>
    public class XamlControlsResources : ResourceDictionary
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="XamlControlsResources"/> class.
        /// </summary>
        public XamlControlsResources()
        {
            Source = new Uri("ms-appx:///UwpMvc/Resources.xaml");
        }
    }
}
