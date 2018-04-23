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

namespace WPF_IntercambiarDatos
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Ventana2 ventana = new Ventana2();
            ventana.OnEnviar += ventana_OnEnviar;
            ventana.ShowDialog();
        }

        void ventana_OnEnviar(string[] datos)
        {
            tbx_Dato1.Text = datos[0];
            tbx_Dato2.Text = datos[1];
        }
    }
}
