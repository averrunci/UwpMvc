// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls.Primitives;
using Carna;
using Charites.Windows.Mvc;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    [Specification("HomeController Spec")]
    class HomeControllerSpec : FixtureSteppable
    {
        [Example("Logs the user out")]
        async Task Ex01()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                HomeController controller = null;
                HomeContent content = new HomeContent("User");
                var logoutRequested = false;

                Given("a HomeController", () =>
                {
                    controller = new HomeController();
                    UwpController.SetDataContext(content, controller);
                    content.LogoutRequested += (s, e) => logoutRequested = true;
                });
                When("to log out", () =>
                    UwpController.EventHandlersOf(controller)
                        .GetBy("LogoutButton")
                        .Raise(nameof(ButtonBase.Click))
                );
                Then("the LogoutRequested event should be raised", () => logoutRequested);
            });
        }
    }
}
