using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MioMenu
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 0;
            string[] menu = { "opcion 1", "opcion 2", "opcion 3", "opcion 4", "salir" };
            opcion = CreaUnMenu.BucleMenuConfirmandoSalida(ConsoleKey.Backspace, menu, 1, ConsoleColor.Green, TipoMenu.doble,'/', "Esto es un ejemplo de menú");

            switch (opcion)
            {
                case 0:
                    Console.WriteLine("Esto es la opción 1");
                    break;
                case 1:
                    Console.WriteLine("Esto es la opción 2");
                    break;
                case 2:
                    Console.WriteLine("Esto es la opción 3");
                    break;
                case 3:
                    Console.WriteLine("Esto es la opción 4");
                    break;
                case 4:
                    Console.WriteLine("Esto es la salida");
                    break;
                default:
                    break;
            }
            Console.ReadLine();

        }


    }

    public enum TipoMenu { simple, doble, basico, recuadroDoble, cruz };

    class TituloMenu
    {

        /// <summary>
        /// Crea un menú de tipo básico, con caracter '-' y escribiendo MENU PRINCIPAL en la cabecera.
        /// </summary>
        public static void TituloRapido()
        {
            EscribeTitulo(TipoMenu.basico, '-', "MENU PRINCIPAL");
        }

        /// <summary>
        /// Crea un menu con un borde predefinido dado un tipo y un título.
        /// Ejemplo de tipo:
        /// 
        /// TipoMenu.simple: 
        /// 
        ///     STRING TITULO
        ///     1.
        ///     2.
        ///     etc.
        ///     
        /// TipoMenu.recuadroDoble: 
        /// 
        ///     ╔===============╗
        ///     ║ STRING TITULO ║
        ///     ╚===============╝
        ///     1.
        ///     2.
        ///     etc.
        ///     
        /// TipoMenu.cruz: 
        /// 
        ///     +---------------+
        ///     | STRING TITULO |
        ///     +---------------+
        ///     1.
        ///     2.
        ///     etc.
        ///     
        /// </summary>
        /// <param name="tipo">TipoMenu.simple, TipoMenu.recuadroDoble o TipoMenu.cruz</param>
        /// <param name="titulo">Frase que aparece en el encabezado del menú</param>
        public static void TituloPredefinido(TipoMenu tipo, string titulo)
        {
            EscribeTitulo(tipo, titulo);
        }

        /// <summary>
        /// Crea un menu basico o doble dado un tipo, un caracter para simular la línea y un string de encabezado.
        /// Ejemplo de tipo:
        /// 
        /// TipoMenu.basico: (dado = como caracter)
        /// 
        ///     STRING TITULO
        ///     ====================
        ///     1.
        ///     2.
        ///     etc.
        ///     
        /// TipoMenu.doble: (dado = como caracter)
        /// 
        ///     ====================
        ///     STRING TITULO
        ///     ====================
        ///     1.
        ///     2.
        ///     etc.
        ///     
        /// </summary>
        /// <param name="tipo">TipoMenu.basico o TipoMenu.doble</param>
        /// <param name="barra">caracter para simular la línea</param>
        /// <param name="titulo">Frase que aparece en el encabezado del menú</param>
        public static void MenuSimpleDadoCaracter(TipoMenu tipo, char caracterBarra, string titulo)
        {
            EscribeTitulo(tipo, caracterBarra, titulo);
        }


        private static void EscribeTitulo(TipoMenu tipo, char barra, string titulo)
        {
            string auxiliar = string.Empty;
            switch (tipo)
            {
                case TipoMenu.basico:
                    auxiliar = auxiliar.PadRight(20, barra);
                    Console.WriteLine(titulo);
                    Console.WriteLine(auxiliar);
                    break;
                case TipoMenu.doble:
                    auxiliar = auxiliar.PadRight(20, barra);
                    Console.WriteLine(auxiliar);
                    Console.WriteLine(titulo);
                    Console.WriteLine(auxiliar);
                    break;
            }
        }

        private static void EscribeTitulo(TipoMenu tipo, string titulo)
        {
            string auxiliar = string.Empty;
            switch (tipo)
            {
                case TipoMenu.simple:
                    Console.WriteLine(titulo);
                    break;
                case TipoMenu.recuadroDoble:
                    auxiliar = auxiliar.PadRight(titulo.Length + 2, '═');
                    Console.WriteLine("╔{0}╗", auxiliar);
                    Console.WriteLine("║ {0} ║", titulo);
                    Console.WriteLine("╚{0}╝", auxiliar);
                    break;
                case TipoMenu.cruz:
                    auxiliar = auxiliar.PadRight(titulo.Length + 2, '-');
                    Console.WriteLine("+{0}+", auxiliar);
                    Console.WriteLine("| {0} |", titulo);
                    Console.WriteLine("+{0}+", auxiliar);
                    break;
            }
        }
    }

    class ContenidoMenu
    {

        public static void PintaContenido(string[] opciones, int opcionMarcada, ConsoleColor color)
        {
            for (int i = 0; i < opciones.Length; i++)
                if (Convert.ToInt32(opcionMarcada) == i+1)
                {
                    Console.ForegroundColor = color;
                    Console.WriteLine("{0,2}. {1}", i+1, opciones[i]);
                    Console.ResetColor();
                }
                else
                    Console.WriteLine("{0,2}. {1}", i+1, opciones[i]);
        }
    }

    public class CreaUnMenu
    {
        /// <summary>
        /// Crea el menú y añade un bucle para que no se salga.
        /// </summary>
        /// <param name="salida">Tecla con la que se sale del menú de la aplicación</param>
        /// <param name="opcionesMenu">Array de strings que contiene el contenido del menú</param>
        /// <param name="posicionMarcada">La posición que deseemos que esté marcada (por defecto 1).</param>
        /// <param name="color">Color del que estará resaltado el menú.</param>
        public static int BucleSinConfirmarSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color)
        {
            return HazMenuSinConfirmarSalida(salida, opcionesMenu, posicionMarcada, color);
        }

        /// <summary>
        /// Crea el menú y añade un bucle para que no se salga.
        /// </summary>
        /// <param name="salida">Tecla con la que se sale del menú de la aplicación</param>
        /// <param name="opcionesMenu">Array de strings que contiene el contenido del menú</param>
        /// <param name="posicionMarcada">La posición que deseemos que esté marcada (por defecto 1).</param>
        /// <param name="color">Color del que estará resaltado el menú.</param>
        /// <param name="tipo">El tipo de menú a mostrar.</param>
        /// <param name="frase">La frase del encabezado</param>
        /// <returns></returns>
        public static int BucleSinConfirmarSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color, TipoMenu tipo, string frase)
        {
            return HazMenuSinConfirmarSalida(salida, opcionesMenu, posicionMarcada, color, tipo, frase);
        }

        /// <summary>
        /// Crea el menú y añade un bucle para que no se salga.
        /// </summary>
        /// <param name="salida">Tecla con la que se sale del menú de la aplicación</param>
        /// <param name="opcionesMenu">Array de strings que contiene el contenido del menú</param>
        /// <param name="posicionMarcada">La posición que deseemos que esté marcada (por defecto 1).</param>
        /// <param name="color">Color del que estará resaltado el menú.</param>
        /// <param name="tipo">El tipo de menú a mostrar.</param>
        /// <param name="caracterLineaMenu">El caracter que simula una barra en el CMD</param>
        /// <param name="frase">La frase del encabezado</param>
        /// <returns></returns>
        public static int BucleSinConfirmarSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color, TipoMenu tipo, char caracterLineaMenu, string frase)
        {
            return HazMenuSinConfirmarSalida(salida, opcionesMenu, posicionMarcada, color, tipo, caracterLineaMenu, frase);
        }

        /// <summary>
        /// Crea el menú, lo añade a un bucle y cuando se va a salir de él pregunta si realmente se quiere abandonar pudiendo pulsar 'Y' (Yes) para salir o otra tecla para volver al menú.
        /// </summary>
        /// <param name="salida">Tecla con la que se sale del menú de la aplicación</param>
        /// <param name="opcionesMenu">Array de strings que contiene el contenido del menú</param>
        /// <param name="posicionMarcada">La posición que deseemos que esté marcada (por defecto 1).</param>
        /// <param name="color">Color del que estará resaltado el menú.</param>
        public static int BucleMenuConfirmandoSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color)
        {
            return HazMenuConfirmandoLaSalida(salida, opcionesMenu, posicionMarcada, color);
        }

        /// <summary>
        /// Crea el menú, lo añade a un bucle y cuando se va a salir de él pregunta si realmente se quiere abandonar pudiendo pulsar 'Y' (Yes) para salir o otra tecla para volver al menú.
        /// </summary>
        /// <param name="salida">Tecla con la que se sale del menú de la aplicación</param>
        /// <param name="opcionesMenu">Array de strings que contiene el contenido del menú</param>
        /// <param name="posicionMarcada">La posición que deseemos que esté marcada (por defecto 1).</param>
        /// <param name="color">Color del que estará resaltado el menú.</param>
        /// <param name="tipo">El tipo de menú a mostrar.</param>
        /// <param name="frase">La frase del encabezado</param>
        /// <returns></returns>
        public static int BucleMenuConfirmandoSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color, TipoMenu tipo, string frase)
        {
            return HazMenuConfirmandoLaSalida(salida, opcionesMenu, posicionMarcada, color, tipo, frase);
        }

        /// <summary>
        /// Crea el menú, lo añade a un bucle y cuando se va a salir de él pregunta si realmente se quiere abandonar pudiendo pulsar 'Y' (Yes) para salir o otra tecla para volver al menú.
        /// </summary>
        /// <param name="salida">Tecla con la que se sale del menú de la aplicación</param>
        /// <param name="opcionesMenu">Array de strings que contiene el contenido del menú</param>
        /// <param name="posicionMarcada">La posición que deseemos que esté marcada (por defecto 1).</param>
        /// <param name="color">Color del que estará resaltado el menú.</param>
        /// <param name="tipo">El tipo de menú a mostrar.</param>
        /// <param name="caracterLineaMenu">El caracter que simula una barra en el CMD</param>
        /// <param name="frase">La frase del encabezado</param>
        /// <returns></returns>
        public static int BucleMenuConfirmandoSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color, TipoMenu tipo, char caracterLineaMenu, string frase)
        {
            return HazMenuConfirmandoLaSalida(salida, opcionesMenu, posicionMarcada, color, tipo, caracterLineaMenu, frase);
        }


        private static int HazMenuSinConfirmarSalida(ConsoleKey salida, string[] opciones, int posicionMarcada, ConsoleColor color)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                Console.CursorVisible = false;
                UIMenu.Pinta(opciones, posicionMarcada, color);
                tecla = Console.ReadKey();
                posicionMarcada += CambiaOpcionMarcada.ControlMarcado(tecla.Key,opciones.Length, posicionMarcada);
                if (tecla.Key == ConsoleKey.Enter)
                    return posicionMarcada - 1;
            } while (tecla.Key != salida);
            return 0;
        }

        private static int HazMenuSinConfirmarSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color, TipoMenu tipo, string frase)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                Console.CursorVisible = false;
                UIMenu.Pinta(opcionesMenu, posicionMarcada, color,tipo,frase);
                tecla = Console.ReadKey();
                posicionMarcada += CambiaOpcionMarcada.ControlMarcado(tecla.Key, opcionesMenu.Length, posicionMarcada);
                if (tecla.Key == ConsoleKey.Enter)
                    return posicionMarcada - 1;
            } while (tecla.Key != salida);
            return 0;
        }

        private static int HazMenuSinConfirmarSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color, TipoMenu tipo, char caracterLineaMenu, string frase)
        {
            ConsoleKeyInfo tecla;
            do
            {
                Console.Clear();
                Console.CursorVisible = false;
                UIMenu.Pinta(opcionesMenu, posicionMarcada, color, tipo, caracterLineaMenu, frase);
                tecla = Console.ReadKey();
                posicionMarcada += CambiaOpcionMarcada.ControlMarcado(tecla.Key, opcionesMenu.Length, posicionMarcada);
                if (tecla.Key == ConsoleKey.Enter)
                    return posicionMarcada - 1;
            } while (tecla.Key != salida);
            return 0;
        }

        private static int HazMenuConfirmandoLaSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color)
        {
            ConsoleKeyInfo tecla;
            do
            {
                do
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    UIMenu.Pinta(opcionesMenu, posicionMarcada, color);
                    tecla = Console.ReadKey(true);
                    posicionMarcada += CambiaOpcionMarcada.ControlMarcado(tecla.Key, opcionesMenu.Length, posicionMarcada);
                    if (tecla.Key == ConsoleKey.Enter)
                        return posicionMarcada - 1;
                } while (tecla.Key != salida);
                Console.WriteLine("Seguro que quiere salir del programa? Y/n");
                tecla = Console.ReadKey(true);
            } while (tecla.Key != ConsoleKey.Y);
            return 0;
        }

        private static int HazMenuConfirmandoLaSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color,TipoMenu tipo, string frase)
        {
            ConsoleKeyInfo tecla;
            do
            {
                do
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    UIMenu.Pinta(opcionesMenu, posicionMarcada, color,tipo,frase);
                    tecla = Console.ReadKey(true);
                    posicionMarcada += CambiaOpcionMarcada.ControlMarcado(tecla.Key, opcionesMenu.Length, posicionMarcada);
                    if (tecla.Key == ConsoleKey.Enter)
                        return posicionMarcada - 1;
                } while (tecla.Key != salida);
                Console.WriteLine("Seguro que quiere salir del programa? Y/n");
                tecla = Console.ReadKey(true);
            } while (tecla.Key != ConsoleKey.Y);
            return 0;
        }

        private static int HazMenuConfirmandoLaSalida(ConsoleKey salida, string[] opcionesMenu, int posicionMarcada, ConsoleColor color, TipoMenu tipo, char caracterLineaMenu, string frase)
        {
            ConsoleKeyInfo tecla;
            do
            {
                do
                {
                    Console.Clear();
                    Console.CursorVisible = false;
                    UIMenu.Pinta(opcionesMenu, posicionMarcada, color, tipo, caracterLineaMenu, frase);
                    tecla = Console.ReadKey(true);
                    posicionMarcada += CambiaOpcionMarcada.ControlMarcado(tecla.Key, opcionesMenu.Length, posicionMarcada);
                    if (tecla.Key == ConsoleKey.Enter)
                        return posicionMarcada - 1;
                } while (tecla.Key != salida);
                Console.WriteLine("Seguro que quiere salir del programa? Y/n");
                tecla = Console.ReadKey(true);
            } while (tecla.Key != ConsoleKey.Y);
            return 0;
        }
    }

    class CambiaOpcionMarcada
    {

        /// <summary>
        /// Selecciona obtiene y modifica la opción marcada en el menú, tambien controla que esté dentro de los rangos permitidos (mínimo-máximo).
        /// Si se pulsa enter elige esa opcion y continua fuera del menú.
        /// </summary>
        /// <param name="tecla">Flechas de desplazamientro arriba, abajo y Enter.</param>
        /// <param name="totalOpciones">El total de elementos que se muestran en el menú.</param>
        /// <param name="opcionMarcada">La opción marcada en el menú.</param>
        /// <returns></returns>
        public static int ControlMarcado(ConsoleKey tecla, int totalOpciones, int opcionMarcada)
        {
            if (tecla == ConsoleKey.UpArrow)
                if (opcionMarcada == 1)
                    return  0;
                else
                    return-1;
            if (tecla == ConsoleKey.DownArrow)
                if (opcionMarcada == totalOpciones)
                    opcionMarcada = totalOpciones;
                else
                    return 1;
            return 0;
        }

        
    }

    [Serializable]
    class ValorCeroONegativoException: Exception
    {
        public ValorCeroONegativoException() : base()
        { }

        public ValorCeroONegativoException(string mensaje)
        { }
    }

    class UIMenu
    {

        /// <summary>
        /// Pinta una cabecera de un menú.
        /// </summary>
        /// <param name="opciones">El array de strings con la lista de submenús. </param>
        /// <param name="opcionMarcada">Opción que queremos que este resaltada.</param>
        /// <param name="color">Color del que va a estar la opcion resaltada.</param>
        public static void Pinta(string[] opciones, int opcionMarcada, ConsoleColor color)
        {
            if (opcionMarcada <= 0)
                throw new ValorCeroONegativoException();
            TituloMenu.TituloRapido();
            ContenidoMenu.PintaContenido(opciones, opcionMarcada, color);
        }

        /// <summary>
        /// Pinta una cabecera de un menú.
        /// </summary>
        /// <param name="opciones">El array de strings con la lista de submenús. </param>
        /// <param name="opcionMarcada">Opción que queremos que este resaltada.</param>
        /// <param name="color">Color del que va a estar la opcion resaltada.</param>
        /// <param name="tipo">El tipo de cabecera que queremos.</param>
        /// <param name="tituloMenu">El nombre de la cabecera del menú</param>
        public static void Pinta(string[] opciones, int opcionMarcada, ConsoleColor color,TipoMenu tipo, string tituloMenu)
        {
            if (opcionMarcada <= 0)
                throw new ValorCeroONegativoException();
            TituloMenu.TituloPredefinido(tipo, tituloMenu);
            ContenidoMenu.PintaContenido(opciones, opcionMarcada, color);
        }

        /// <summary>
        /// Pinta una cabecera de un menú.
        /// </summary>
        /// <param name="opciones">El array de strings con la lista de submenús. </param>
        /// <param name="opcionMarcada">Opción que queremos que este resaltada.</param>
        /// <param name="color">Color del que va a estar la opcion resaltada.</param>
        /// <param name="tipo">El tipo de cabecera que queremos.</param>
        /// <param name="caracterLineaMenu">Caracter que simula una línea</param>
        /// <param name="tituloMenu">El nombre de la cabecera del menú</param>
        public static void Pinta(string[] opciones, int opcionMarcada, ConsoleColor color,TipoMenu tipo, char caracterLineaMenu, string tituloMenu)
        {
            if (opcionMarcada <= 0)
                throw new ValorCeroONegativoException();
            TituloMenu.MenuSimpleDadoCaracter(tipo,caracterLineaMenu,tituloMenu);
            ContenidoMenu.PintaContenido(opciones, opcionMarcada, color);
        }
    }
}

