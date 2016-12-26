using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.ViewManagement;

namespace Bare
{
    sealed partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            Suspending += OnSuspending;

            RequiresPointerMode = ApplicationRequiresPointerMode.WhenRequested;
        }

        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
            Frame frame = Window.Current.Content as Frame;
            if (frame == null)
                frame = new Frame();

            if (frame.Content == null)
                frame.Navigate(typeof(Bootstrap));

            ApplicationView.GetForCurrentView().SetDesiredBoundsMode(ApplicationViewBoundsMode.UseCoreWindow);

            Window.Current.Content = frame;
            Window.Current.Activate();
        }

        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            SuspendingDeferral deferral = e.SuspendingOperation.GetDeferral();
            deferral.Complete();
        }
    }
}
