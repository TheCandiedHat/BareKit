using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

using MonoGame.Framework;

using BareKit;

namespace Bare
{
    public sealed partial class Bootstrap : Page
    {
        Entrypoint entrypoint;

        public Bootstrap()
        {
            InitializeComponent();

            entrypoint = XamlGame<Entrypoint>.Create(string.Empty, Window.Current.CoreWindow, canvas);
        }
    }
}

