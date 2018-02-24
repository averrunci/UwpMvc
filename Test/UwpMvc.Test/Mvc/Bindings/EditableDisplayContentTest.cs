// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Xunit;

namespace Fievus.Windows.Mvc.Bindings
{
    public class EditableDisplayContentTest
    {
        private EditableDisplayContent<object> DisplayContent { get; } = new EditableDisplayContent<object>(new object());

        private bool EditStartedOccurred { get; set; }

        public EditableDisplayContentTest()
        {
            DisplayContent.EditStarted += (s, e) => EditStartedOccurred = true;
        }

        [Fact]
        public void RaisesEditStartedEventWhenIsEditableIsEqualToTrue()
        {
            DisplayContent.IsEditable.Value = true;

            DisplayContent.StartEdit();

            Assert.True(EditStartedOccurred);
        }

        [Fact]
        public void DoesNotRaiseEditStartedEventWhenIsEditableIsEqualToFalse()
        {
            DisplayContent.IsEditable.Value = false;

            DisplayContent.StartEdit();

            Assert.False(EditStartedOccurred);
        }

        [Fact]
        public void DoesNotThrowExceptionWhenNullValueIsSpecifiedToConstructor()
        {
            var displayContent = new EditableDisplayContent<object>(null);

            Assert.Null(displayContent.Value.Value);
        }
    }
}
