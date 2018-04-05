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

namespace WPF_Canvas
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
            Rectangle rectangulo = new Rectangle();
            rectangulo.Width = 50;
            rectangulo.Height = 50;
            rectangulo.Fill = new SolidColorBrush(Colors.Blue);

            //Añadirlo al canvas
            Canvas.SetLeft(rectangulo, 20);
            Canvas.SetTop(rectangulo, 200);

            cnv_panel.Children.Add(rectangulo);
        }

        void 
    }
}
