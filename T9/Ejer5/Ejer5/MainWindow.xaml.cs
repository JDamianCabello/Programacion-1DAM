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

namespace Ejer5
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        static int contador = 0;

        public MainWindow()
        {
            InitializeComponent();

        }

        private void btn_contadorUp_Click(object sender, RoutedEventArgs e)
        {
            if(contador < 99)
            {
                contador++;
                tbx_desplazamiento.Text = contador.ToString();
            }
        }

        private void btn_contadorDown_Click(object sender, RoutedEventArgs e)
        {
            if(contador > -99)
            {
                contador--;
                tbx_desplazamiento.Text = contador.ToString();
            }
        }

        private void btn_contadorUp_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void slr_Desplazamiento_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            contador = (int)slr_Desplazamiento.Value;
            tbx_desplazamiento.Text = contador.ToString();
        }
    }
}
