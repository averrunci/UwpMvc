// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Fievus.Windows.Mvc;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    public class HomeController
    {
        [DataContext]
        public HomeContent Content { get; set; }

        [EventHandler(ElementName = "LogoutButton", Event = "Click")]
        private void OnLogoutButtonClick()
        {
            Content.Logout();
        }
    }
}
