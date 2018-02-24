// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

namespace Fievus.Windows.Mvc.Bindings
{
    internal sealed class EditableDisplayContentController
    {
        [DataContext]
        IEditableDisplayContent Content { get; set; }

        [EventHandler(Event = nameof(UIElement.DoubleTapped))]
        void OnDoubleTapped()
        {
            Content.StartEdit();
        }
    }
}
