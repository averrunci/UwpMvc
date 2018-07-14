// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;
using Charites.Windows.Mvc;
using Charites.Windows.Mvc.Wrappers;

namespace Charites.Windows.Samples.SimpleTodo.Presentation
{
    [View(Key = nameof(MainContent))]
    public class MainContentController
    {
        [DataContext]
        public MainContent Content { get; set; }

        [Element]
        public CheckBox AllCompletedCheckBox { get; set; }

        [EventHandler(Event = nameof(FrameworkElement.Loaded))]
        private void OnLoaded()
        {
            Content.AllCompleted.PropertyValueChanged += (s, e) =>
            {
                if (e.NewValue.HasValue) return;

                AllCompletedCheckBox.IsChecked = null;
            };
        }

        [EventHandler(ElementName = "TodoContentTextBox", Event = nameof(UIElement.KeyDown))]
        private void OnTodoContentTextBoxKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key() != VirtualKey.Enter) return;

            Content.AddCurrentTodoContent();
        }
    }
}
