// Copyright (C) 2017 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using Fievus.Windows.Mvc;

using Fievus.Windows.Samples.SimpleLoginDemo.Presentation;

namespace Fievus.Windows.Samples.SimpleLoginDemo
{
    sealed partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            UwpController.Factory = new SimpleLoginDemoControllerFactory();

            Suspending += OnSuspending;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            var applicationHost = Window.Current.Content as ContentControl;
            if (applicationHost == null)
            {
                applicationHost = new ContentControl
                {
                    Content = new ApplicationHost()
                };

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                Window.Current.Content = applicationHost;
            }

            if (!e.PrelaunchActivated)
            {
                Window.Current.Activate();
            }
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();

            //TODO: Save application state and stop any background activity

            deferral.Complete();
        }
    }
}
