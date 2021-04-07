// Copyright (C) 2018-2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls.Primitives;
using Charites.Windows.Mvc;
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    [View(Key = nameof(HomeContent))]
    public class HomeController
    {
        private IContentNavigator Navigator { get; }

        public HomeController(IContentNavigator navigator)
        {
            Navigator = navigator.RequireNonNull(nameof(navigator));
        }

        [EventHandler(ElementName = "LogoutButton", Event = nameof(ButtonBase.Click))]
        private void OnLogoutButtonClick()
        {
            Navigator.NavigateTo(new LoginContent());
        }
    }
}
