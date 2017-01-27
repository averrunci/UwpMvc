// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

using Xunit;

namespace Fievus.Windows.Samples.SimpleTodo.Converters
{
    public class BooleanToVisibilityConverterTest
    {
        private BooleanToVisibilityConverter Converter { get; }

        public BooleanToVisibilityConverterTest()
        {
            Converter = new BooleanToVisibilityConverter();
        }

        [Fact]
        public void ShouldConvertToVisibleWhenValueIsTrue()
        {
            Assert.Equal(Visibility.Visible, Converter.Convert(true, typeof(bool), null, null));
        }

        [Fact]
        public void ShouldConvertToCollapsedWhenValueIsFalse()
        {
            Assert.Equal(Visibility.Collapsed, Converter.Convert(false, typeof(bool), null, null));
        }

        [Fact]
        public void ShouldConvertBackToTrueWhenValueIsVisible()
        {
            Assert.Equal(true, Converter.ConvertBack(Visibility.Visible, typeof(Visibility), null, null));
        }

        [Fact]
        public void ShouldConvertBackToFalseWhenValueIsCollapsed()
        {
            Assert.Equal(false, Converter.ConvertBack(Visibility.Collapsed, typeof(Visibility), null, null));
        }
    }
}
