using aab_EventCommandsMVVM.ViewModels;
using System.Windows;

namespace aab_EventCommandsMVVM.Views
{
    /// <summary>
    /// Interaction logic for MainView.xaml
    /// </summary>
    public partial class MainView : Window
    {
        public MainView()
        {
            InitializeComponent();

            DataContext = new MainViewModel();
        }
    }
}
