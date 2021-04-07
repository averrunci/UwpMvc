// Copyright (C) 2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml;
using Carna;
using Charites.Windows.Mvc;
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login;
using NSubstitute;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation
{
    [Specification("ApplicationHostController Spec")]
    class ApplicationHostControllerSpec : FixtureSteppable
    {
        ApplicationHostController Controller { get; }
        ApplicationHost Host { get; } = new ApplicationHost();
        IContentNavigator Navigator { get; } = Substitute.For<IContentNavigator>();

        object NextContent { get; } = new object();

        public ApplicationHostControllerSpec()
        {
            Controller = new ApplicationHostController(Navigator);

            UwpController.SetDataContext(Host, Controller);
        }

        [Example("Navigates an initial content when the ApplicationHost is loaded")]
        void Ex01()
        {
            When("the ApplicationHost is loaded", () =>
                UwpController.EventHandlersOf(Controller)
                    .GetBy(null)
                    .Raise(nameof(FrameworkElement.Loaded))
            );
            Then("the content should be navigated to the LoginContent", () =>
            {
                Navigator.Received(1).NavigateTo(Arg.Any<LoginContent>());
            });
        }

        [Example("Sets a new content when the current content is navigated")]
        void Ex02()
        {
            When("the content is navigated to the next content", () =>
                Navigator.Navigated += Raise.EventWith(Navigator, new ContentNavigatedEventArgs(ContentNavigationMode.New, NextContent, Host.Content.Value))
            );
            Then("the content to navigate should be set to the content of the ApplicationHost", () => Host.Content.Value == NextContent);
        }

        [Example("Invalid instance creation")]
        void Ex03()
        {
            When("an instance is created with the IContentNavigator that is null", () => new ApplicationHostController(null));
            Then<ArgumentNullException>($"{typeof(ArgumentNullException)} should be thrown");
        }
    }
}
