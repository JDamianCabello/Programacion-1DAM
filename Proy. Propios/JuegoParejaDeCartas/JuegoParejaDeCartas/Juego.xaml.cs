using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
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
using System.Windows.Threading;
using System.IO;


namespace JuegoParejaDeCartas
{
    /// <summary>
    /// Lógica de interacción para Juego.xaml
    /// </summary>
    public partial class Juego : Window
    {
        static string[,] _juegoActual;
        static bool[,] cartasQueSeCambian;
        int intentos = 0;
        static string[] _traseraCartas = LeerTraseraImagenes();
        int _totalVolteadas = 0;
        Image _imgAnterior = null;
        Image _traseraActual = null;
        int totalParejas = 0;
        int cartasVolteadas = 0;
        bool random = false;
        DispatcherTimer temporizador;

        public Juego(int cuantas, ImageBrush fondoTablero, Image reversoCarta, bool repeticion)
        {
            InitializeComponent();
            ven_interfaz.Background = fondoTablero;
            _juegoActual = GeneraTablero((MezclaCartasBaraja(DuplicaCartas(EligeCartasAlea(LeerImagenes(), cuantas)))));
            totalParejas = _juegoActual.GetLength(0) * _juegoActual.GetLength(1) / 2;
            EstableceReverso(reversoCarta);
            MuestraCartasInicio();
        }

        private void InterCambiarCartas(bool activar)
        {
            if(activar)
            {
                temporizador = new DispatcherTimer();
                temporizador.Tick += temporizador_Tick; //suscribimos al evento click
                temporizador.Interval = new TimeSpan(0, 0, 10); // intervalo en que se lanza el evento (horas, minutos, segundos en ese orden).
                cartasQueSeCambian = new bool[_juegoActual.GetLength(0), _juegoActual.GetLength(1)];
            }
        }

