// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;

using Fievus.Windows.Mvc;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation
{
    public class ApplicationHostController
    {
        [DataContext]
        public ApplicationHost Host { get; set; }

        [Element]
        public Frame RootFrame { get; set; }

        [EventHandler(Event = "Loaded")]
        private void OnLoaded()
        {
            RootFrame.Navigate(Host.InitialPageType, Host.InitialPageContent);
        }
    }
}
