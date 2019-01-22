using System.Collections.Generic;
using System.Windows;

namespace Lustd.Demo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
            Style = (Style)FindResource(typeof(Window));
            InitializeComponent();
            DataContext = this;
        }

        public IEnumerable<string> ExampleData { get; } = new List<string>
        {
            "Example A",
            "Example B",
            "Example C",
            "Example D",
        };
    }
}
