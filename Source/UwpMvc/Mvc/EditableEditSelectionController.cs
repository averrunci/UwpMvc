// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Input;
using Charites.Windows.Mvc.Bindings;

namespace Charites.Windows.Mvc
{
    [View(Key = "Charites.Windows.Mvc.Bindings.EditableEditSelection`1")]
    internal sealed class EditableEditSelectionController
    {
        [DataContext]
        private IEditableEditSelection EditSelection { get; set; }

        [EventHandler(Event = nameof(FrameworkElement.Loaded))]
        private void OnLoaded(object sender, RoutedEventArgs e)
        {
            sender.IfTypeOf<Control>(control => control.Focus(FocusState.Pointer));
        }

        [EventHandler(Event = nameof(FrameworkElement.Unloaded))]
        private void OnUnloaded(object sender, RoutedEventArgs e)
        {
            sender.IfTypeOf<Selector>(selector => selector.ItemsSource = null);
        }

        [EventHandler(Event = nameof(UIElement.LostFocus))]
        private void OnLostFocus()
        {
            if (EditSelection.IsSelecting.Value) return;

            EditSelection.CompleteEdit();
        }

        [EventHandler(Event = nameof(UIElement.KeyDown))]
        private void OnKeyDown(KeyRoutedEventArgs e)
        {
            if (e.Key != VirtualKey.Escape) return;

            EditSelection.CancelEdit();
        }
    }
}
