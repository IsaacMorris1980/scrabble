using System.Windows;

namespace Scrabble.View
{
    public partial class MobileHelpWindow : Window
    {
        public MobileHelpWindow()
        {
            InitializeComponent();
            WindowStartupLocation = System.Windows.WindowStartupLocation.CenterScreen;
            Topmost = true;
        }
    }
}
