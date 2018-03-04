// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace Fievus.Windows.Mvc.Converters
{
    internal sealed class BooleanToTextWrappingConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
            => (bool)value ? TextWrapping.Wrap : TextWrapping.NoWrap;

        public object ConvertBack(object value, Type targetType, object parameter, string language)
            => (TextWrapping)value == TextWrapping.Wrap;
    }
}
