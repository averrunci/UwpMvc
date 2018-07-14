// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Charites.Windows.Mvc;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation
{
    [View(Key = nameof(ApplicationHost))]
    public class ApplicationHostController
    {
        [DataContext]
        public ApplicationHost Host { get; set; }

        [Element]
        public Frame RootFrame { get; set; }

        [EventHandler(Event = nameof(FrameworkElement.Loaded))]
        private void OnLoaded()
        {
            RootFrame.Navigate(Host.InitialPageType, Host.InitialPageContent);
        }
    }
}
