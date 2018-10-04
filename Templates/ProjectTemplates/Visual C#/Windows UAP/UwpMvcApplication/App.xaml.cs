using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace $safeprojectname$
{
    public sealed partial class App
    {
        public App()
        {
            InitializeComponent();

            EnteredBackground += OnEnteredBackground;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            if (!(Window.Current.Content is ContentControl))
            {
                var host = new ContentControl
                {
                    Content = new ApplicationHost()
                };

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    //TODO: Load state from previously suspended application
                }

                Window.Current.Content = host;
            }

            if (e.PrelaunchActivated) return;

            Window.Current.Activate();
        }

        private void OnEnteredBackground(object sender, EnteredBackgroundEventArgs e)
        {
            var deferral = e.GetDeferral();

            //TODO: Save application state and stop any background activity

            deferral.Complete();
        }
    }
}
