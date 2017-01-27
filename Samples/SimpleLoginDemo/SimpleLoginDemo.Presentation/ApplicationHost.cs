// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using System;

using Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation
{
    public class ApplicationHost
    {
        public Type InitialPageType { get; set; } = typeof(LoginPage);
        public object InitialPageContent { get; set; } = new LoginContent();
    }
}
