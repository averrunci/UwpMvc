﻿// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;

namespace Charites.Windows.Mvc
{
    internal sealed class UwpDataContextFinder : IUwpDataContextFinder
    {
        public object Find(FrameworkElement view) => view.DataContext;
    }
}
