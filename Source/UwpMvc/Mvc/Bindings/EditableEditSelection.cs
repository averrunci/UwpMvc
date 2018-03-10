// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Collections.Generic;
using System.Linq;

namespace Fievus.Windows.Mvc.Bindings
{
    internal sealed class EditableEditSelection<T> : EditableEditContent<T>, IEditableEditSelection
    {
        public ObservableProperty<bool> IsSelecting { get; } = new ObservableProperty<bool>();
        public IEnumerable<T> SelectionItems { get; }

        public EditableEditSelection(IEnumerable<T> selctionItems)
        {
            SelectionItems = selctionItems ?? Enumerable.Empty<T>();
        }
    }
}
