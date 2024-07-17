using System.Windows;

namespace Scrabble.View
{
    public partial class DesktopHelpWindow : Window
    {
        public DesktopHelpWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Topmost = true;
        }
    }
}
