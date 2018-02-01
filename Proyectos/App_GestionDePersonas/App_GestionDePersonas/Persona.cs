using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_GestionDePersonas
{
    public class Persona
    {
        #region Campos

        private int _id;
        private string _nombre;
        private string _apellidos;
        private DateTime _FechaNacimiento;
        private double _estatura;

        #endregion

        #region Propiedades

        public int Id
        {
            get { return _id; }
            set { _id = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _FechaNacimiento; }
            set { _FechaNacimiento = value; }
        }

        public double Estatura
        {
            get { return _estatura; }
            set { _estatura = value; }
        }

        #endregion

        #region Constructores

        /// <summary>
        /// Persona predeterminada cuando usamos el constructor vacío
        /// </summary>
        public Persona()
        {
            Nombre = "IES";
            Apellidos = "Portada Alta";
            FechaNacimiento = DateTime.Parse("01/01/2000");
            Estatura = 0.0;
        }

        /// <summary>
        /// Persona creada con datos del usuario
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellidos"></param>
        /// <param name="fNac"></param>
        /// <param name="estatura"></param>
        public Persona(string nombre, string apellidos, DateTime fNac, double estatura)
        {
            Nombre = nombre;
            Apellidos = apellidos;
            FechaNacimiento = fNac;
            Estatura = estatura;
        }

        #endregion

        #region Métodos

        /// <summary>
        /// Escribe la tabla
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return "|" + Id.ToString().PadLeft(6, ' ') + " | " +
                    Apellidos.PadRight(30) + " | " + Nombre.PadRight(15) + " | " +
                    FechaNacimiento.ToShortDateString() + " | ";
        }

        #endregion
    }
}
