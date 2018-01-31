using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_SobrecargaDeOperadores
{
    class Program
    {
        static void Main(string[] args)
        {
            Agenda AgendaSecreta = new Agenda();
            bool seAnadio = false;


            /*
             * if(AgendaSecreta + "Añado el primer contacto")
             *      Console.WriteLine("Contacto añadico con mucho esitoh");
             */

            for(int i = 0; i < 100; i++)
                seAnadio = (AgendaSecreta + "Una Entrada");
            
            AgendaSecreta.ListarAnotaciones();

            Console.ReadKey();
        }
    }
}
