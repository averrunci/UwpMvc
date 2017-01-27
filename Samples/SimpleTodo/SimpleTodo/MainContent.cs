﻿// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

using Fievus.Windows.Mvc.Bindings;

namespace Fievus.Windows.Samples.SimpleTodo
{
    public class MainContent
    {
        public ObservableProperty<bool?> AllCompleted { get; } = new ObservableProperty<bool?>(false);
        public ObservableProperty<bool> CanCompleteAllTodoItems { get; } = false.ToObservableProperty();

        public ObservableProperty<string> TodoContent { get; } = string.Empty.ToObservableProperty();

        public ObservableCollection<TodoItem> TodoItems { get; } = new ObservableCollection<TodoItem>();
        private List<TodoItem> todoItems = new List<TodoItem>();

        public ObservableProperty<string> ItemsLeftMessage { get; } = string.Empty.ToObservableProperty();

        public ObservableProperty<TodoItemState> TodoItemDisplayState { get; } = TodoItemState.All.ToObservableProperty();

        public MainContent()
        {
            AllCompleted.PropertyValueChanged += OnAllCompletedPropertyValueChanged;
            TodoItems.CollectionChanged += (s, e) =>
            {
                UpdateAllTodoItemsCompletionEnabled();
                UpdateItemsLeftMessage();
            };
            TodoItemDisplayState.PropertyValueChanged += (s, e) => ApplyFilter();

            UpdateItemsLeftMessage();
        }

        public void AddCurrentTodoContent()
        {
            if (string.IsNullOrWhiteSpace(TodoContent.Value)) { return; }

            var newTodoItem = new TodoItem(TodoContent.Value);
            newTodoItem.RemoveRequested += OnTodoItemRemoveRequested;
            newTodoItem.State.PropertyValueChanged += OnTodoItemStateChanged;
            todoItems.Add(newTodoItem);
            TodoItems.Add(newTodoItem);

            TodoContent.Value = string.Empty;
            UpdateAllTodoItemsCompletionState();
            ApplyFilter();
        }

        private void OnAllCompletedPropertyValueChanged(object sender, PropertyValueChangedEventArgs<bool?> e)
        {
            UpdateAllTodoItemsState();
        }

        private void OnTodoItemRemoveRequested(object sender, EventArgs e)
        {
            var removedTodoItem = sender as TodoItem;
            if (removedTodoItem == null) { return; }

            removedTodoItem.RemoveRequested -= OnTodoItemRemoveRequested;
            removedTodoItem.State.PropertyValueChanged -= OnTodoItemStateChanged;
            todoItems.Remove(removedTodoItem);
            TodoItems.Remove(removedTodoItem);
        }

        private void OnTodoItemStateChanged(object sender, PropertyValueChangedEventArgs<TodoItemState> e)
        {
            UpdateAllTodoItemsCompletionState();
            UpdateItemsLeftMessage();
            ApplyFilter();
        }

        private void UpdateAllTodoItemsState()
        {
            if (!AllCompleted.Value.HasValue) { return; }

            foreach (var item in todoItems)
            {
                item.State.PropertyValueChanged -= OnTodoItemStateChanged;
                try
                {
                    item.State.Value = AllCompleted.Value.GetValueOrDefault() ? TodoItemState.Completed : TodoItemState.Active;
                }
                finally
                {
                    item.State.PropertyValueChanged += OnTodoItemStateChanged;
                }
            }

            UpdateItemsLeftMessage();
            ApplyFilter();
        }

        private void UpdateAllTodoItemsCompletionState()
        {
            AllCompleted.PropertyValueChanged -= OnAllCompletedPropertyValueChanged;
            try
            {
                if (todoItems.All(i => i.State.Value == TodoItemState.Active))
                {
                    AllCompleted.Value = false;
                }
                else if (todoItems.All(i => i.State.Value == TodoItemState.Completed))
                {
                    AllCompleted.Value = true;
                }
                else
                {
                    AllCompleted.Value = null;
                }
            }
            finally
            {
                AllCompleted.PropertyValueChanged += OnAllCompletedPropertyValueChanged;
            }
        }

        private void UpdateAllTodoItemsCompletionEnabled()
        {
            CanCompleteAllTodoItems.Value = TodoItems.Any();
        }

        private void UpdateItemsLeftMessage()
        {
            var activeCount = todoItems.Where(i => i.State.Value == TodoItemState.Active).Count();
            ItemsLeftMessage.Value = $"{activeCount} item{(activeCount == 1 ? string.Empty : "s")} left";
        }

        private void ApplyFilter()
        {
            TodoItems.Clear();
            foreach (var item in TodoItemDisplayState.Value == TodoItemState.All ? todoItems : todoItems.Where(i => i.State.Value == TodoItemDisplayState.Value))
            {
                TodoItems.Add(item);
            }
        }
    }
}
