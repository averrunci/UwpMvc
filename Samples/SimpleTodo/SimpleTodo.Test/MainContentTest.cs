// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System.Linq;

using Xunit;

namespace Fievus.Windows.Samples.SimpleTodo.MainContentTest
{
    public class MainContent_Initial
    {
        private MainContent MainContent { get; set; }

        public MainContent_Initial()
        {
            MainContent = new MainContent();
        }

        [Fact]
        public void ItemsShouldBeEmpty()
        {
            Assert.Empty(MainContent.TodoItems);
        }

        [Fact]
        public void TodoContentShouldBeEmpty()
        {
            Assert.Empty(MainContent.TodoContent.Value);
        }

        [Fact]
        public void AllCompletedShouldBeFalse()
        {
            Assert.False(MainContent.AllCompleted.Value);
        }

        [Fact]
        public void AllCompletedShouldBeInvisible()
        {
            Assert.False(MainContent.CanCompleteAllTodoItems.Value);
        }

        [Fact]
        public void ItemsLeftMessageShouldHaveZeroItemsLeft()
        {
            Assert.Equal("0 items left", MainContent.ItemsLeftMessage.Value);
        }

        [Fact]
        public void TodoItemDisplayStateShouldBeAll()
        {
            Assert.Equal(TodoItemState.All, MainContent.TodoItemDisplayState.Value);
        }
    }

    public class MainContent_AddOneItem
    {
        private MainContent MainContent { get; set; }

        private const string todoContent = "Todo Item";

        public MainContent_AddOneItem()
        {
            MainContent = new MainContent();
            MainContent.TodoContent.Value = todoContent;
            MainContent.AddCurrentTodoContent();
        }

        [Fact]
        public void ItemsShouldHaveOneItem()
        {
            Assert.Equal(1, MainContent.TodoItems.Count);
            Assert.Equal(todoContent, MainContent.TodoItems[0].Content.Value);
            Assert.Equal(TodoItemState.Active, MainContent.TodoItems[0].State.Value);
        }

        [Fact]
        public void TodoContentShouldBeEmpty()
        {
            Assert.Empty(MainContent.TodoContent.Value);
        }

        [Fact]
        public void AllCompletedShouldBeVisible()
        {
            Assert.True(MainContent.CanCompleteAllTodoItems.Value);
        }

        [Fact]
        public void ItemsLeftMessageShouldHaveOneItemLeft()
        {
            Assert.Equal("1 item left", MainContent.ItemsLeftMessage.Value);
        }
    }

    public class MainContent_AddTwoItems
    {
        private MainContent MainContent { get; set; }

        private const string todoContent1 = "Todo Item 1";
        private const string todoContent2 = "Todo Item 2";

        public MainContent_AddTwoItems()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = todoContent1;
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = todoContent2;
            MainContent.AddCurrentTodoContent();
        }

        [Fact]
        public void ItemsShouldHaveTowItems()
        {
            Assert.Equal(2, MainContent.TodoItems.Count);
            Assert.Equal(todoContent1, MainContent.TodoItems[0].Content.Value);
            Assert.Equal(TodoItemState.Active, MainContent.TodoItems[0].State.Value);
            Assert.Equal(todoContent2, MainContent.TodoItems[1].Content.Value);
            Assert.Equal(TodoItemState.Active, MainContent.TodoItems[1].State.Value);
        }

        [Fact]
        public void TodoContentShouldBeEmpty()
        {
            Assert.Empty(MainContent.TodoContent.Value);
        }

        [Fact]
        public void AllCompletedShouldBeVisible()
        {
            Assert.True(MainContent.CanCompleteAllTodoItems.Value);
        }

