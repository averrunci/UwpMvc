// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.ApplicationModel.Resources;
using Windows.UI.Core;
using Windows.UI.Xaml.Controls;

using Xunit;

using Fievus.Windows.Mvc;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login.LoginContentControllerTest
{
    public class LoginContentController_LoginButtonClick
    {
        [Fact]
        public void ShouldLoginUserWhenUserIsAuthenticated()
        {
            var userAuthentication = new StubIUserAuthentication()
                .Authenticate(user => UserAuthenticationResult.Success);
            var controller = new LoginController(userAuthentication)
            {
                Content = new LoginContent()
            };
            controller.Content.UserId.Value = "user";
            controller.Content.Password.Value = "password";

            var loginRequested = false;
            controller.Content.LoginRequested += (s, e) => loginRequested = true;

            UwpController.RetrieveEventHandlers(controller)
                .GetBy("LoginButton")
                .Raise(nameof(Button.Click));

            Assert.True(loginRequested);
        }

        [Fact]
        public void ShouldClearMessageWhenLoginContentIsNotValid()
        {
            var userAuthentication = new StubIUserAuthentication()
                .Authenticate(user => UserAuthenticationResult.Success);
            var controller = new LoginController(userAuthentication)
            {
                Content = new LoginContent()
            };
            controller.Content.Message.Value = "message";

            UwpController.RetrieveEventHandlers(controller)
                .GetBy("LoginButton")
                .Raise(nameof(Button.Click));

            Assert.Empty(controller.Content.Message.Value);
        }

        [Fact]
        public async Task ShouldShowLoginFailureMessageWhenUserAuthenticationIsFailed()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var userAuthentication = new StubIUserAuthentication()
                    .Authenticate(user => UserAuthenticationResult.Failure);
                var controller = new LoginController(userAuthentication)
                {
                    Content = new LoginContent()
                };
                controller.Content.UserId.Value = "user";
                controller.Content.Password.Value = "password";

                var loginRequested = false;
                controller.Content.LoginRequested += (s, e) => loginRequested = true;

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy("LoginButton")
                    .Raise(nameof(Button.Click));

                Assert.False(loginRequested);
                Assert.Equal(ResourceLoader.GetForCurrentView("SimpleLoginDemo.Presentation/Resources").GetString("LoginFailure"), controller.Content.Message.Value);
            });
        }

        [Fact]
        public void ShouldThrowExceptionWhenUserAuthenticationInterfaceIsNotSpecified()
        {
            Assert.Throws<ArgumentNullException>(() => new LoginController(null));
        }
    }
}
