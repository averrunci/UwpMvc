// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

using Fievus.Windows.Mvc;
using Fievus.Windows.Mvc.Wrappers;

namespace Fievus.Windows.Samples.SimpleTodo
{
    public class MainContentController
    {
        [DataContext]
        public MainContent Content { get; set; }

        [Element]
        public CheckBox AllCompletedCheckBox { get; set; }

        [EventHandler(Event = "Loaded")]
        private void OnLoaded()
        {
            Content.AllCompleted.PropertyValueChanged += (s, e) =>
            {
                if (e.NewValue.HasValue) { return; }

                AllCompletedCheckBox.IsChecked = null;
            };
        }

        [EventHandler(ElementName = "TodoContentTextBox", Event = "KeyDown")]
        private void OnTodoContentTextBoxKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key() != VirtualKey.Enter) { return; }

            Content.AddCurrentTodoContent();
        }
    }
}
