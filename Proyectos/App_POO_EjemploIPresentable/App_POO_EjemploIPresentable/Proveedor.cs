using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_EjemploIPresentable
{
    class Proveedor : IPresentable
    {
        string _nombre;
        string _apellidos;
        int _numProveedor;

        public Proveedor(string n, string a, int nP)
        {
            _nombre = n;
            _apellidos = a;
            _numProveedor = nP;
        }

        public void Presentar()
        {
            Console.WriteLine("Nombre:".PadLeft(15) + " {0}", _nombre);
            Console.WriteLine("Apellidos:".PadLeft(15) + " {0}", _apellidos);
            Console.WriteLine("Num. Proveedor:".PadLeft(15) + " {0}", _numProveedor);
        }
    }
}
