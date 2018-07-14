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
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Markup;
using Carna;
using Charites.Windows.Mvc;
using Charites.Windows.Mvc.Wrappers;
using NSubstitute;

namespace Charites.Windows.Samples.SimpleTodo.Presentation
{
    [Specification("TodoItemController Spec")]
    class TodoItemControllerSpec : FixtureSteppable, IDisposable
    {
        TodoItemController Controller { get; } = new TodoItemController();
        TodoItem TodoItem { get; }

        string InitialContent { get; } = "Todo Item";
        string ModifiedContent { get; } = "Todo Item Modified";

        bool RemoveRequested { get; set; }

        IKeyRoutedEventArgsResolver KeyRoutedEventArgsResolver { get; } = Substitute.For<IKeyRoutedEventArgsResolver>();
        IKeyRoutedEventArgsResolver OriginalKeyRoutedEventArgsResolver { get; }

        public TodoItemControllerSpec()
        {
            TodoItem = new TodoItem(InitialContent);
            TodoItem.RemoveRequested += (s, e) => RemoveRequested = true;
            UwpController.SetDataContext(TodoItem, Controller);
            
            OriginalKeyRoutedEventArgsResolver = KeyRoutedEventArgsWrapper.Resolver;
            KeyRoutedEventArgsWrapper.Resolver = KeyRoutedEventArgsResolver;
        }

        public void Dispose()
        {
            KeyRoutedEventArgsWrapper.Resolver = OriginalKeyRoutedEventArgsResolver;
        }

        [Example("Changes the visual state when the pointer is over an element")]
        async Task Ex01()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                Grid element = null;
                Given("an element with a visual state", () =>
                {
                    element = new Grid { Name = "TodoItemContainer" };
                    VisualStateManager.GetVisualStateGroups(element).Add(XamlReader.Load(@"
<VisualStateGroup xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                  xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
    <VisualState x:Name=""Normal"" />
    <VisualState x:Name=""PointerOver"" />
</VisualStateGroup>
") as VisualStateGroup);
                });
                UwpController.SetElement(new UserControl { Name = "Root", Content = element }, Controller);
                When("a pointer enters into the element", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy(element.Name)
                        .From(element)
                        .Raise(nameof(UIElement.PointerEntered))
                );
                Then("the current state of the element should be 'PointerOver'", () => VisualStateManager.GetVisualStateGroups(element)[0].CurrentState.Name == "PointerOver");
                When("a pointer exits the element", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy(element.Name)
                        .From(element)
                        .Raise(nameof(UIElement.PointerExited))
                );
                Then("the current state of the element should be 'Normal'", () => VisualStateManager.GetVisualStateGroups(element)[0].CurrentState.Name == "Normal");
            });
        }

        [Example("Switches a content to an edit mode when the element is double tapped")]
        async Task Ex02()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                UwpController.SetElement(new TextBox { Name = "TodoContentTextBox" }, Controller, true);
                When("the element is double tapped", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy("TodoItemContainer")
                        .Raise(nameof(UIElement.DoubleTapped))
                );
                Then("the to-do item should be editing", () => TodoItem.Editing.Value);
                Then("the edit content of the to-do item should be the initial content", () => TodoItem.EditContent.Value == InitialContent);
            });
        }

        [Example("Completes an edit when the Enter key is pressed")]
        async Task Ex03()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                UwpController.SetElement(new TextBox { Name = "TodoContentTextBox" }, Controller, true);
                When("the element is double tapped", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy("TodoItemContainer")
                        .Raise(nameof(UIElement.DoubleTapped))
                );
                When("the content is modified", () => TodoItem.EditContent.Value = ModifiedContent);
                When("the Enter key is pressed", () =>
                {
                    KeyRoutedEventArgsResolver.Key(Arg.Any<KeyRoutedEventArgs>()).Returns(VirtualKey.Enter);
                    UwpController.EventHandlersOf(Controller)
                        .GetBy("TodoContentTextBox")
                        .Raise(nameof(UIElement.KeyDown));
                });
                Then("the to-do item should not be editing", () => !TodoItem.Editing.Value);
                Then("the content of the to-do item should be the modified content", () => TodoItem.Content.Value == ModifiedContent);
            });
        }

        [Example("Completes an edit when the focus is lost")]
        async Task Ex04()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                UwpController.SetElement(new TextBox { Name = "TodoContentTextBox" }, Controller, true);
                When("the element is double tapped", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy("TodoItemContainer")
                        .Raise(nameof(UIElement.DoubleTapped))
                );
                When("the content is modified", () => TodoItem.EditContent.Value = ModifiedContent);
                When("the focus is lost", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy("TodoContentTextBox")
                        .Raise(nameof(UIElement.LostFocus))
                );
                Then("the to-do item should not be editing", () => !TodoItem.Editing.Value);
                Then("the content of the to-do item should be the modified content", () => TodoItem.Content.Value == ModifiedContent);
            });
        }

        [Example("Cancels an edit when the Esc key is pressed")]
        async Task Ex05()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                UwpController.SetElement(new TextBox { Name = "TodoContentTextBox" }, Controller, true);
                When("the element is double tapped", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy("TodoItemContainer")
                        .Raise(nameof(UIElement.DoubleTapped))
                );
                When("the content is modified", () => TodoItem.EditContent.Value = ModifiedContent);
                When("the Esc key is pressed", () =>
                {
                    KeyRoutedEventArgsResolver.Key(Arg.Any<KeyRoutedEventArgs>()).Returns(VirtualKey.Escape);
                    UwpController.EventHandlersOf(Controller)
                        .GetBy("TodoContentTextBox")
                        .Raise(nameof(UIElement.KeyDown));
                });
                Then("the to-do item should not be editing", () => !TodoItem.Editing.Value);
                Then("the content of the to-do item should be the initial content", () => TodoItem.Content.Value == InitialContent);
            });
        }

        [Example("Removes a to-do item when the delete button is clicked")]
        async Task Ex06()
        {
            await  CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                When("the delete button is clicked", () =>
                    UwpController.EventHandlersOf(Controller)
                        .GetBy("DeleteButton")
                        .Raise(nameof(ButtonBase.Click))
                );
                Then("it should be requested to remove the to-do item", () => RemoveRequested);
            });
        }
    }
}
