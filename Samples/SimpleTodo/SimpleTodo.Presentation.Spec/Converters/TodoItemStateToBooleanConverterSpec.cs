// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Carna;

namespace Charites.Windows.Samples.SimpleTodo.Presentation.Converters
{
    [Specification("TodoItemStateToBooleanConverter Spec")]
    class TodoItemStateToBooleanConverterSpec : FixtureSteppable
    {
        TodoItemStateToBooleanConverter Converter { get; } = new TodoItemStateToBooleanConverter();

        [Example("Converts a TodoItemState to a boolean value")]
        [Sample(TodoItemState.Active, false, Description = "When a TodoItemState is Active")]
        [Sample(TodoItemState.Completed, true, Description = "When a TodoItemState is Completed")]
        [Sample(TodoItemState.All, false, Description = "When a TodoItemState is All")]
        void Ex01(TodoItemState value, bool expected)
        {
            Expect($"the converted value should be {expected}", () => Equals(Converter.Convert(value, value.GetType(), null, null), expected));
        }

        [Example("Converts a boolean value to a TodoItemState")]
        [Sample(true, TodoItemState.Completed, Description = "When a value is true")]
        [Sample(false, TodoItemState.Active, Description = "When a value is false")]
        void Ex02(bool value, TodoItemState expected)
        {
            Expect($"the converted value should be {expected}", () => Equals(Converter.ConvertBack(value, value.GetType(), null, null), expected));
        }
    }
}
