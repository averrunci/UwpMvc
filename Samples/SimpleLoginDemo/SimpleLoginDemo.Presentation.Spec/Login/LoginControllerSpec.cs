// Copyright (C) 2018-2021 Fievus
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
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home;
using NSubstitute;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    [Specification("LoginController Spec")]
    class LoginControllerSpec : FixtureSteppable
    {
        LoginController LoginController { get; }
        LoginContent LoginContent { get; } = new LoginContent();
        IContentNavigator Navigator { get; } = Substitute.For<IContentNavigator>();
        IUserAuthentication UserAuthentication { get; } = Substitute.For<IUserAuthentication>();

        public LoginControllerSpec()
        {
            LoginController = new LoginController(Navigator, UserAuthentication);

            UwpController.SetDataContext(LoginContent, LoginController);
        }

        [Example("Logs the user in when the user is authenticated")]
        async Task Ex01()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                When("the authenticated user information is set", () =>
                {
                    UserAuthentication.Authenticate(LoginContent).Returns(UserAuthenticationResult.Success);

                    LoginContent.UserId.Value = "user";
                    LoginContent.Password.Value = "password";
                });
                When("the message is set", () => LoginContent.Message.Value = "message");
                When("to click the Login button", () =>
                    UwpController.EventHandlersOf(LoginController)
                        .GetBy("LoginButton")
                        .Raise(nameof(ButtonBase.Click))
                );
                Then("the content should be navigated to the HomeContent", () =>
                {
                    Navigator.Received(1).NavigateTo(Arg.Is<HomeContent>(content => content.Id == LoginContent.UserId.Value));
                });
                Then("the message should be empty", () => LoginContent.Message.Value == string.Empty);
            });
        }

        [Example("Shows login failure message when the user authentication is failed")]
        async Task Ex02()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                When("the unauthenticated user information is set", () =>
                {
                    UserAuthentication.Authenticate(LoginContent).Returns(UserAuthenticationResult.Failure);

                    LoginContent.UserId.Value = "user";
                    LoginContent.Password.Value = "password";
                });
                When("to click the Login button", () =>
                    UwpController.EventHandlersOf(LoginController)
                        .GetBy("LoginButton")
                        .Raise(nameof(ButtonBase.Click))
                );
                Then("the content should not be navigated to any contents", () =>
                {
                    Navigator.DidNotReceive().NavigateTo(Arg.Any<object>());
                });
                Then("the error message should be set", () => LoginContent.Message.Value == Resources.LoginFailure);
            });
        }

        [Example("Invalid instance creation")]
        void Ex03()
        {
            When("an instance is created with the IContentNavigator that is null", () => new LoginController(null, UserAuthentication));
            Then<ArgumentNullException>($"{typeof(ArgumentNullException)} should be thrown");

            When("an instance is created with the IUserAuthentication that is null", () => new LoginController(Navigator, null));
            Then<ArgumentNullException>($"{typeof(ArgumentNullException)} should be thrown");
        }
    }
}
