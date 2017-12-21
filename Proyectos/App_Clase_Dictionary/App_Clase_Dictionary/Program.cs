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
            return valor.ToString().PadRight(2) + " ; " + nombre.PadRight(4) + " ; " + peso.ToString().PadRight(3) + " ; " + palo.PadRight(6);
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

            VerDiccionario(Baraja);

            //Mostrar una carta
            Carta valor = new Carta();
            if(Baraja.TryGetValue("1Oro", out valor)) //Con TryGetValue obtenemos un bool si está o no y además guardamos en value su contenido.
                Console.WriteLine(valor);


            //Comprobar si existe una clave
            if(Baraja.ContainsKey("1Oro"))
                Console.WriteLine("La clave 1Oro existe.");


            var claves = Baraja.Keys;
            var valores = Baraja.Values;

            //Mostrar claves
            Console.WriteLine(" CLAVES ");
            Console.WriteLine("".PadLeft(40, '='));
            foreach(string tmp in claves)
                Console.WriteLine(tmp);


            //Mostrar claves
            Console.WriteLine("\n\n\n VALORES ");
            Console.WriteLine("".PadLeft(40, '='));
            foreach(Carta tmp in valores)
                Console.WriteLine(tmp);


            //Borrar dato
            BorrarEnDiccionario("1Oro", Baraja);
            BorrarEnDiccionario("1Oro", Baraja);
            Console.ReadKey();
        }

        static void VerDiccionario(Dictionary<string, Carta> dic)
        {
            Console.WriteLine("\n\n\n DATOS DEL DICCIONARIO ");
            Console.WriteLine("".PadLeft(40,'='));

            Console.WriteLine("[{0}]: {1}", "Clave".PadRight(6), "Valor");
            Console.WriteLine("".PadLeft(40,'-'));
            foreach(KeyValuePair<string, Carta> tmp in dic)
                Console.WriteLine("[{0,6}]: {1}",tmp.Key, tmp.Value.ToString());
        }

        static void BorrarEnDiccionario(string key, Dictionary<string, Carta> dic)
        {
            if(dic.Remove(key))
                Console.WriteLine("La entrada {0} se eliminó.", key);
            else
                Console.WriteLine("La entrada {0} no existe. No se eliminó nada.", key);
        }

    }
}
