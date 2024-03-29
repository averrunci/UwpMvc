﻿// Copyright (C) 2018-2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Charites.Windows.Mvc.Bindings;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation
{
    public class ApplicationHost
    {
        public ObservableProperty<object> Content { get; } = new ObservableProperty<object>();
    }
}
