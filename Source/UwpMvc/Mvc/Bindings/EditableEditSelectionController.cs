// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;

namespace Fievus.Windows.Mvc.Bindings
{
    internal sealed class EditableEditSelectionController
    {
        [DataContext]
        IEditableEditSelection EditSelection { get; set; }

        [EventHandler(Event = nameof(FrameworkElement.Loaded))]
        void OnLoaded(object sender, RoutedEventArgs e)
        {
            sender.IfTypeOf<Control>(control => control.Focus(FocusState.Pointer));
        }

        [EventHandler(Event = nameof(FrameworkElement.Unloaded))]
        void OnUnloaded(object sender, RoutedEventArgs e)
        {
            sender.IfTypeOf<Selector>(selector => selector.ItemsSource = null);
        }

        [EventHandler(Event = nameof(UIElement.LostFocus))]
        void OnLostFocus()
        {
            if (!EditSelection.IsSelecting.Value)
            {
                EditSelection.CompleteEdit();
            }
        }

        [EventHandler(Event = nameof(UIElement.KeyDown))]
        void OnKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key == VirtualKey.Escape)
            {
                EditSelection.CancelEdit();
            }
        }
    }
}
