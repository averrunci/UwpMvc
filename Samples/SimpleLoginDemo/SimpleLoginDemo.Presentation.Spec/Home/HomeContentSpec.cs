// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;
using Carna;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    [Specification("HomeContent Spec")]
    class HomeContentSpec : FixtureSteppable
    {
        [Example("Raised the LogoutRequested event")]
        async Task Ex01()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                HomeContent content = null;
                var logoutRequested = false;

                Given("a HomeContent", () =>
                {
                    content = new HomeContent("User");
                    content.LogoutRequested += (s, e) => logoutRequested = true;
                });
                When("to log out", () => content.Logout());
                Then("the LogoutRequested event should be raised", () => logoutRequested);
            });
        }
    }
}
