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

namespace WPF_menu
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void mnItemHerramientas_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Esto es un evento");
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            Acerca_De _acercaDe = new Acerca_De();
            _acercaDe.ShowDialog();
        }

        private void MenuItem_Click_1(object sender, RoutedEventArgs e)
        {
            //Menú contextual window.click, opción "Copiar"
            MessageBox.Show("Copiando...");
        }
    }
}
