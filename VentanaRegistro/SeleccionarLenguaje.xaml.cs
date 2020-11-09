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
using System.Windows.Shapes;

namespace VentanaRegistro
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void btn_Esp_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.languageCode = "es-MX";
            new MainWindow().ShowDialog();

            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }

        private void btn_Ingles_Click(object sender, RoutedEventArgs e)
        {
            Properties.Settings.Default.languageCode = "en-US";
            Console.WriteLine("Cambio a ingles (?)");
            new MainWindow().ShowDialog();

            Properties.Settings.Default.Save();
            Environment.Exit(0);
        }
    }
}
