// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

using Xunit;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    public class HomeContentTest
    {
        [Fact]
        public async Task ShouldRaiseLogoutRequestedEventWhenLogoutIsCalled()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var homeContent = new HomeContent("User");

                var logoutRequested = false;
                homeContent.LogoutRequested += (s, e) => logoutRequested = true;

                homeContent.Logout();

                Assert.True(logoutRequested);
            });
        }
    }
}
