using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javier.App_GestionDePersonas
{

    public delegate void DlgAddPersona(DateTime ahora);

    public class ListaDePersonas
    {
        public event DlgAddPersona EntradaOK;

        List<Persona> _personas = null;
        int _id = 100;

        #region Propiedades

        public int Cuantos
        {
            get { return _personas.Count; }
        }

        #endregion

        #region Constructores
        /// <summary>
        /// Crea una lista de personas
        /// </summary>
        public ListaDePersonas()
        {
            _personas = new List<Persona>();
        }

        #endregion

        #region Métodos
        /// <summary>
        /// Añade una persona ya creada a la lista
        /// </summary>
        /// <param name="p">persona ya creada</param>
        /// <returns></returns>
        public bool Anadir(Persona p)
        {
            p.Id = _id++;
            _personas.Add(p);
            if (EntradaOK != null)
                EntradaOK(DateTime.Now);
            return true;
        }

        /// <summary>
        /// Añade una persona aleatoria
        /// </summary>
        /// <returns></returns>
        public bool AnadirPersonaAleatoria()
        {
          Persona p = ObtenerPersonaAleatoria.Crear();
          p.Id = _id++;
          _personas.Add(p);
          return true;
        }

        /// <summary>
        /// Añade un número determinado de personas aleatorias
        /// </summary>
        /// <param name="nPersonas">Número de personas a añadir</param>
        /// <returns></returns>
        public bool AnadirPersonasAleatoria(int nPersonas)
        {
          for (int i = 0; i < nPersonas; i++)
          {
              Persona p = ObtenerPersonaAleatoria.Crear();
              p.Id = _id++;
              _personas.Add(p);
              if (EntradaOK != null)
                  EntradaOK(DateTime.Now);
              
          }
          return true;
        }

        /// <summary>
        /// Muestra la lista de las personas añadidas
        /// </summary>
        public void ListarPersonas()
        {
            int anchoListado = 74;

            Console.WriteLine("L I S T A D O    D E   P E R S O N A S");
            Console.WriteLine("=".PadRight(anchoListado, '='));
            foreach (Persona tmp in _personas)
                Console.WriteLine(tmp.ToString());
            Console.WriteLine("=".PadRight(anchoListado, '='));
            Console.WriteLine("No hay más personas a listar...");

            Console.ReadLine();
        }

        /// <summary>
        /// Escribe el título centrado encima de la tabla
        /// </summary>
        /// <param name="mensaje"></param>
        public void Listar(string mensaje)
        {
            int anchoListado = 74;
            Console.CursorLeft = (anchoListado / 2) - (mensaje.Length / 2);

            Console.WriteLine(mensaje);
            Console.WriteLine("=".PadRight(anchoListado, '='));
            foreach (Persona tmp in _personas)
                Console.WriteLine(tmp.ToString());
            Console.WriteLine("=".PadRight(anchoListado, '='));
            Console.WriteLine("No hay más personas a listar...");

            Console.ReadLine();
        }

        /// <summary>
        /// Método que sobrecarga el operador más para que añada una persona a la clase Lista personas llamando al método Anadir.
        /// </summary>
        /// <param name="personas">La lista a la que añadimos la persona</param>
        /// <param name="P">La persona a añadir</param>
        /// <returns>Resultado de la insercción</returns>
        public static bool operator +(ListaDePersonas personas, Persona P)
        {
            return personas.Anadir(P);
        }

        /// <summary>
        /// Dota a la clase lista persona de un indizador de tipo int
        /// </summary>
        /// <param name="indice">La posición del indice a buscar</param>
        /// <returns></returns>
        public Persona this[int indice]
        {
            get { return _personas[indice]; }
            set { _personas[indice] = value; }
        }

        #endregion
    }
}