        [Fact]
        public void ItemsLeftMessageShouldHaveTwoItemsLeft()
        {
            Assert.Equal("2 items left", MainContent.ItemsLeftMessage.Value);
        }
    }

    public class MainContent_RemoveItem
    {
        private MainContent MainContent { get; set; }

        private const string todoContent1 = "Todo Item 1";
        private const string todoContent2 = "Todo Item 2";
        private const string todoContent3 = "Todo Item 3";

        public MainContent_RemoveItem()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = todoContent1;
            MainContent.AddCurrentTodoContent();
            MainContent.TodoContent.Value = todoContent2;
            MainContent.AddCurrentTodoContent();
            MainContent.TodoContent.Value = todoContent3;
            MainContent.AddCurrentTodoContent();

            MainContent.TodoItems[1].Remove();
        }

        [Fact]
        public void ItemShouldBeRemoved()
        {
            Assert.Equal(2, MainContent.TodoItems.Count);
            Assert.Equal(todoContent1, MainContent.TodoItems[0].Content.Value);
            Assert.Equal(TodoItemState.Active, MainContent.TodoItems[0].State.Value);
            Assert.Equal(todoContent3, MainContent.TodoItems[1].Content.Value);
            Assert.Equal(TodoItemState.Active, MainContent.TodoItems[1].State.Value);
        }

        [Fact]
        public void AllCompletedShouldBeVisible()
        {
            Assert.True(MainContent.CanCompleteAllTodoItems.Value);
        }

        [Fact]
        public void ItemsLeftMessageShouldBeUpdated()
        {
            Assert.Equal("2 items left", MainContent.ItemsLeftMessage.Value);
        }
    }

    public class MainContent_RemoveLastItem
    {
        private MainContent MainContent { get; set; }

        private const string todoContent = "Todo Item";

        public MainContent_RemoveLastItem()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = todoContent;
            MainContent.AddCurrentTodoContent();

            MainContent.TodoItems[0].Remove();
        }

        [Fact]
        public void ItemShouldBeEmpty()
        {
            Assert.Empty(MainContent.TodoItems);
        }

        [Fact]
        public void AllCompletedShouldBeInvisible()
        {
            Assert.False(MainContent.CanCompleteAllTodoItems.Value);
        }

        [Fact]
        public void ItemsLeftMessageShouldBeZeroItemsLeft()
        {
            Assert.Equal("0 items left", MainContent.ItemsLeftMessage.Value);
        }
    }

    public class MainContent_CompleteItem
    {
        private MainContent MainContent { get; set; }

        public MainContent_CompleteItem()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = "Todo Item";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoItems[0].Complete();
        }

        [Fact]
        public void ItemsLeftMessageShouldHaveZeroItemsLeft()
        {
            Assert.Equal("0 items left", MainContent.ItemsLeftMessage.Value);
        }
    }

    public class MainContent_RevertCompletedItem
    {
        private MainContent MainContent { get; set; }

        public MainContent_RevertCompletedItem()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = "Todo Item";
            MainContent.AddCurrentTodoContent();
            MainContent.TodoItems[0].Complete();

            MainContent.TodoItems[0].Revert();
        }

        [Fact]
        public void ItemsLeftMessageShouldHaveOneItemLeft()
        {
            Assert.Equal("1 item left", MainContent.ItemsLeftMessage.Value);
        }
    }

    public class MainContent_SwitchFilter
    {
        private MainContent MainContent { get; set; }

        public MainContent_SwitchFilter()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = "Active Item 1";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Completed Item 1";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Active Item 2";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Completed Item 1";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Active Item 3";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoItems[1].Complete();
            MainContent.TodoItems[3].Complete();
        }

        [Fact]
        public void ShouldShowAllItemsWhenAllIsSelected()
        {
            MainContent.TodoItemDisplayState.Value = TodoItemState.All;

            Assert.Equal(5, MainContent.TodoItems.Count);
        }

        [Fact]
        public void ShouldShowOnlyActiveItemsWhenActiveIsSelected()
        {
            MainContent.TodoItemDisplayState.Value = TodoItemState.Active;

            Assert.Equal(3, MainContent.TodoItems.Count);
        }

        [Fact]
        public void ShouldShowOnlyCompletedItemsWhenCompletedIsSelected()
        {
            MainContent.TodoItemDisplayState.Value = TodoItemState.Completed;

            Assert.Equal(2, MainContent.TodoItems.Count);
        }
    }

    public class ItemsListUpdatedCorrectlyOnCompletionChanged
    {
        private MainContent MainContent { get; set; }

        public ItemsListUpdatedCorrectlyOnCompletionChanged()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = "Todo Item";
            MainContent.AddCurrentTodoContent();
        }

        [Fact]
        public void ShouldApplyFilterWhenTodoItemIsCompleted()
        {
            MainContent.TodoItemDisplayState.Value = TodoItemState.Active;

            MainContent.TodoItems[0].Complete();

            Assert.Empty(MainContent.TodoItems);
        }

        [Fact]
        public void ShouldApplyFilterWhenTodoItemIsReverted()
        {
            MainContent.TodoItems[0].Complete();
            MainContent.TodoItemDisplayState.Value = TodoItemState.Completed;

            MainContent.TodoItems[0].Revert();

            Assert.Empty(MainContent.TodoItems);
        }

        [Fact]
        public void ShouldApplyFilterWhenTodoItemIsAdded()
        {
            MainContent.TodoItems[0].Complete();
            MainContent.TodoItemDisplayState.Value = TodoItemState.Completed;

            MainContent.TodoContent.Value = "New Todo Item";
            MainContent.AddCurrentTodoContent();

            Assert.Equal(1, MainContent.TodoItems.Count);
        }
    }

    public class CompleteAllItems
    {
        private MainContent MainContent { get; set; }

        public CompleteAllItems()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = "Todo Item 1";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Todo Item 2";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Todo Item 3";
            MainContent.AddCurrentTodoContent();

            MainContent.AllCompleted.Value = true;
        }

        [Fact]
        public void AllItemsAreCompleted()
        {
            Assert.True(MainContent.TodoItems.All(i => i.State.Value == TodoItemState.Completed));
        }

        [Fact]
        public void ItemsLeftMessageShouldHaveZeroItemsLeft()
        {
            Assert.Equal("0 items left", MainContent.ItemsLeftMessage.Value);
        }
    }

    public class RevertAllItems
    {
        private MainContent MainContent { get; set; }

        public RevertAllItems()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = "Todo Item 1";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Todo Item 2";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Todo Item 3";
            MainContent.AddCurrentTodoContent();

            MainContent.AllCompleted.Value = true;
            MainContent.AllCompleted.Value = false;
        }

        [Fact]
        public void AllItemsAreActive()
        {
            Assert.True(MainContent.TodoItems.All(i => i.State.Value == TodoItemState.Active));
        }

        [Fact]
        public void ItemsLeftMessageShouldHaveThreeItemsLeft()
        {
            Assert.Equal("3 items left", MainContent.ItemsLeftMessage.Value);
        }
    }

    public class AllCompletedBehavior
    {
        private MainContent MainContent { get; set; }

        public AllCompletedBehavior()
        {
            MainContent = new MainContent();

            MainContent.TodoContent.Value = "Todo Item 1";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Todo Item 2";
            MainContent.AddCurrentTodoContent();

            MainContent.TodoContent.Value = "Todo Item 3";
            MainContent.AddCurrentTodoContent();
        }

        [Fact]
        public void AllCompletedShouldBeTrueWhenLastItemIsCompleted()
        {
            MainContent.TodoItems[0].Complete();
            MainContent.TodoItems[1].Complete();
            MainContent.TodoItems[2].Complete();

            Assert.True(MainContent.AllCompleted.Value);
        }

        [Fact]
        public void AllCompletedShouldBeNullWhenItemIsRevertedFromAllItemsCompleted()
        {
            MainContent.TodoItems[0].Complete();
            MainContent.TodoItems[1].Complete();
            MainContent.TodoItems[2].Complete();

            Assert.True(MainContent.AllCompleted.Value);

            MainContent.TodoItems[0].Revert();

            Assert.Null(MainContent.AllCompleted.Value);
        }

        [Fact]
        public void AllCompletedShouldBeFalseWhenAllItemsIsActive()
        {
            MainContent.TodoItems[0].Complete();
            MainContent.TodoItems[1].Complete();
            MainContent.TodoItems[2].Complete();

            Assert.True(MainContent.AllCompleted.Value);

            MainContent.TodoItems[0].Revert();
            MainContent.TodoItems[1].Revert();
            MainContent.TodoItems[2].Revert();

            Assert.False(MainContent.AllCompleted.Value);
        }

        [Fact]
        public void AllCompletedShouldBeNullWhenNewItemIsAddedFromAllItemsCompleted()
        {
            MainContent.TodoItems[0].Complete();
            MainContent.TodoItems[1].Complete();
            MainContent.TodoItems[2].Complete();

            Assert.True(MainContent.AllCompleted.Value);

            MainContent.TodoContent.Value = "Todo Item 4";
            MainContent.AddCurrentTodoContent();

            Assert.Null(MainContent.AllCompleted.Value);
        }
    }
}
