// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Xunit;

namespace Fievus.Windows.Mvc.Bindings
{
    public class EditableSelectionPropertyTest
    {
        EditableSelectionProperty EditableSelection { get; }

        string[] SelectionItems { get; } = new[] { "Item1", "Item2", "Item3", "Item4", "Item5" };
        string InitialSelectedItem { get; } = "Item2";
        string SelectedItem { get; }

        public EditableSelectionPropertyTest()
        {
            EditableSelection = InitialSelectedItem.ToEditableSelectionProperty(SelectionItems);
            SelectedItem = SelectionItems[3];
        }

        [Fact]
        public void CompletesEdit()
        {
            Assert.Equal(InitialSelectedItem, EditableSelection.Value.Value);

            (EditableSelection.Content.Value as IEditableDisplayContent).StartEdit();
            EditableSelection.Content.Value.Value.Value = SelectedItem;
            (EditableSelection.Content.Value as IEditableEditContent).CompleteEdit();

            Assert.Equal(SelectedItem, EditableSelection.Value.Value);
        }

        [Fact]
        public void CancelsEdit()
        {
            Assert.Equal(InitialSelectedItem, EditableSelection.Value.Value);

            (EditableSelection.Content.Value as IEditableDisplayContent).StartEdit();
            EditableSelection.Content.Value.Value.Value = SelectedItem;
            (EditableSelection.Content.Value as IEditableEditContent).CancelEdit();

            Assert.Equal(InitialSelectedItem, EditableSelection.Value.Value);
        }
    }
}
