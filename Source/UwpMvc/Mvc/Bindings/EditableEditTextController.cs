// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc.Bindings
{
    internal sealed class EditableEditTextController
    {
        [DataContext]
        EditableEditText EditText { get; set; }

        [Element]
        TextBox EditTextBox { get; set; }

        [EventHandler(Event = nameof(FrameworkElement.Loaded))]
        void OnLoaded()
        {
            EditTextBox.SelectAll();
            EditTextBox.Focus(FocusState.Pointer);
        }

        [EventHandler(Event = nameof(FrameworkElement.LostFocus))]
        void OnLostFocus()
        {
            if (!EditText.Validate())
            {
                EditTextBox.Focus(FocusState.Keyboard);
                return;
            }

            EditText.CompleteEdit();
        }

        [EventHandler(Event = nameof(UIElement.KeyDown))]
        void OnKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Escape)
            {
                EditText.CancelEdit();
            }
            else if (e.Key == VirtualKey.Enter && !EditText.IsMultiline.Value && EditText.Validate())
            {
                EditText.CompleteEdit();
            }
        }
    }
}
