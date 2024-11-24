using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WpfApp1.Controllers;
using WpfApp1.Model;
using WpfApp1.Services;
using WpfApp1.ViewModel;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        vmMainWindow viewModel;
        public MainWindow()
        {
            InitializeComponent();
            Console.WriteLine("MainWindow constructor ejecutado.");

            viewModel = new vmMainWindow();

            DataContext = viewModel;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            viewModel.Report();

            MessageBox.Show($"La carpeta donde están los reportes es:\n\\bin\\Debug\\Reports\\Generated",
                            "Ruta de los reportes", 
                            MessageBoxButton.OK,   
                            MessageBoxImage.Information);         
        }
    }
}