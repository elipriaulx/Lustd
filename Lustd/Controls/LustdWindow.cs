using System.Windows;

namespace Lustd.Controls
{
    public abstract class LustdWindow : Window
    {
        protected LustdWindow()
        {
            Style = (Style)FindResource(typeof(Window));
        }
    }
}
