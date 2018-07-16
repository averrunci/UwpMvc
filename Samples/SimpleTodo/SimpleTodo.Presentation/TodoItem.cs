﻿// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Charites.Windows.Mvc.Bindings;

namespace Charites.Windows.Samples.SimpleTodo.Presentation
{
    public class TodoItem
    {
        public event EventHandler RemoveRequested;

        public ObservableProperty<string> Content { get; }
        public ObservableProperty<string> EditContent { get; } = string.Empty.ToObservableProperty();
        public ObservableProperty<bool> Editing { get; } = false.ToObservableProperty();

        public ObservableProperty<TodoItemState> State { get; } = TodoItemState.Active.ToObservableProperty();

        public TodoItem(string content)
        {
            Content = content.ToObservableProperty();
        }

        public void StartEdit()
        {
            Editing.Value = true;
            EditContent.Value = Content.Value;
        }

        public void CompleteEdit()
        {
            Content.Value = EditContent.Value;
            Editing.Value = false;
        }

        public void CancelEdit()
        {
            EditContent.Value = string.Empty;
            Editing.Value = false;
        }

        public void Remove()
        {
            OnRemoveRequested(EventArgs.Empty);
        }

        public void Complete()
        {
            State.Value = TodoItemState.Completed;
        }

        public void Revert()
        {
            State.Value = TodoItemState.Active;
        }

        protected virtual void OnRemoveRequested(EventArgs e) => RemoveRequested?.Invoke(this, e);
    }
}
