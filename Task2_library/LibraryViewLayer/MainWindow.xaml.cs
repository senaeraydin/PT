using LibraryLogicLayer;
using LibraryViewModelLayer;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LibraryViewLayer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var dataLayer = new LibraryDataLayer.LibraryData("your_connection_string");
            var logicLayer = new LibraryLogicL(dataLayer);
            DataContext = new UserViewModel(logicLayer);
        }
    }
}