// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

using Xunit;

using Fievus.Windows.Mvc;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Home.HomeControllerTest
{
    public class HomeController_LogoutButtonClick
    {
        [Fact]
        public async Task ShouldLogoutUser()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var controller = new HomeController
                {
                    Content = new HomeContent("User")
                };

                var logoutRequested = false;
                controller.Content.LogoutRequested += (s, e) => logoutRequested = true;

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy("LogoutButton")
                    .Raise(nameof(Button.Click));

                Assert.True(logoutRequested);
            });
        }
    }
}
