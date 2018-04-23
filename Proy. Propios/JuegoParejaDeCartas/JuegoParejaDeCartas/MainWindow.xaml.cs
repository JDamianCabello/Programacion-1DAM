using System;
using System.Collections.Generic;
using System.IO;
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

namespace JuegoParejaDeCartas
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ImageBrush fondoTablero = Variables.fondoTablero;
        Image reversoCarta = Variables.reversoCarta;
        bool repeticionCartas = Variables.repeticionCartas;
        int totalCartas = Variables.totalCartas;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GeneraAlea(Variables.aleatorio);
            Juego unJuego = new Juego(Variables.totalCartas, fondoTablero, reversoCarta, false);
            unJuego.Show();
            Hide();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Opciones opciones = new Opciones();
            opciones.Show();
        }

        private void GeneraAlea(bool repeticion)
        {
            if(Variables.tematicaPath == null || repeticion)
            {
                Random rnd = new Random();

                if(Variables.totalCartas == 0)
                    Variables.totalCartas = 10;
                //Se cargan las temáticas
                DirectoryInfo carpeta = new DirectoryInfo(@"imagenes");
                DirectoryInfo[] auxiliar = carpeta.GetDirectories();

                //Se elige una temática aleatoria
                Variables.tematicaPath = auxiliar[rnd.Next(auxiliar.Length)].Name;


                //Se cambia la carpeta a la de cartas
                carpeta = new DirectoryInfo(@"imagenes/" + Variables.tematicaPath + @"/cartas");
                FileInfo[] ficheros = carpeta.GetFiles();
                Image imagen = new Image();
                imagen.Height = 80;
                imagen.Width = 80;
                Uri unaRuta = new Uri(ficheros[rnd.Next(ficheros.Length)].FullName);
                BitmapImage unaRutaValida = new BitmapImage(unaRuta);
                Variables.reversoCarta.Source = unaRutaValida;

                //Se cambia la carpeta a fondos
                carpeta = new DirectoryInfo(@"imagenes/" + Variables.tematicaPath + @"/fondos");
                ficheros = carpeta.GetFiles();
                unaRuta = new Uri(ficheros[rnd.Next(ficheros.Length)].FullName);
                unaRutaValida = new BitmapImage(unaRuta);
                imagen.Source = unaRutaValida;
                Uri imageUri;
                BitmapImage image = null;
                if(Uri.TryCreate(imagen.Source.ToString(), UriKind.RelativeOrAbsolute, out imageUri))
                {
                    image = new BitmapImage(imageUri);
                }
                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = image;
                Variables.fondoTablero.ImageSource = imageBrush.ImageSource;
            }
        }
    }
}
