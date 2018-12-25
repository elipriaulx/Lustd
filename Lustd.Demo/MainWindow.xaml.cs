using System.Windows;

namespace Lustd.Demo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            Style = (Style)FindResource(typeof(Window));
            InitializeComponent();
        }
    }
}
