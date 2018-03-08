using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SerializaPersona
{
    [Serializable]
    class Persona
    {
        string _apellidos;
        bool _borrado;
        string _nombre;
        float _sueldo;

        public Persona(string a, string n, float s)
        {
            _apellidos = a;
            _nombre = n;
            _sueldo = s;
            _borrado = false;
        }

        public string Apellidos
        {
            get { return _apellidos; }
            set { _apellidos = value; }
        }

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }

        public float Sueldo
        {
            get { return _sueldo; }
            set { _sueldo = value; }
        }

        public bool Borrado
        {
            get { return _borrado; }
            set { _borrado = value; }
        }

        public override string ToString()
        {
            return _apellidos.PadRight(30) + _nombre.PadRight(20) + _sueldo.ToString().PadRight(9);
        }
    }
}
