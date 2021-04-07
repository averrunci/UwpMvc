// Copyright (C) 2018-2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Controls.Primitives;
using Carna;
using Charites.Windows.Mvc;
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login;
using NSubstitute;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    [Specification("HomeController Spec")]
    class HomeControllerSpec : FixtureSteppable
    {
        HomeController Controller { get; }
        IContentNavigator Navigator { get; } = Substitute.For<IContentNavigator>();

        public HomeControllerSpec()
        {
            Controller = new HomeController(Navigator);
        }

        [Example("Logs the user out")]
        void Ex01()
        {
            When("to log out", () =>
                UwpController.EventHandlersOf(Controller)
                    .GetBy("LogoutButton")
                    .Raise(nameof(ButtonBase.Click))
            );
            Then("the content should be navigated to the LoginContent", () =>
            {
                Navigator.Received(1).NavigateTo(Arg.Any<LoginContent>());
            });
        }

        [Example("Invalid instance creation")]
        void Ex02()
        {
            When("an instance is created with the IContentNavigator that is null", () => new HomeController(null));
            Then<ArgumentNullException>($"{typeof(ArgumentNullException)} should be thrown");
        }
    }
}
