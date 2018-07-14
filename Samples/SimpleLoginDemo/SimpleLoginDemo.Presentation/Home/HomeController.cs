// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Primitives;
using Charites.Windows.Mvc;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    [View(Key = nameof(HomeContent))]
    public class HomeController
    {
        [DataContext]
        private HomeContent Content { get; set; }

        [EventHandler(ElementName = "LogoutButton", Event = nameof(ButtonBase.Click))]
        private void OnLogoutButtonClick()
        {
            Content.Logout();
        }
    }
}
