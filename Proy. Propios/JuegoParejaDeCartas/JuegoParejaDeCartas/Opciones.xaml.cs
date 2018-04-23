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
using System.IO;
using System.Windows.Interop;

namespace JuegoParejaDeCartas
{
    /// <summary>
    /// Lógica de interacción para Opciones.xaml
    /// </summary>
    public partial class Opciones : Window
    {
        public Opciones()
        {
            InitializeComponent();
        }

        private void CargarFondos(string seleccion)
        {
            cbx_fondo.Items.Clear();
            DirectoryInfo carpeta = new DirectoryInfo(@"imagenes/"+seleccion+@"/fondos");
            FileInfo[] ficheros = carpeta.GetFiles();
            List<Image> imagenes = new List<Image>();
            Image imagen;
            for (int i = 0; i < ficheros.Length; i++)
            {
                imagen = new Image();
                Uri unaRuta = new Uri(ficheros[i].FullName);
                BitmapImage unaRutaValida = new BitmapImage(unaRuta);
                imagen.Height = 100;
                imagen.Width = 120;
                imagen.Source = unaRutaValida;

                imagenes.Add(imagen);
            }

            for (int i = 0; i < imagenes.Count; i++)
            {
                cbx_fondo.Items.Add(imagenes[i]);
            }

        }

        private void CargarReversos(string seleccion)
        {
            cbx_reversoCartas.Items.Clear();
            DirectoryInfo carpeta = new DirectoryInfo(@"imagenes/" + seleccion + @"/cartas");
            FileInfo[] ficheros = carpeta.GetFiles();
            List<Image> imagenes = new List<Image>();
            Image imagen;
            for (int i = 0; i < ficheros.Length; i++)
            {
                imagen = new Image();
                Uri unaRuta = new Uri(ficheros[i].FullName);
                BitmapImage unaRutaValida = new BitmapImage(unaRuta);
                imagen.Height = 80;
                imagen.Width = 80;
                imagen.Source = unaRutaValida;

                imagenes.Add(imagen);
            }

            for (int i = 0; i < imagenes.Count; i++)
            {
                cbx_reversoCartas.Items.Add(imagenes[i]);
            }

        }

        private void CargarTemáticas()
        {
            DirectoryInfo carpeta = new DirectoryInfo(@"imagenes");
            DirectoryInfo[] ficheros = carpeta.GetDirectories();
            for (int i = 0; i < ficheros.Length; i++)
            {
                cbx_tematica.Items.Add(ficheros[i].Name);
            }

        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            CargarTemáticas();
            chec_alea.IsChecked = Variables.aleatorio;
            chec_alea.IsChecked = Variables.repeticionCartas;
        }

        private void cbx_fondo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Image imagen = (Image)cbx_fondo.SelectedItem;
            Uri imageUri;
            BitmapImage image = null;

            if(imagen != null)
            {
                if(Uri.TryCreate(imagen.Source.ToString(), UriKind.RelativeOrAbsolute, out imageUri))
                {
                    image = new BitmapImage(imageUri);
                }
                ImageBrush imageBrush = new ImageBrush();
                imageBrush.ImageSource = image;
                Variables.fondoTablero.ImageSource = imageBrush.ImageSource;
                exp_vistaPrevia.Background = imageBrush; 
            }
        }

        private void cbx_reversoCartas_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            spn_vistaPreviaCartas.Children.Clear();
            Image imagen = (Image)cbx_reversoCartas.SelectedItem;
            if(imagen != null)
            {
                for(int i = 0; i < 2; i++)
                {
                    DockPanel unDockPanel = new DockPanel();
                    unDockPanel.Height = 125;

                    for(int j = 0; j < 3; j++)
                    {
                        //Se crea la imagen
                        Image unaImagen = new Image();
                        unaImagen.Source = imagen.Source;
                        unaImagen.Width = 80;
                        unaImagen.Height = 80;
                        unaImagen.MouseUp += UnaImagen_MouseUp;


                        //La añadimos al dockpanel
                        unDockPanel.Children.Add(unaImagen);
                    }

                    //Se añade el dockPanel al contenedor
                    spn_vistaPreviaCartas.Children.Add(unDockPanel);
                }
                Variables.reversoCarta.Source = imagen.Source; 
            }
        }

        private void UnaImagen_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Image imagen = (Image)sender;
            DirectoryInfo carpeta = new DirectoryInfo(@"imagenes/" + Variables.tematicaPath + @"/juego");
            FileInfo[] ficheros = carpeta.GetFiles();
            Random rnd = new Random();
            Image unaImagen = new Image();
            Uri unaRuta = new Uri(ficheros[rnd.Next(ficheros.Length)].FullName);
            BitmapImage unaRutaValida = new BitmapImage(unaRuta);
            unaImagen.Height = 80;
            unaImagen.Width = 80;
            unaImagen.Source = unaRutaValida;
            imagen.Source = unaImagen.Source;
            imagen.MouseUp -= UnaImagen_MouseUp;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            Variables.repeticionCartas = true;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            Variables.repeticionCartas = false;
        }

        private void cbx_tematica_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Variables.tematicaPath = cbx_tematica.SelectedItem.ToString();
            CargarFondos(Variables.tematicaPath);
            CargarReversos(Variables.tematicaPath);
        }

        private void chec_alea_Checked(object sender, RoutedEventArgs e)
        {
            DeshabilitaInterfaz(true);
        }

        private void chec_alea_Unchecked(object sender, RoutedEventArgs e)
        {
            DeshabilitaInterfaz(false);
        }

        private void DeshabilitaInterfaz(bool boleano)
        {
            Variables.aleatorio = boleano;
            cbx_tematica.IsEnabled = !boleano;
            cbx_reversoCartas.IsEnabled = !boleano;
            cbx_fondo.IsEnabled = !boleano;
            exp_vistaPrevia.IsEnabled = !boleano;
            if(boleano)
                this.Width = this.Width / 2;
            else
                this.Width = this.Width * 2;
        }

        private void cbx_dificultad_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            switch(cbx_dificultad.SelectedIndex)
            {
                case 0:
                    Variables.totalCartas = 5;
                    break;
                case 1:
                    Variables.totalCartas = 10;
                    break;
                case 2:
                    Variables.totalCartas = 20;
                    break;
                case 3:
                    Variables.totalCartas = 25;
                    break;
            }
        }
   
    }
}
