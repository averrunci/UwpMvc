// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.Resources;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation
{
    public static class Resources
    {
        public static string LoginFailure => GetString("LoginFailure");
        public static string UserMessageFormat => GetString("UserMessageFormat");

        private static string GetString(string name) => ResourceLoader.GetForCurrentView("SimpleLoginDemo.Presentation/Resources").GetString(name);
    }
}
