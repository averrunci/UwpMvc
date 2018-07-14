// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml.Data;

namespace Charites.Windows.Samples.SimpleTodo.Presentation.Converters
{
    public class TodoItemStateToBooleanConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
            => (TodoItemState)value == TodoItemState.Completed;

        public object ConvertBack(object value, Type targetType, object parameter, string language)
            => (bool)value ? TodoItemState.Completed : TodoItemState.Active;
    }
}
