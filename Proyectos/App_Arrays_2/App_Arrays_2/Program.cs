using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Arrays_2
{
    class Program
    {
        static int[] datos = { 40, 21, 4, 9, 19, 35 };
        static int nDatos = 6;

        static void Main(string[] args)
        {
            Console.WriteLine("Array sin ordenar.");
            Mostrar();

            OrdBurbuja(datos, nDatos);
            Console.WriteLine("Array ordenado.");
            Mostrar();
            /*
            Anadir(8);
            Mostrar();

            Console.WriteLine("Inserta el -1 al inicio");
            Insertar(datos, -1, 0, ref nDatos);

            Mostrar();

            BorrarElemento(datos, 0, ref nDatos);
            Mostrar();   
             */
        }

        static void OrdBurbuja(int[] vector, int nDatos)
        {
            int aux = 0;

            for(int i = 1; i < nDatos; i++)
                for(int j = nDatos - 1; j >= i; j--)
                    if(vector[j] < vector[j - 1])
                    {
                        aux = vector[j];
                        vector[j] = vector[j - 1];
                        vector[j - 1] = aux;
                    }
        }
        
        static int BorrarElemento(int[] vector, int pos, ref int nDatos)
        {
            if(nDatos == 0 || pos < 0 || pos > nDatos - 1)
                return -1;
            for(int i = pos; i < nDatos - 1; i++)
                vector[i] = vector[i + 1];

            nDatos--;

            return pos;
        }

        static bool Insertar(int[] vector, int dato, int pos, ref int nDatos)
        {
            //inserta el dato en la posición pos.
            if(nDatos == vector.Length || pos < 0 || pos > nDatos)
                return false;

            for(int i = nDatos; i > pos; i--)
                vector[i] = vector[i - 1];

            vector[pos] = dato;
            nDatos++;

            return true;
        }

        static bool Anadir(int dato)
        {
            if(nDatos == datos.Length)
                return false;
            datos[nDatos++] = dato;
            return true;
        }

        /// <summary>
        /// Busca de forma binaria el dato buscado en el array vector.
        /// IMPORTANTE: El array tiene que estar ordenado
        /// </summary>
        /// <param name="vector">Array donde se hace las búsqueda.</param>
        /// <param name="buscado">Valor a buscar</param>
        /// <returns>-1 si no está, otro valos positivo con la posicion del dato si lo encuentra</returns>
        static int BusquedaBinaria(int[] vector, int buscado)
        {
            int tamano = vector.Length;
            int inicio = 0;
            int final = tamano - 1;
            int medio = (inicio + final) / 2;

            while(vector[medio] != buscado && inicio <= final)
            {
                medio = (inicio + final) / 2;
                if(buscado > vector[medio])
                    inicio = medio + 1;
                else
                    final = medio - 1;
            }

            if(vector[medio] == buscado)
                return medio;
            return -1;
        }

        /// <summary>
        /// Busca de forma secuencial el dato buscado en el array vector.
        /// </summary>
        /// <param name="vector">Array donde se hace las búsqueda.</param>
        /// <param name="buscado">Valor a buscar</param>
        /// <returns>-1 si no está, otro valos positivo con la posicion del dato si lo encuentra</returns>
        static int BusquedaSecuencial(int[] vector, int buscado)
        {
            int tamano = vector.Length;
            int contador = 0;
            if(tamano == 0)
                return -1;

            while(contador < tamano && buscado != vector[contador])
                contador++;

            if(contador >= tamano)
                return -1;
            else
                return contador;
        }

        static void Mostrar()
        {
            for(int i = 0; i < nDatos; i++)
                Console.Write("{0,3},",datos[i]);

            Console.Write("\n\nPulsa una tecla para salir...");
            Console.ReadLine(); ;
        }

        static void BorrarArray()
        {
            nDatos = 0; //Da igual que este lleno pues nosotros solo conocemos hasta nDatos por ende si lo ponemos 0 para nuestro programa esta borrado.
        }
    }
}
