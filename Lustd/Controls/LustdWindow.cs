using System.Windows;

namespace Lustd.Controls
{
    public class LustdWindow : Window
    {
        public LustdWindow()
        {
            Style = (Style)FindResource(typeof(Window));
        }
    }
}
