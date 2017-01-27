// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

using Fievus.Windows.Mvc;
using Fievus.Windows.Mvc.Wrappers;

namespace Fievus.Windows.Samples.SimpleTodo
{
    public class TodoItemController
    {
        [DataContext]
        public TodoItem TodoItem { get; set; }

        [Element]
        public UserControl Root { get; set; }

        [Element]
        public TextBox TodoContentTextBox { get; set; }

        [EventHandler(ElementName = "TodoItemContainer", Event = "PointerEntered")]
        private void OnTodoItemContainerPointerEntered(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(Root, "PointerOver", false);
        }

        [EventHandler(ElementName = "TodoItemContainer", Event = "PointerExited")]
        private void OnTodoItemContainerPointerExited(object sender, RoutedEventArgs e)
        {
            VisualStateManager.GoToState(Root, "Normal", false);
        }

        [EventHandler(ElementName = "TodoItemContainer", Event = "DoubleTapped")]
        private void OnTodoItemContainerDoubleTapped()
        {
            TodoItem.StartEdit();

            TodoContentTextBox.Focus(FocusState.Programmatic);
            TodoContentTextBox.SelectAll();
        }

        [EventHandler(ElementName = "TodoContentTextBox", Event = "KeyDown")]
        private void OnTodoContentTextBoxKeyDown(KeyRoutedEventArgs e)
        {
            switch (e.Key())
            {
                case VirtualKey.Enter:
                    TodoItem.CompleteEdit();
                    break;
                case VirtualKey.Escape:
                    TodoItem.CancelEdit();
                    break;
            }
        }

        [EventHandler(ElementName = "TodoContentTextBox", Event = "LostFocus")]
        private void OnTodoContentTextBoxLostFocus()
        {
            if (!TodoItem.Editing.Value) { return; }

            TodoItem.CompleteEdit();
        }

        [EventHandler(ElementName = "DeleteButton", Event = "Click")]
        private void OnDeleteButtonClick()
        {
            TodoItem.Remove();
        }
    }
}
