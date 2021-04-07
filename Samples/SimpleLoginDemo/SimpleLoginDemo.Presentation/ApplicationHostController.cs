// Copyright (C) 2018-2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml;
using Charites.Windows.Mvc;
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation
{
    [View(Key = nameof(ApplicationHost))]
    public class ApplicationHostController : IDisposable
    {
        private IContentNavigator Navigator { get; }

        [DataContext]
        public ApplicationHost Host { get; set; }

        public ApplicationHostController(IContentNavigator navigator)
        {
            Navigator = navigator.RequireNonNull(nameof(navigator));

            SubscribeContentNavigatorEvent();
        }

        public void Dispose()
        {
            UnsubscribeContentNavigatorEvent();
        }

        private void SubscribeContentNavigatorEvent()
        {
            Navigator.Navigated += OnContentNavigated;
        }

        private void UnsubscribeContentNavigatorEvent()
        {
            Navigator.Navigated -= OnContentNavigated;
        }

        private void OnContentNavigated(object sender, ContentNavigatedEventArgs e)
        {
            Host.Content.Value = e.Content;
        }

        [EventHandler(Event = nameof(FrameworkElement.Loaded))]
        private void OnLoaded()
        {
            Navigator.NavigateTo(new LoginContent());
        }
    }
}
