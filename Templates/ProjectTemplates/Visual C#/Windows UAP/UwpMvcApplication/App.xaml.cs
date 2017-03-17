using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace $safeprojectname$
{
    sealed partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            EnteredBackground += OnEnteredBackground;
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

        private void OnEnteredBackground(object sender, EnteredBackgroundEventArgs e)
        {
            var deferral = e.GetDeferral();

            //TODO: Save application state and stop any background activity

            deferral.Complete();
        }
    }
}
