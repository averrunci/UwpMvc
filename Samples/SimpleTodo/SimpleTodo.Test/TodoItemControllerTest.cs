// Copyright (C) 2017 Fievus
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
using Windows.UI.Xaml.Markup;

using Xunit;

using Fievus.Windows.Mvc;
using Fievus.Windows.Mvc.Wrappers;

namespace Fievus.Windows.Samples.SimpleTodo
{
    public class TodoItemControllerTest : IDisposable
    {
        private IKeyRoutedEventArgsResolver OriginalKeyRoutedEventArgsResolver { get; set; }

        public TodoItemControllerTest()
        {
            OriginalKeyRoutedEventArgsResolver = KeyRoutedEventArgsWrapper.Resolver;
        }

        public void Dispose()
        {
            KeyRoutedEventArgsWrapper.Resolver = OriginalKeyRoutedEventArgsResolver;
        }

        [Fact]
        public async Task ShouldChangeVisualStateOnPointerOver()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var element = new Grid { Name = "TodoItemContainer" };
                VisualStateManager.GetVisualStateGroups(element).Add(XamlReader.Load(@"
<VisualStateGroup xmlns=""http://schemas.microsoft.com/winfx/2006/xaml/presentation""
                  xmlns:x=""http://schemas.microsoft.com/winfx/2006/xaml"">
    <VisualState x:Name=""Normal"" />
    <VisualState x:Name=""PointerOver"" />
</VisualStateGroup>
") as VisualStateGroup);

                var controller = new TodoItemController
                {
                    Root = new UserControl { Content = element }
                };

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy("TodoItemContainer")
                    .From(element)
                    .Raise(nameof(UIElement.PointerEntered));
                Assert.Equal("PointerOver", VisualStateManager.GetVisualStateGroups(element)[0].CurrentState.Name);

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy("TodoItemContainer")
                    .From(element)
                    .Raise(nameof(UIElement.PointerExited));
                Assert.Equal("Normal", VisualStateManager.GetVisualStateGroups(element)[0].CurrentState.Name);
            });
        }

        [Fact]
        public async Task ShouldSwitchToEditModeOnDoubleTapped()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var controller = new TodoItemController
                {
                    TodoItem = new TodoItem("Todo Item"),
                    TodoContentTextBox = new TextBox()
                };

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy("TodoItemContainer")
                    .Raise(nameof(UIElement.DoubleTapped));

                Assert.True(controller.TodoItem.Editing.Value);
                Assert.Equal("Todo Item", controller.TodoItem.EditContent.Value);
            });
        }

        [Fact]
        public async Task ShouldCompleteEditOnEnterPressed()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var controller = new TodoItemController
                {
                    TodoItem = new TodoItem("Todo Item"),
                    TodoContentTextBox = new TextBox()
                };

                UwpController.RetrieveEventHandlers(controller)
                   .GetBy("TodoItemContainer")
                   .Raise(nameof(UIElement.DoubleTapped));

                controller.TodoItem.EditContent.Value = "Todo Item Modified";

                KeyRoutedEventArgsWrapper.Resolver = new StubIKeyRoutedEventArgsResolver()
                    .Key(e => VirtualKey.Enter);
                UwpController.RetrieveEventHandlers(controller)
                    .GetBy("TodoContentTextBox")
                    .Raise(nameof(UIElement.KeyDown));

                Assert.False(controller.TodoItem.Editing.Value);
                Assert.Equal("Todo Item Modified", controller.TodoItem.Content.Value);
            });
        }

        [Fact]
        public async Task ShouldCompleteEditOnLostFocus()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var controller = new TodoItemController
                {
                    TodoItem = new TodoItem("Todo Item"),
                    TodoContentTextBox = new TextBox()
                };

                UwpController.RetrieveEventHandlers(controller)
                   .GetBy("TodoItemContainer")
                   .Raise(nameof(UIElement.DoubleTapped));

                controller.TodoItem.EditContent.Value = "Todo Item Modified";

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy("TodoContentTextBox")
                    .Raise(nameof(UIElement.LostFocus));

                Assert.False(controller.TodoItem.Editing.Value);
                Assert.Equal("Todo Item Modified", controller.TodoItem.Content.Value);
            });
        }

        [Fact]
        public async Task ShouldCancelEditOnEscPressed()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var controller = new TodoItemController
                {
                    TodoItem = new TodoItem("Todo Item"),
                    TodoContentTextBox = new TextBox()
                };

                UwpController.RetrieveEventHandlers(controller)
                   .GetBy("TodoItemContainer")
                   .Raise(nameof(UIElement.DoubleTapped));

                controller.TodoItem.EditContent.Value = "Todo Item Modified";

                KeyRoutedEventArgsWrapper.Resolver = new StubIKeyRoutedEventArgsResolver()
                    .Key(e => VirtualKey.Escape);
                UwpController.RetrieveEventHandlers(controller)
                    .GetBy("TodoContentTextBox")
                    .Raise(nameof(UIElement.KeyDown));

                Assert.False(controller.TodoItem.Editing.Value);
                Assert.Equal("Todo Item", controller.TodoItem.Content.Value);
            });
        }

        [Fact]
        public void ShouldRemoveTodoItemOnDeleteButtonClick()
        {
            var controller = new TodoItemController
            {
                TodoItem = new TodoItem("Todo Item")
            };

            var handled = false;
            EventHandler handler = (s, e) => handled = true;
            controller.TodoItem.RemoveRequested += handler;

            UwpController.RetrieveEventHandlers(controller)
                .GetBy("DeleteButton")
                .Raise(nameof(Button.Click));

            Assert.True(handled);
        }
    }
}
