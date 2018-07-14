// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Charites.Windows.Mvc;
using Charites.Windows.Mvc.Wrappers;

namespace Charites.Windows.Samples.SimpleTodo.Presentation
{
    [View(Key = nameof(TodoItem))]
    public class TodoItemController
    {
        [DataContext]
        private TodoItem TodoItem { get; set; }

        [Element]
        private UserControl Root { get; set; }

        [Element]
        private TextBox TodoContentTextBox { get; set; }

        [EventHandler(ElementName = "TodoItemContainer", Event = nameof(UIElement.PointerEntered))]
        private void OnTodoItemContainerPointerEntered()
        {
            VisualStateManager.GoToState(Root, "PointerOver", false);
        }

        [EventHandler(ElementName = "TodoItemContainer", Event = nameof(UIElement.PointerExited))]
        private void OnTodoItemContainerPointerExited()
        {
            VisualStateManager.GoToState(Root, "Normal", false);
        }

        [EventHandler(ElementName = "TodoItemContainer", Event = nameof(UIElement.DoubleTapped))]
        private void OnTodoItemContainerDoubleTapped()
        {
            TodoItem.StartEdit();

            TodoContentTextBox.Focus(FocusState.Programmatic);
            TodoContentTextBox.SelectAll();
        }

        [EventHandler(ElementName = "TodoContentTextBox", Event = nameof(UIElement.KeyDown))]
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

        [EventHandler(ElementName = "TodoContentTextBox", Event = nameof(UIElement.LostFocus))]
        private void OnTodoContentTextBoxLostFocus()
        {
            if (!TodoItem.Editing.Value) return;

            TodoItem.CompleteEdit();
        }

        [EventHandler(ElementName = "DeleteButton", Event = nameof(ButtonBase.Click))]
        private void OnDeleteButtonClick()
        {
            TodoItem.Remove();
        }
    }
}
