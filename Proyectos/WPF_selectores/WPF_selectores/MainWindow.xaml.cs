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
//----------------------------
using System.ComponentModel;

namespace WPF_selectores
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

        private void btn_ordenar_Click(object sender, RoutedEventArgs e)
        {
            lbx_lista.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Ascending));
        }

        private void cbx_Ordenar_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            lbx_lista.Items.SortDescriptions.Clear();

            if(cbx_Ordenar.SelectedIndex == 0)
            {
                lbx_lista.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Ascending));
                lbl_tipoOrdenacion.Content = "Ordenación: Ascendente";
            }
            else if(cbx_Ordenar.SelectedIndex == 1)
            {
                lbx_lista.Items.SortDescriptions.Add(new SortDescription("Content", ListSortDirection.Descending));
                lbl_tipoOrdenacion.Content = "Ordenación: Descendente";
            }
        }
    }
}
