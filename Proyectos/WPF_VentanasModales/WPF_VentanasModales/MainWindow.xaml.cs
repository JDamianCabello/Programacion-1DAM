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
using Microsoft.Win32;

namespace WPF_VentanasModales
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
            string mensaje = "Soy el mensaje del cuadro de diálogo.";
            string titulo = "Soy el título...";

            MessageBoxResult botonPulsado = new MessageBoxResult();
            MessageBoxButton botones = MessageBoxButton.YesNoCancel;
            MessageBoxImage icono = MessageBoxImage.Information;

            botonPulsado = MessageBox.Show(mensaje, titulo, botones, icono);

            if(botonPulsado == MessageBoxResult.Yes)
                MessageBox.Show("Po vale");
            else if(botonPulsado == MessageBoxResult.No)
                MessageBox.Show("Po ná");
            else
                MessageBox.Show("Ere una desgracia");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            //Abrir archivo
            OpenFileDialog opfAbrir = new OpenFileDialog();
            opfAbrir.InitialDirectory = @"c:\basura";
            opfAbrir.FileName = "Nombre_Fichero_Defecto";
            opfAbrir.DefaultExt = ".txt";
            opfAbrir.Filter = "Textos | *.txt|Todos | *.*";


            Nullable<bool> resultado = opfAbrir.ShowDialog();

            if(resultado == true)
                this.Title = opfAbrir.FileName;

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            SaveFileDialog sfGuardar = new SaveFileDialog();
            sfGuardar.InitialDirectory = @"c:\basura";
            sfGuardar.FileName = "Fichero mio";
            sfGuardar.DefaultExt = "mio";


            Nullable<bool> resultado = sfGuardar.ShowDialog();

            if(resultado == true)
                this.Title = sfGuardar.FileName;
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            PrintDialog prinImprimir = new PrintDialog();

            Nullable<bool> resultado = prinImprimir.ShowDialog();

            if(resultado == true)
                this.Title = "Imprimiendo....";
        }
    }
}
