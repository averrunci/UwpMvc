// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

using Xunit;

namespace Fievus.Windows.Samples.SimpleTodo
{
    public class TodoItemTest
    {
        private TodoItem TodoItem { get; }

        private const string initialContent = "Todo Item";
        private const string modifiedContent = "Todo Item Modified";

        public TodoItemTest()
        {
            TodoItem = new TodoItem(initialContent);
        }

        [Fact]
        public void ShouldEditContent()
        {
            Assert.False(TodoItem.Editing.Value);

            TodoItem.StartEdit();
            Assert.True(TodoItem.Editing.Value);
            Assert.Equal(initialContent, TodoItem.EditContent.Value);

            TodoItem.EditContent.Value = modifiedContent;
            TodoItem.CompleteEdit();

            Assert.False(TodoItem.Editing.Value);
            Assert.Equal(modifiedContent, TodoItem.Content.Value);
        }

        [Fact]
        public void ShouldCancelContentEdit()
        {
            Assert.False(TodoItem.Editing.Value);

            TodoItem.StartEdit();
            Assert.True(TodoItem.Editing.Value);
            Assert.Equal(initialContent, TodoItem.EditContent.Value);

            TodoItem.EditContent.Value = modifiedContent;
            TodoItem.CancelEdit();

            Assert.False(TodoItem.Editing.Value);
            Assert.Equal(initialContent, TodoItem.Content.Value);
        }

        [Fact]
        public void ShouldRequestToRemove()
        {
            var requested = false;
            EventHandler handler = (s, e) => requested = true;
            TodoItem.RemoveRequested += handler;

            TodoItem.Remove();

            Assert.True(requested);
        }

        [Fact]
        public void ShouldCompleteTodoItem()
        {
            TodoItem.Complete();

            Assert.Equal(TodoItemState.Completed, TodoItem.State.Value);
        }

        [Fact]
        public void ShouldRevertCompleted()
        {
            TodoItem.Revert();

            Assert.Equal(TodoItemState.Active, TodoItem.State.Value);
        }
    }
}
