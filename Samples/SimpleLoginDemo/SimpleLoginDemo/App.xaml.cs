// Copyright (C) 2018 Fievus
//
// This software may be modified and distributed under the terms
// of the MIT license.  See the LICENSE file for details.

using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Charites.Windows.Mvc;
using Charites.Windows.Samples.SimpleLoginDemo.Presentation;

namespace Charites.Windows.Samples.SimpleLoginDemo
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();

            UwpController.ControllerFactory = new SimpleLoginDemoControllerFactory();

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
