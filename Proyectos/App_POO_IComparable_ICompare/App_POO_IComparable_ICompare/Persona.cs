using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian.App_POO_IComparable_ICompare
{
    public class Persona : IComparable<Persona> //Le pongo el tipo Persona para no tener que hacer casting
    {
        #region Campos

        string nombre;
        string apellidos;
        int codigo;

        #endregion

        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellidos
        {
            get { return apellidos; }
            set { apellidos = value; }
        }

        public int Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        #endregion

        #region Constructor

        public Persona(string a, string n, int c)
        {
            Nombre = n;
            Apellidos = a;
            Codigo = c;
        }

        #endregion

        #region Métodos

        public override string ToString()
        {
            return string.Format("{0}\t{1}\t{2}", Codigo, Nombre, Apellidos);
        }

        #endregion

        #region Implementación de Interfaz
        //Si x es mayor que y devuelve 1, si son iguales devuelve 0
        public int CompareTo(Persona other)
        {
            //Con esto ordena por código
            /*
            if (this.Codigo > other.Codigo) return 1;
            if (this.Codigo < other.Codigo) return -1;
            return 0; //Si son iguales
             * */

            //Con esto ordena por apellido
            return string.Compare(this.Apellidos, other.Apellidos);
        }
        #endregion

        #region Clases para ordenar por varios criterios

        public class OrdenarNombre : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return string.Compare(x.Nombre, y.Nombre);
            }
        }
        /// <summary>
        /// Ordema por el apellido de una persona
        /// </summary>
        public class OrdenarApellidos : IComparer<Persona>
        {
            public int Compare(Persona x, Persona y)
            {
                return string.Compare(x.Apellidos, y.Apellidos);
            }
        }

        #endregion
    }
}
