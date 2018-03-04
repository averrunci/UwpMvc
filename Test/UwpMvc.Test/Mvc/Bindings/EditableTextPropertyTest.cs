// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Xunit;

namespace Fievus.Windows.Mvc.Bindings
{
    public class EditableTextPropertyTest
    {
        EditableTextProperty EditableText { get; } = new EditableTextProperty();

        string InitialText { get; } = "Initial";
        string EditedText { get; } = "Edited";

        [Fact]
        public void CompletesEdit()
        {
            EditableText.Value.Value = InitialText;
            (EditableText.Content.Value as IEditableDisplayContent).StartEdit();
            EditableText.Content.Value.Value.Value = EditedText;
            (EditableText.Content.Value as IEditableEditContent).CompleteEdit();

            Assert.Equal(EditedText, EditableText.Value.Value);
        }

        [Fact]
        public void CancelsEdit()
        {
            EditableText.Value.Value = InitialText;
            (EditableText.Content.Value as IEditableDisplayContent).StartEdit();
            EditableText.Content.Value.Value.Value = EditedText;
            (EditableText.Content.Value as IEditableEditContent).CancelEdit();

            Assert.Equal(InitialText, EditableText.Value.Value);
        }
    }
}
