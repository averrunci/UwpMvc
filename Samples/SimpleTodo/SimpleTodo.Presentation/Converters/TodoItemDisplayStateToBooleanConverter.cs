// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Data;

namespace Charites.Windows.Samples.SimpleTodo.Presentation.Converters
{
    public class TodoItemDisplayStateToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
           if (!Enum.TryParse(parameter?.ToString(), out TodoItemState state)) throw new ArgumentException(nameof(parameter));

            return (TodoItemState)value == state;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            if (!Enum.TryParse(parameter?.ToString(), out TodoItemState state)) throw new ArgumentException(nameof(parameter));

            return (bool)value ? state : TodoItemState.All;
        }
    }
}
