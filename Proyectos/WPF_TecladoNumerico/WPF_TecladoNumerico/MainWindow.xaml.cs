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

namespace WPF_TecladoNumerico
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            LlenarGridAlea();
        }

        private void LlenarGridAlea()
        {
            //Rellena la grid de 3x3 con textblock con nº aleatorios
            List<int> listaNumeros = new List<int>(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 });
            Random rnd = new Random();
            int pos = 0;

            for(int i = 0; i < MiGrid.RowDefinitions.Count; i++)
                for(int j = 0; j < MiGrid.ColumnDefinitions.Count; j++)
                {
                    pos = rnd.Next(listaNumeros.Count);
                    TextBlock tbxTemp = new TextBlock();
                    tbxTemp.FontFamily = new FontFamily("Comic sans");
                    tbxTemp.FontSize = 75;
                    tbxTemp.VerticalAlignment = VerticalAlignment.Center;
                    tbxTemp.HorizontalAlignment = HorizontalAlignment.Center;
                    tbxTemp.Foreground = new SolidColorBrush(Colors.LemonChiffon);
                    tbxTemp.Background = new SolidColorBrush(Colors.PowderBlue);
                    tbxTemp.Height = 80;
                    tbxTemp.Width = tbxTemp.Height;
                    tbxTemp.TextAlignment = TextAlignment.Center;
                    tbxTemp.Text = listaNumeros[pos].ToString();
                    listaNumeros.RemoveAt(pos);


                    //Posiciono el textblock en la celda
                    Grid.SetRow(tbxTemp, i);
                    Grid.SetColumn(tbxTemp, j);

                    //Añado el textblock a la colección del Grid
                    MiGrid.Children.Add(tbxTemp);
                }
        }
    }
}
