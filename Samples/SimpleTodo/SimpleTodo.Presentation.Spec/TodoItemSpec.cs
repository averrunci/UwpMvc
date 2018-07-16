﻿// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Carna;

namespace Charites.Windows.Samples.SimpleTodo.Presentation
{
    [Specification("TodoItem Spec")]
    class TodoItemSpec : FixtureSteppable
    {
        TodoItem TodoItem { get; }

        string InitialContent { get; } = "Todo Item";
        string ModifiedContent { get; } = "Todo Item Modified";

        bool RemoveRequested { get; set; }

        public TodoItemSpec()
        {
            TodoItem = new TodoItem(InitialContent);
            TodoItem.RemoveRequested += (s, e) => RemoveRequested = true;
        }

        [Example("Edits the content")]
        void Ex01()
        {
            Expect("the Editing should be false", () => !TodoItem.Editing.Value);

            When("to start an edit", () => TodoItem.StartEdit());
            Then("the Editing should be true", () => TodoItem.Editing.Value);
            Then("the edit content should be the initial content", () => TodoItem.EditContent.Value == InitialContent);

            When("the content is modified", () => TodoItem.EditContent.Value = ModifiedContent);
            When("to complete the edit", () => TodoItem.CompleteEdit());
            Then("the Editing should be false", () => !TodoItem.Editing.Value);
            Then("the content should be the modified content", () => TodoItem.Content.Value == ModifiedContent);
        }

        [Example("Cancels an edit of the content")]
        void Ex02()
        {
            Expect("the Editing should be false", () => !TodoItem.Editing.Value);

            When("to start an edit", () => TodoItem.StartEdit());
            Then("the Editing should be true", () => TodoItem.Editing.Value);
            Then("the edit content should be the initial content", () => TodoItem.EditContent.Value == InitialContent);

            When("the content is modified", () => TodoItem.EditContent.Value = ModifiedContent);
            When("to cancel the edit", () => TodoItem.CancelEdit());
            Then("the Editing should be false", () => !TodoItem.Editing.Value);
            Then("the content should be the initial content", () => TodoItem.Content.Value == InitialContent);
        }

        [Example("Removes a to-do")]
        void Ex03()
        {
            When("to remove", () => TodoItem.Remove());
            Then("it should be requested to remove the to-do", () => RemoveRequested);
        }

        [Example("Completes and reverts a to-do")]
        void Ex04()
        {
            Expect("the state should be Active", () => TodoItem.State.Value == TodoItemState.Active);

            When("to complete", () => TodoItem.Complete());
            Then("the state should be Completed", () => TodoItem.State.Value == TodoItemState.Completed);

            When("to revert", () => TodoItem.Revert());
            Then("the state should be Active", () => TodoItem.State.Value == TodoItemState.Active);
        }
    }
}
