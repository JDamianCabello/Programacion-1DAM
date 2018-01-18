using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Delegados
{
    class Program
    {
        //Declaro el tipo de dato delegado llamado "MiDelegado"
        public delegate void MiDelegado(string msj);

        static void Main(string[] args)
        {
            //Creo una instancia de tipo delegado "MiDelegado"
            MiDelegado llamada = MetodoQueUsaElDelegado;

            llamada("Hola soy el método a través de un delegado!.");
            MetodoConDevolucion("La vivlia premoh", llamada);
            Console.ReadLine();
        }

        static void MetodoQueUsaElDelegado(string mensaje)
        {
            Console.WriteLine(mensaje);
        }

        //Creamos un método que recibe como parámetro otro método.
        static void MetodoConDevolucion(string texto, MiDelegado delegado)
        {
        }
    }
}
