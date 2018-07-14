using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;

using Carna.UwpRunner;

namespace UwpMvc.Spec
{
    sealed partial class App : Application
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
