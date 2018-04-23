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

namespace WPF_IntercambiarDatos
{
    /// <summary>
    /// Lógica de interacción para Ventana2.xaml
    /// </summary>
    public partial class Ventana2 : Window
    {
        public delegate void dlgEnviar(string[] datos);
        public event dlgEnviar OnEnviar;

        public Ventana2()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(OnEnviar != null)
            {
                string[] datos = { tbx_Dato1.Text, tbx_Dato2.Text };
                OnEnviar(datos);
            }
        }

        private void tbx_Dato1_TextChanged(object sender, TextChangedEventArgs e)
        {
            Button_Click(null, null);
        }

        private void tbx_Dato2_TextChanged(object sender, TextChangedEventArgs e)
        {
            tbx_Dato1_TextChanged(null, null);
        }
    }
}
