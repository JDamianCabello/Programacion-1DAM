using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Javier.App_GestionDePersonas
{
    public class Principal
    {
        static void Main(string[] args)
        {
            ListaDePersonas Bomberos = new ListaDePersonas();
            Bomberos.EntradaOK += Bomberos_EntradaOK;
            Bomberos.AnadirPersonaAleatoria();
            Bomberos.AnadirPersonasAleatoria(150);
            //Bomberos.ListarPersonas();
            Bomberos.Listar("LISTADO DE BOMBEROS DE MÁLAGA");

            Console.WriteLine("Hay {0} Personas", Bomberos.Cuantos);


            Console.WriteLine("BOMBEROS SACADOS CON INDIZADORES DE CLASES:");
            Console.WriteLine("---------------------------------------------");

            for(int i = 10; i < 20; i++)
                Console.WriteLine(Bomberos[i].ToString());


            Console.ReadLine();
        }

        static void Bomberos_EntradaOK(DateTime ahora)
        {
            Console.WriteLine("Se ha añadido una persona a las {0}", ahora.ToShortTimeString());
        }
    }
}
