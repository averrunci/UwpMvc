// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Carna;

namespace Charites.Windows.Samples.SimpleTodo.Presentation.Converters
{
    [Specification("TodoItemDisplayStateToBooleanConverter Spec")]
    class TodoItemDisplayStateToBooleanConverterSpec : FixtureSteppable
    {
        TodoItemDisplayStateToBooleanConverter Converter { get; } = new TodoItemDisplayStateToBooleanConverter();

        [Example("Converts a display state of a TodoItem with a parameter to a boolean value")]
        [Sample(TodoItemState.All, "All", true, Description = "When a display state of a TodoItem is equal to a parameter")]
        [Sample(TodoItemState.All, "Active", false, Description = "When a display state of a TodoItem is not equal to a parameter")]
        void Ex01(TodoItemState value, string parameter, bool expected)
        {
            Expect($"the converted value should be {expected}", () => Equals(Converter.Convert(value, value.GetType(), parameter, null), expected));
        }

        [Example("Converts a boolean value with a parameter to a display state of a TodoItem")]
        [Sample(true, "Active", TodoItemState.Active, Description = "When a value is true and a parameter is 'Active'")]
        [Sample(true, "Completed", TodoItemState.Completed, Description = "When a value is true and a parameter is 'Completed'")]
        [Sample(true, "All", TodoItemState.All, Description = "When a value is true and a parameter is 'All'")]
        [Sample(false, "Active", TodoItemState.All, Description = "When a value is false and a parameter is 'Active'")]
        [Sample(false, "Completed", TodoItemState.All, Description = "When a value is false and a parameter is 'Completed'")]
        [Sample(false, "All", TodoItemState.All, Description = "When a value is false and a parameter is 'All'")]
        void Ex02(bool value, string parameter, TodoItemState expected)
        {
            Expect($"the converted value should be {expected}", () => Equals(Converter.ConvertBack(value, value.GetType(), parameter, null), expected));
        }
    }
}
