using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_SobrecargaDeOperadores
{
    class Agenda
    {
        const int NUMMAXENTRADAS = 100;
        string[] anotaciones = new string[NUMMAXENTRADAS];
        int totalEntradas = 0;


        public void ListarAnotaciones()
        {
            for(int i = 0; i < totalEntradas; i++)
                Console.WriteLine("[{0}]: {1}",i + 1, anotaciones[i]);


            Console.Write("\n\nNo hay más elementos en esta agenda... ");
        }

        //Definición del operador "+" para añadir anotaciones
        public static bool operator +(Agenda unaAgenda, string anotacion)
        {
            if(unaAgenda.totalEntradas == NUMMAXENTRADAS)
                return false;
            unaAgenda.anotaciones[unaAgenda.totalEntradas++] = anotacion;
            return true;
        }
    }
}
