// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.Resources;
using Windows.UI.Xaml.Controls;

using Fievus.Windows.Mvc;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    public class LoginController
    {
        [DataContext]
        public LoginContent Content { get; set; }

        [Element]
        public PasswordBox PasswordBox { get; set; }

        private IUserAuthentication UserAuthentication { get; }

        public LoginController(IUserAuthentication userAuthentication)
        {
            UserAuthentication = userAuthentication.RequireNonNull(nameof(userAuthentication));
        }

        [EventHandler(Event = "Loaded")]
        private void OnLoaded()
        {
            PasswordBox.PasswordChanged += (s, e) => Content.Password.Value = PasswordBox.Password;
        }

        [EventHandler(ElementName = "LoginButton", Event = "Click")]
        private void OnLoginButtonClick()
        {
            Content.Message.Value = string.Empty;

            if (!Content.IsValid.Value) { return; }

            switch (UserAuthentication.Authenticate(Content))
            {
                case UserAuthenticationResult.Success:
                    Content.Login();
                    break;
                case UserAuthenticationResult.Failure:
                    Content.Message.Value = ResourceLoader.GetForCurrentView("SimpleLoginDemo.Presentation/Resources").GetString("LoginFailure");
                    break;
            }
        }
    }
}
