// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Charites.Windows.Mvc
{
    public class TestElement : ContentControl
    {
        public event RoutedEventHandler Changed;

        public void RaiseChanged() => Changed?.Invoke(this, new RoutedEventArgs());
    }
}
