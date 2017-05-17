using System.Windows;

namespace PreviousDataBindingWheelIssue
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            DataContext = new MyModel();
        }
    }
}