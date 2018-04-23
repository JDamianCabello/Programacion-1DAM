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
using io = System.IO;

namespace JuegoParejaDeCartas
{
    /// <summary>
    /// Lógica de interacción para Juego.xaml
    /// </summary>
    public partial class Juego : Window
    {
        public Juego(sbyte cuantas)
        {
            InitializeComponent();
            DibujarCartas(GeneraTablero((DuplicaCartas(SeleccionaCartas(cuantas)))));

        }

        string[,] a = new string[5, 4] 
        {
            {@"imagenesGeneralJuego/250.png", @"imagenesGeneralJuego/249.png", @"imagenesGeneralJuego/149.png", @"imagenesGeneralJuego/150.png"},
            {@"imagenesGeneralJuego/50.png", @"imagenesGeneralJuego/9.png", @"imagenesGeneralJuego/148.png", @"imagenesGeneralJuego/150.png"},
            {@"imagenesGeneralJuego/50.png", @"imagenesGeneralJuego/10.png", @"imagenesGeneralJuego/333.png", @"imagenesGeneralJuego/236.png"},
            {@"imagenesGeneralJuego/50.png", @"imagenesGeneralJuego/324.png", @"imagenesGeneralJuego/23.png", @"imagenesGeneralJuego/150.png"},
            {@"imagenesGeneralJuego/1.png", @"imagenesGeneralJuego/10.png", @"imagenesGeneralJuego/23.png", @"imagenesGeneralJuego/150.png"}

        };
        
        private void Window_Closed(object sender, EventArgs e)
        {
            App.Current.MainWindow.Show();
        }

        private void DibujarCartas(string[,] cartas)
        {
            for(int i = 0; i < cartas.GetLength(0); i++)
            {
                DockPanel unDockPanel = new DockPanel();
                unDockPanel.Height = 100;

                for(int j = 0; j < cartas.GetLength(1); j++)
                {
                    //parseamos la ruta
                    Uri unaRuta = new Uri(cartas[i, j], UriKind.RelativeOrAbsolute);
                    BitmapImage unaRutaValida = new BitmapImage(unaRuta);

                    //Se crea la imagen
                    Image unaImagen = new Image();
                    unaImagen.Source = unaRutaValida;

                    //La añadimos al dockpanel
                    unDockPanel.Children.Add(unaImagen);
                }

                //Se añade el dockPanel al contenedor
                stackContainer.Children.Add(unDockPanel);
            }
        }

        private string[] DuplicaCartas(string[] cartasSolitarias)
        {
            string[] duplicado = new string[cartasSolitarias.Length * 2];
            cartasSolitarias.CopyTo(duplicado, 0);
            cartasSolitarias.CopyTo(duplicado, cartasSolitarias.Length);

            return duplicado;

            
        }

        private string[,] GeneraTablero(string[] cartas)
        {
            int imagenesPorLinea = 11;
            int contador = 0;
            
            do
            {
                imagenesPorLinea --;
            } while(cartas.Length % imagenesPorLinea != 0);

            int totalComumnas = cartas.Length / imagenesPorLinea;

            string[,] tablero = new string[imagenesPorLinea, totalComumnas];

            for(int i = 0; i < totalComumnas; i++)
                for(int j = 0; j < imagenesPorLinea; j++)
                {
                    tablero[i, j] = cartas[contador++];
                }

            return tablero;
        }

        private string[] MezclaCartasBaraja(string[] cartas)
        {
            int vueltas = 5000;
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

        private string[] SeleccionaCartas(int cuantas)
        {
            string[] cartas = new string[cuantas];
            List<string> todasCartas = new List<string>();
            foreach(string name in Assembly.GetExecutingAssembly().GetManifestResourceNames())
            {
                if(name.EndsWith("<name>", StringComparison.InvariantCultureIgnoreCase))
                {
                    using(io.Stream stream = Assembly.GetExecutingAssembly().GetManifestResourceStream(name))
                    {
                       todasCartas = stream.
                    }
                    break;
                }
            }


            return cartas;
 
        }

    }
}
