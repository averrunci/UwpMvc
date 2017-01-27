// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Xunit;

using Fievus.Windows.Mvc;

using Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Home;
using Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation
{
    public class ApplicationHostControllerTest
    {
        [Fact]
        public async Task ShouldNavigateLoginPageOnLoaded()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var controller = new ApplicationHostController
                {
                    Host = new ApplicationHost(),
                    RootFrame = new Frame()
                };

                controller.RootFrame.Navigating += (s, e) =>
                {
                    Assert.Equal(typeof(LoginPage), e.SourcePageType);
                    Assert.Equal(controller.Host.InitialPageContent, e.Parameter);
                };

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy(null)
                    .Raise(nameof(FrameworkElement.Loaded));

                Assert.Equal(typeof(LoginPage), controller.RootFrame.CurrentSourcePageType);
            });
        }

        [Fact]
        public async Task ShouldNavigateSpecifiedInitialPageOnLoaded()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var controller = new ApplicationHostController
                {
                    Host = new ApplicationHost
                    {
                        InitialPageType = typeof(HomePage),
                        InitialPageContent = new HomeContent("User")
                    },
                    RootFrame = new Frame()
                };

                controller.RootFrame.Navigating += (s, e) =>
                {
                    Assert.Equal(typeof(HomePage), e.SourcePageType);
                    Assert.Equal(controller.Host.InitialPageContent, e.Parameter);
                };

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy(null)
                    .Raise(nameof(FrameworkElement.Loaded));

                Assert.Equal(typeof(HomePage), controller.RootFrame.CurrentSourcePageType);
            });
        }
    }
}