        private void temporizador_Tick(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private int obtenerPosicion(Image imagen)
        {
            return Convert.ToInt32(imagen.Tag);
                
        }

        private void MuestraCartasInicio()
        {
            DibujarCartasVolteadas(_juegoActual);
            DelayAction(3000, new Action(() =>
            {
                stackContainer.Children.Clear();
                DibujarCartas(_juegoActual);
            }));
        }

        private void VolteaCarta(Image imagen, int volteadas)
        {

            if(volteadas < 2)
            {
                int fila = Convert.ToInt32(imagen.Tag) / 10;
                int columna = Convert.ToInt32(imagen.Tag) - fila * 10;
                imagen.Source = new BitmapImage(new Uri(_juegoActual[fila, columna], UriKind.RelativeOrAbsolute));
                imagen.MouseUp -= UnaImagen_MouseUp;
            }
        }

        private void CompruebaParejas(Image imgAnterior, Image imgNueva)
        {
            if (imgNueva.Source.ToString() == imgAnterior.Source.ToString())
            {
                _totalVolteadas++;

                if(random)
                {
                    int fila = Convert.ToInt32(imgAnterior.Tag) / 10;
                    int columna = Convert.ToInt32(imgAnterior.Tag) - fila * 10;
                    cartasQueSeCambian[fila, columna] = true;

                    fila = Convert.ToInt32(imgNueva.Tag) / 10;
                    columna = Convert.ToInt32(imgNueva.Tag) - fila * 10;
                    cartasQueSeCambian[fila, columna] = true;
                }
            }
            else
            {
                DelayAction(500, new Action(() =>
                {
                    imgAnterior.Source = _traseraActual.Source;
                    imgNueva.Source = _traseraActual.Source;
                }));
                imgAnterior.MouseUp += UnaImagen_MouseUp;
                imgNueva.MouseUp += UnaImagen_MouseUp;
                intentos++;
            }
            _imgAnterior = null;
            cartasVolteadas = 0;
        }

        private bool FinJuego(int totalParejas, int totalParejasEncontradas)
        {
            return totalParejas == totalParejasEncontradas ? true : false;
        }

        private static string[] LeerImagenes()
        {
            string[] rutas;
            DirectoryInfo carpeta = new DirectoryInfo(@"imagenes/" + Variables.tematicaPath + @"/juego");
            FileInfo[] ficheros = carpeta.GetFiles();
            rutas = new string[ficheros.Length];


            for (int i = 0; i < ficheros.Length; i++)
                rutas[i] = ficheros[i].FullName;

            return rutas;
        }

        private static string[] LeerTraseraImagenes()
        {
            string[] traseraCartas;
            DirectoryInfo carpeta = new DirectoryInfo(@"imagenes/" + Variables.tematicaPath + @"/cartas");
            FileInfo[] ficheros = carpeta.GetFiles();
            traseraCartas = new string[ficheros.Length];


            for (int i = 0; i < ficheros.Length; i++)
                traseraCartas[i] = ficheros[i].FullName;

            return traseraCartas;
        }

        private static string[] EligeCartasAlea(string[] cartas, int cuantas)
        {
            string[] aux = new string[cuantas];
            Random rnd = new Random();

            for (int i = 0; i < cuantas; i++)
                aux[i] = cartas[rnd.Next(cartas.Length)];

            return aux;
        }

        private void DibujarCartasVolteadas(string[,] cartas)
        {
            for (int i = 0; i < cartas.GetLength(0); i++)
            {
                DockPanel unDockPanel = new DockPanel();
                unDockPanel.Height = 125;

                for (int j = 0; j < cartas.GetLength(1); j++)
                {
                    //parseamos la ruta
                    Uri unaRuta = new Uri(cartas[i,j]);
                    BitmapImage unaRutaValida = new BitmapImage(unaRuta);

                    //Se crea la imagen
                    Image unaImagen = new Image();
                    unaImagen.Source = unaRutaValida;
                    unaImagen.Width = 80;
                    unaImagen.Height = 80;

                    //La añadimos al dockpanel
                    unDockPanel.Children.Add(unaImagen);
                }

                //Se añade el dockPanel al contenedor
                stackContainer.Children.Add(unDockPanel);
            }
        }

        private void EstableceReverso(Image image)
        {
            _traseraActual = new Image();
            _traseraActual.Source = image.Source; ;
        }

        private void DibujarCartas(string[,] cartas)
        {
            int contador = -1;
            for (int i = 0; i < cartas.GetLength(0); i++)
            {
                DockPanel unDockPanel = new DockPanel();
                unDockPanel.Height = 125;

                for(int j = 0; j < cartas.GetLength(1); j++)
                {
                    //Se crea la imagen
                    Image unaImagen = new Image();
                    unaImagen.Source = _traseraActual.Source;
                    unaImagen.Width = 80;
                    unaImagen.Height = 80;
                    unaImagen.MouseUp += UnaImagen_MouseUp;

                    //usare el tag para saber que imagen es la que se pulsa en cada momento
                    contador++;
                    unaImagen.Tag = contador;

                    //La añadimos al dockpanel
                    unDockPanel.Children.Add(unaImagen);
                }

                //Se añade el dockPanel al contenedor
                stackContainer.Children.Add(unDockPanel);
            }
        }

        private void UnaImagen_MouseUp(object sender, MouseButtonEventArgs e)
        {
            Image unaImagen = (Image)sender;
            VolteaCarta(unaImagen, cartasVolteadas);
            cartasVolteadas++;
            if (_imgAnterior == null)
            {
                _imgAnterior = new Image();
                _imgAnterior = unaImagen;
            }
            else
                CompruebaParejas(_imgAnterior, unaImagen);
            if (FinJuego(totalParejas,_totalVolteadas))
                MessageBox.Show(string.Format("Has ganado.\nTotal parejas: {0}\nParejas falladas: {1}", totalParejas, intentos));
        }

        private static string[] DuplicaCartas(string[] cartasSolitarias)
        {
            string[] duplicado = new string[cartasSolitarias.Length * 2];
            cartasSolitarias.CopyTo(duplicado, 0);
            cartasSolitarias.CopyTo(duplicado, cartasSolitarias.Length);

            return duplicado;

            
        }

        private static string[,] GeneraTablero(string[] cartas)
        {
            int contador = 0;

            int imagenesPorLinea = 10;
            int totalComumnas = cartas.Length / 10;

            string[,] tablero = new string[totalComumnas, imagenesPorLinea];

            for(int i = 0; i < totalComumnas; i++)
                for(int j = 0; j < imagenesPorLinea; j++)
                {
                    tablero[i, j] = cartas[contador++];
                }

            return tablero;
        }

        private static void IntercambiaCartas()
        {
            Random rnd = new Random();
            List<string> cartasACambiar = new List<string>();
            for(int i = 0; i < cartasQueSeCambian.GetLength(0); i++)
            {
                for(int j = 0; j < cartasQueSeCambian.GetLength(1); j++)
                {
                    if(!cartasQueSeCambian[i, j])
                    {
                        cartasACambiar.Add(_juegoActual[i, j]);
                    }
                }
            }



        }

        private static string[] MezclaCartasBaraja(string[] cartas)
        {
            int vueltas = 10000;
            int a, b;
            string c;

            Random rnd = new Random();
            for(int i = 0; i < vueltas; i++)
            {
                a = rnd.Next(0, cartas.Length);
                b = rnd.Next(0, cartas.Length);

                c = cartas[a];
                cartas[a] = cartas[b];
                cartas[b] = c;
            }

            return cartas;
        }

        private void Window_Closed(object sender, EventArgs e)
        {
            App.Current.MainWindow.Show();
        }

        private void DelayAction(int millisecond, Action action)
        {
            var timer = new DispatcherTimer();
            timer.Tick += delegate
            {
                action.Invoke();
                timer.Stop();
            };

            timer.Interval = TimeSpan.FromMilliseconds(millisecond);
            timer.Start();
        }

        private void ven_interfaz_Loaded(object sender, RoutedEventArgs e)
        {
            if(Variables.totalCartas == 50)
                random = true;
        }
    }
}
