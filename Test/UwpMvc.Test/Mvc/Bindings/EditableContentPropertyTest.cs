// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Xunit;

namespace Fievus.Windows.Mvc.Bindings
{
    public class EditableContentPropertyTest
    {
        EditableDisplayContent<object> DisplayContent { get; } = new EditableDisplayContent<object>(new object());
        EditableEditContent<object> EditContent { get; } = new EditableEditContent<object>(new object());

        EditableContentProperty<object> EditableContent { get; }

        bool EditStartedOccurred { get; set; }
        bool EditCompletedOccurred { get; set; }
        bool EditCanceledOccurred { get; set; }

        public EditableContentPropertyTest()
        {
            EditableContent = new EditableContentProperty<object>(DisplayContent, EditContent);

            EditableContent.EditStarted += (s, e) => EditStartedOccurred = e.DisplayContent == DisplayContent.Value.Value && e.EditContent == EditContent.Value.Value;
            EditableContent.EditCompleted += (s, e) => EditCompletedOccurred = e.DisplayContent == DisplayContent.Value.Value && e.EditContent == EditContent.Value.Value;
            EditableContent.EditCanceled += (s, e) => EditCanceledOccurred = e.DisplayContent == DisplayContent.Value.Value && e.EditContent == EditContent.Value.Value;
        }

        [Fact]
        public void CompletesEdit()
        {
            DisplayContent.StartEdit();
            Assert.Equal(EditContent, EditableContent.Content.Value);
            Assert.True(EditableContent.IsEditing.Value);

            EditContent.CompleteEdit();
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            Assert.True(EditStartedOccurred);
            Assert.True(EditCompletedOccurred);
            Assert.False(EditCanceledOccurred);
        }

        [Fact]
        public void DoesNotCompleteEditWhenEditIsNotStarted()
        {
            EditContent.CompleteEdit();
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            Assert.False(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.False(EditCanceledOccurred);
        }

        [Fact]
        public void CancelsEdit()
        {
            DisplayContent.StartEdit();
            Assert.Equal(EditContent, EditableContent.Content.Value);
            Assert.True(EditableContent.IsEditing.Value);

            EditContent.CancelEdit();
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            Assert.True(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.True(EditCanceledOccurred);
        }

        [Fact]
        public void DoesNotCancelEditWhenEditIsNotStarted()
        {
            EditContent.CancelEdit();
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            Assert.False(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.False(EditCanceledOccurred);
        }

        [Fact]
        public void StartsEditWhenIsEditingIsChangedToTrue()
        {
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            EditableContent.IsEditing.Value = true;
            Assert.Equal(EditContent, EditableContent.Content.Value);
            Assert.True(EditableContent.IsEditing.Value);

            Assert.True(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.False(EditCanceledOccurred);
        }

        [Fact]
        public void DoesNotRestartWhenEditIsStarted()
        {
            DisplayContent.StartEdit();
            Assert.Equal(EditContent, EditableContent.Content.Value);
            Assert.True(EditableContent.IsEditing.Value);

            EditStartedOccurred = false;

            DisplayContent.StartEdit();
            Assert.Equal(EditContent, EditableContent.Content.Value);
            Assert.True(EditableContent.IsEditing.Value);

            Assert.False(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.False(EditCanceledOccurred);
        }

        [Fact]
        public void CancelsEditWhenIsEditingIsChangedToFalseDuringEditing()
        {
            DisplayContent.StartEdit();
            Assert.Equal(EditContent, EditableContent.Content.Value);
            Assert.True(EditableContent.IsEditing.Value);

            EditableContent.IsEditing.Value = false;
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            Assert.True(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.True(EditCanceledOccurred);
        }

        [Fact]
        public void CancelsEditWhenIsEditableIsChangedToFalseDuringEditing()
        {
            DisplayContent.StartEdit();
            Assert.Equal(EditContent, EditableContent.Content.Value);
            Assert.True(EditableContent.IsEditing.Value);

            EditableContent.IsEditable.Value = false;
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            Assert.True(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.True(EditCanceledOccurred);
        }

        [Fact]
        public void DoesNotStartWhenIsEditableIsFalse()
        {
            EditableContent.IsEditable.Value = false;

            DisplayContent.StartEdit();
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            Assert.False(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.False(EditCanceledOccurred);
        }

        [Fact]
        public void DoesNotStartWhenIsEditableIsChangedToTrue()
        {
            EditableContent.IsEditable.Value = false;

            EditableContent.IsEditable.Value = true;
            Assert.Equal(DisplayContent, EditableContent.Content.Value);
            Assert.False(EditableContent.IsEditing.Value);

            Assert.False(EditStartedOccurred);
            Assert.False(EditCompletedOccurred);
            Assert.False(EditCanceledOccurred);
        }

        [Fact]
        public void ThrowsExceptionWhenDisplayContentThatIsNullIsSpecifiedToConstructor()
        {
            Assert.Throws<ArgumentNullException>(() => new EditableContentProperty<object>(null, EditContent));
        }

        [Fact]
        public void ThrowsExceptionWhenEditContentThatIsNullIsSpecifiedToConstructor()
        {
            Assert.Throws<ArgumentNullException>(() => new EditableContentProperty<object>(DisplayContent, null));
        }
    }
}
