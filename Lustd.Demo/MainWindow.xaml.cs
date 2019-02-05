using System.Collections.Generic;

namespace Lustd.Demo
{
    public partial class MainWindow
    {
        public MainWindow()
        {
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
