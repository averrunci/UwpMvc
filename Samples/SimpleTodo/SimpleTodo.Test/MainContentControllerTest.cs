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

using Xunit;

using Fievus.Windows.Mvc;
using Fievus.Windows.Mvc.Wrappers;

namespace Fievus.Windows.Samples.SimpleTodo
{
    public class MainContentControllerTest : IDisposable
    {
        private IKeyRoutedEventArgsResolver OriginalResolver { get; set; }

        public MainContentControllerTest()
        {
            OriginalResolver = KeyRoutedEventArgsWrapper.Resolver;
        }

        public void Dispose()
        {
            KeyRoutedEventArgsWrapper.Resolver = OriginalResolver;
        }

        [Fact]
        public async Task ShouldSetAllCompletedCheckBoxIsCheckedToNullWhenAllCompletedDoesNotHaveValue()
        {
            await CoreApplication.MainView.Dispatcher.RunAsync(CoreDispatcherPriority.Normal, () =>
            {
                var controller = new MainContentController
                {
                    Content = new MainContent(),
                    AllCompletedCheckBox = new CheckBox()
                };

                controller.Content.AllCompleted.Value = true;
                controller.AllCompletedCheckBox.IsChecked = true;

                UwpController.RetrieveEventHandlers(controller)
                    .GetBy(null)
                    .Raise(nameof(FrameworkElement.Loaded));

                controller.Content.AllCompleted.Value = null;

                Assert.Null(controller.AllCompletedCheckBox.IsChecked);
            });
        }

        [Fact]
        public void ShouldAddTodoItemWhenEnterKeyIsPressedOnTodoContentTextBox()
        {
            var controller = new MainContentController
            {
                Content = new MainContent()
            };

            controller.Content.TodoContent.Value = "Todo Item";

            KeyRoutedEventArgsWrapper.Resolver = new StubIKeyRoutedEventArgsResolver()
                .Key(e => VirtualKey.Enter);
            UwpController.RetrieveEventHandlers(controller)
                .GetBy("TodoContentTextBox")
                .Raise(nameof(UIElement.KeyDown));

            Assert.Equal(1, controller.Content.TodoItems.Count);
        }

        [Fact]
        public void ShouldNotAddTodoItemWhenEnterKeyIsNotPressedOnTodoContentTextBox()
        {
            var controller = new MainContentController
            {
                Content = new MainContent()
            };

            controller.Content.TodoContent.Value = "Todo Item";

            KeyRoutedEventArgsWrapper.Resolver = new StubIKeyRoutedEventArgsResolver()
                .Key(e => VirtualKey.Tab);
            UwpController.RetrieveEventHandlers(controller)
                .GetBy("TodoContentTextBox")
                .Raise(nameof(UIElement.KeyDown));

            Assert.Empty(controller.Content.TodoItems);
        }
    }
}
