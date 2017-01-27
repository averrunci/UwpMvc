// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

using Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Login;

namespace Fievus.Windows.Samples.SimpleLoginDemo.Presentation.Home
{
    public sealed partial class HomePage : Page
    {
        public HomePage()
        {
            InitializeComponent();
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            DataContext = e.Parameter;

            (DataContext as HomeContent).IfPresent(homeContent =>
                homeContent.LogoutRequested += (s, args) =>
                    Frame.Navigate(typeof(LoginPage), new LoginContent())
            );

            base.OnNavigatedTo(e);
        }
    }
}
