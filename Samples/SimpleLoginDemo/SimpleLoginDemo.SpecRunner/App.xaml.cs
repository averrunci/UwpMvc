// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

using Carna.UwpRunner;

namespace Charites.Windows.Samples.SimpleLoginDemo.SpecRunner
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Window.Current.Activate();
            CarnaUwpRunner.Run();
        }
    }
}
