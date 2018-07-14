// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;
using Carna;

namespace Charites.Windows.Samples.SimpleTodo.Presentation.Converters
{
    [Specification("BooleanToVisibilityConverter Spec")]
    class BooleanToVisibilityConverterSpec : FixtureSteppable
    {
        BooleanToVisibilityConverter Converter { get; } = new BooleanToVisibilityConverter();

        [Example("Converts a boolean value to a Visibility enum")]
        [Sample(true, Visibility.Visible, Description = "When a value is true")]
        [Sample(false, Visibility.Collapsed, Description = "When a value is false")]
        void Ex01(bool value, Visibility expected)
        {
            Expect($"the converted value should be {expected}", () => Equals(Converter.Convert(value, value.GetType(), null, null), expected));
        }

        [Example("Converts a Visibility enum to a boolean value")]
        [Sample(Visibility.Visible, true, Description = "When a value is Visible")]
        [Sample(Visibility.Collapsed, false, Description = "When a value is Collapsed")]
        void Ex02(Visibility value, bool expected)
        {
            Expect($"the converted value should be {expected}", () => Equals(Converter.ConvertBack(value, value.GetType(), null, null), expected));
        }
    }
}
