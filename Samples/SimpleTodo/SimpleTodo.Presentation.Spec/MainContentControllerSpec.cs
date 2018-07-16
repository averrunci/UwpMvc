// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Threading.Tasks;
using Windows.ApplicationModel.Core;
using Windows.System;
using Windows.UI.Core;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Carna;
using Charites.Windows.Mvc;
using Charites.Windows.Mvc.Wrappers;
using NSubstitute;

namespace Charites.Windows.Samples.SimpleTodo.Presentation
{
    [Specification("MainContentController Spec")]
    class MainContentControllerSpec : FixtureSteppable
    {
        MainContentController Controller { get; } = new MainContentController();
        MainContent Content { get; } = new MainContent();

        string TodoContent { get; } = "Todo Item";

        public MainContentControllerSpec()
        {
            UwpController.SetDataContext(Content, Controller);
        }

        [Example("The IsChecked of the AllCompletedCheckBox is set to null when the AllCompleted of the content does not have a value")]
        async Task Ex01()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var allCompletedCheckBox = new CheckBox { Name = "AllCompletedCheckBox" };
                UwpController.SetElement(allCompletedCheckBox, Controller, true);
                When("AllCompleted of the content is set to true", () => Content.AllCompleted.Value = true);
                When("IsChecked of the AllCompletedCheckBox is set to true", () => allCompletedCheckBox.IsChecked = true);
                When("the element is loaded", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy(null)
                        .Raise(nameof(FrameworkElement.Loaded))
                );
                When("the AllCompleted of the content is set to null", () => Content.AllCompleted.Value = null);
                Then("the IsChecked of the AllCompletedCheckBox should be null", () => allCompletedCheckBox.IsChecked = null);
            });
        }

        [Example("A to-do item is added when the Enter key is pressed")]
        void Ex02()
        {
            When("the content of the to-do is set", () => Content.TodoContent.Value = TodoContent);
            When("the Enter key is pressed", () =>
            {
                UwpController.Using(Substitute.For<IKeyRoutedEventArgsResolver>(), typeof(KeyRoutedEventArgsWrapper))
                    .Apply(resolver => resolver.Key(null).Returns(VirtualKey.Enter))
                    .EventHandlersOf(Controller)
                    .GetBy("TodoContentTextBox")
                    .Raise(nameof(UIElement.KeyDown));
            });
            Then("a to-do item should be added", () => Content.TodoItems.Count == 1);
        }

        [Example("A to-do item is not added when the Tab key is pressed")]
        void Ex03()
        {
            When("the content of the to-do is set", () => Content.TodoContent.Value = TodoContent);
            When("the Tab key is pressed", () =>
            {
                UwpController.Using(Substitute.For<IKeyRoutedEventArgsResolver>(), typeof(KeyRoutedEventArgsWrapper))
                    .Apply(resolver => resolver.Key(Arg.Any<KeyRoutedEventArgs>()).Returns(VirtualKey.Tab))
                    .EventHandlersOf(Controller)
                    .GetBy("TodoContentTextBox")
                    .Raise(nameof(UIElement.KeyDown));
            });
            Then("a to-do item should not be added", () => Content.TodoItems.Count == 0);
        }
    }
}
