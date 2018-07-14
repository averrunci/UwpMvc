// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Navigation;
using Charites.Windows.Samples.SimpleLoginDemo.Presentation.Home;

namespace Charites.Windows.Samples.SimpleLoginDemo.Presentation.Login
{
    public sealed partial class LoginPage
    {
        public LoginPage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = e.Parameter;

            (DataContext as LoginContent).IfPresent(loginContent =>
                loginContent.LoginRequested += (s, args) =>
                    Frame.Navigate(typeof(HomePage), new HomeContent(loginContent.UserId.Value))
            );

            base.OnNavigatedTo(e);
        }
    }
}
