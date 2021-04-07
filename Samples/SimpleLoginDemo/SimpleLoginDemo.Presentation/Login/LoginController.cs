// Copyright (C) 2018-2021 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Charites.Windows.Mvc;
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    [View(Key = nameof(LoginContent))]
    public class LoginController
    {
        [DataContext]
        private LoginContent Content { get; set; }

        [Element]
        private PasswordBox PasswordBox { get; set; }
        
        private IContentNavigator Navigator { get; }
        private IUserAuthentication UserAuthentication { get; }

        public LoginController(IContentNavigator navigator, IUserAuthentication userAuthentication)
        {
            Navigator = navigator.RequireNonNull(nameof(navigator));
            UserAuthentication = userAuthentication.RequireNonNull(nameof(userAuthentication));
        }

        [EventHandler(Event = nameof(FrameworkElement.Loaded))]
        private void OnLoaded()
        {
            PasswordBox.PasswordChanged += (s, e) => Content.Password.Value = PasswordBox.Password;
        }

        [EventHandler(ElementName = "LoginButton", Event = nameof(ButtonBase.Click))]
        private void OnLoginButtonClick()
        {
            Content.Message.Value = string.Empty;

            if (!Content.IsValid.Value) { return; }

            switch (UserAuthentication.Authenticate(Content))
            {
                case UserAuthenticationResult.Success:
                    Navigator.NavigateTo(new HomeContent(Content.UserId.Value));
                    break;
                case UserAuthenticationResult.Failure:
                    Content.Message.Value = Resources.LoginFailure;
                    break;
            }
        }
    }
}
