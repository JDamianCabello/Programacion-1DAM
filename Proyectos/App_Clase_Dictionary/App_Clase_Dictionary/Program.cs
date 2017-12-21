using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_Dictionary
{
    struct Carta
    {
        int valor;
        string nombre;
        double peso;
        string palo;

        public Carta(int valor, string nombre, double peso, string palo)
        {
            this.nombre = nombre;
            this.peso = peso;
            this.valor = valor;
            this.palo = palo;
        }

        public string GetClave()
        {
            return valor.ToString() + palo;
        }

        public override string ToString()
        {
            return valor.ToString() + " ; " + nombre + "; " + peso + "; " + palo;
        }
    }

    class Program
    {
        static Dictionary<string, Carta> Baraja = new Dictionary<string, Carta>();

        static void Main(string[] args)
        {
            Carta c1 = new Carta(1, "Uno", 1, "Oro");
            string clave = c1.GetClave();
            Baraja.Add(clave, c1);
            Carta c2 = new Carta(10, "Sota", 0.5, "Copa");
            clave = c2.GetClave();
            Baraja.Add(clave, c2);

            try
            {
                Baraja.Add(clave, c2); //Lanza excepción.
            }
            catch
            {
                //Aquí el control de excepciones.
            }

            
            Console.WriteLine("Hay {0} cartas.",Baraja.Count);


            Console.ReadKey();
        }


    }
}
