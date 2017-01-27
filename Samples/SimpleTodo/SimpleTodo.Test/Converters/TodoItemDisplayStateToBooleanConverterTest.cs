// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

using Xunit;

namespace Fievus.Windows.Samples.SimpleTodo.Converters
{
    public class TodoItemDisplayStateToBooleanConverterTest
    {
        private TodoItemDisplayStateToBooleanConverter Converter { get; }

        public TodoItemDisplayStateToBooleanConverterTest()
        {
            Converter = new TodoItemDisplayStateToBooleanConverter();
        }

        [Fact]
        public void ShouldConvertToTrueWhenValueIsEqualToParameter()
        {
            var value = TodoItemState.All;
            var parameter = "All";

            Assert.Equal(true, Converter.Convert(value, value.GetType(), parameter, null));
        }

        [Fact]
        public void ShouldConvertToFalseWhenValueIsEqualToParameter()
        {
            var value = TodoItemState.All;
            var parameter = "Active";

            Assert.Equal(false, Converter.Convert(value, value.GetType(), parameter, null));
        }

        [Fact]
        public void ShouldConvertBackToSpecifiedParameterWhenValueIsTrue()
        {
            var value = true;
            var parameter = "Completed";

            Assert.Equal(TodoItemState.Completed, Converter.ConvertBack(value, value.GetType(), parameter, null));
        }

        [Fact]
        public void ShouldConvertBackToAllStateWhenValueIsFalse()
        {
            var value = false;
            var parameter = "Active";

            Assert.Equal(TodoItemState.All, Converter.ConvertBack(value, value.GetType(), parameter, null));
        }

        [Fact]
        public void ShouldThrowExceptionWhenConvertingWithValueThatIsNotTypeOfTodoItemState()
        {
            var value = new object();
            var parameter = "All";

            Assert.Throws<ArgumentException>(() => Converter.Convert(value, value.GetType(), parameter, null));
        }

        [Fact]
        public void ShouldThrowExceptionWhenConvertingWithParameterThatIsNotValueOfTodoItemState()
        {
            var value = TodoItemState.All;
            var parameter = new object();

            Assert.Throws<ArgumentException>(() => Converter.Convert(value, value.GetType(), parameter, null));
        }

        [Fact]
        public void ShouldThrowExceptionWhenConvertingBackWithValueThatIsNotTypeOfBoolean()
        {
            var value = new object();
            var parameter = "All";

            Assert.Throws<ArgumentException>(() => Converter.ConvertBack(value, value.GetType(), parameter, null));
        }

        [Fact]
        public void ShouldThrowExceptionWhenConvertingBackWithParameterThatIsNotValueOfTodoItemState()
        {
            var value = true;
            var parameter = new object();

            Assert.Throws<ArgumentException>(() => Converter.ConvertBack(value, value.GetType(), parameter, null));
        }
    }
}
