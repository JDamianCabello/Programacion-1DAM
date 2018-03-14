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

namespace WPF_boton
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        

        public MainWindow()
        {
            InitializeComponent();
            Miboton.Focus();
        }

        //manejador/controlador del evento click del botón
        bool color = true;
        private void LoHeClickcado(object sender, RoutedEventArgs e)
        {
            if(color)
            {
                Miboton.Background = Brushes.Cyan;
            }
            else
            {
                Miboton.Background = Brushes.DarkBlue;
            }
            color = !color;
        }

        private void Miboton_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Escape)
                MessageBox.Show("Has pulsado Escape");
        }

    }
}
