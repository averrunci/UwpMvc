// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Xunit;

namespace Fievus.Windows.Mvc.Bindings
{
    public class EditableEditContentTest
    {
        private EditableEditContent<object> EditContent { get; } = new EditableEditContent<object>(new object());

        private bool EditCompletedOccurred { get; set; }
        private bool EditCanceledOccurred { get; set; }

        public EditableEditContentTest()
        {
            EditContent.EditCompleted += (s, e) => EditCompletedOccurred = true;
            EditContent.EditCanceled += (s, e) => EditCanceledOccurred = true;
        }

        [Fact]
        public void RaisesEditCompletedEvent()
        {
            EditContent.CompleteEdit();

            Assert.True(EditCompletedOccurred);
            Assert.False(EditCanceledOccurred);
        }

        [Fact]
        public void RaisesEditCanceledEvent()
        {
            EditContent.CancelEdit();

            Assert.False(EditCompletedOccurred);
            Assert.True(EditCanceledOccurred);
        }

        [Fact]
        public void DoesNotThrowExceptionWhenNullValueIsSpecifiedToConstructor()
        {
            var editContent = new EditableDisplayContent<object>(null);

            Assert.Null(editContent.Value.Value);
        }
    }
}
