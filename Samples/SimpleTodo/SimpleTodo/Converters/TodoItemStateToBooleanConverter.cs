// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Data;

namespace Fievus.Windows.Samples.SimpleTodo.Converters
{
    public class TodoItemStateToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            if (!(value is TodoItemState)) { throw new ArgumentException(nameof(value)); }

            return (TodoItemState)value == TodoItemState.Completed;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (!(value is bool)) { throw new ArgumentException(nameof(value)); }

            return (bool)value ? TodoItemState.Completed : TodoItemState.Active;
        }
    }
}
