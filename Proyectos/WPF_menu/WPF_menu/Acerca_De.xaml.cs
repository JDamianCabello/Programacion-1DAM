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

namespace WPF_menu
{
    /// <summary>
    /// Lógica de interacción para Acerca_De.xaml
    /// </summary>
    public partial class Acerca_De : Window
    {
        public Acerca_De()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //boton cerrar del acerca de....
            this.Close();
        }
    }
}
