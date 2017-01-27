// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

using Xunit;

namespace Fievus.Windows.Samples.SimpleTodo.Converters
{
    public class TodoItemStateToBooleanConverterTest
    {
        private TodoItemStateToBooleanConverter Converter { get; }

        public TodoItemStateToBooleanConverterTest()
        {
            Converter = new TodoItemStateToBooleanConverter();
        }

        [Fact]
        public void ShouldConvertToTrueWhenValueIsCompleted()
        {
            var value = TodoItemState.Completed;

            Assert.Equal(true, Converter.Convert(value, value.GetType(), null, null));
        }

        [Fact]
        public void ShouldConvertToFalseWhenValueIsActive()
        {
            var value = TodoItemState.Active;

            Assert.Equal(false, Converter.Convert(value, value.GetType(), null, null));
        }

        [Fact]
        public void ShouldConvertBackToCompletedWhenValueIsTrue()
        {
            var value = true;

            Assert.Equal(TodoItemState.Completed, Converter.ConvertBack(value, value.GetType(), null, null));
        }

        [Fact]
        public void ShouldConvertBackToActiveWhenValueIsFalse()
        {
            var value = false;

            Assert.Equal(TodoItemState.Active, Converter.ConvertBack(value, value.GetType(), null, null));
        }

        [Fact]
        public void ShouldThrowExceptionWhenConvertingWithValueThatIsNotTypeOfTodoItemState()
        {
            var value = new object();

            Assert.Throws<ArgumentException>(() => Converter.Convert(value, value.GetType(), null, null));
        }

        [Fact]
        public void ShouldThrowExceptionWhenConvertingBackWithValueThatIsNotTypeOfBoolean()
        {
            var value = new object();

            Assert.Throws<ArgumentException>(() => Converter.ConvertBack(value, value.GetType(), null, null));
        }
    }
}
