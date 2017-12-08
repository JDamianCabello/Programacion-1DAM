using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7_8
{
    class Program
    {
        private static string LETRAS = "abcdefghijklmñnopqrstuvwxyzABCDEFGHIJKLMNÑOPQRSTUVWXYZ";

        static void Main(string[] args)
        {
            string texto = "===Prueba de encriptado César.....===";
            string encriptado = Cifrado(texto, 3);
            string desencriptado = Descifrado(texto, 3);
            Console.WriteLine(texto);
            Console.WriteLine(encriptado);
            Console.WriteLine(desencriptado);


            Console.ReadKey();
        }


        private static string Cifrado(string frase, int desplazamiento)
        {
            string aux = string.Empty;
            int auxPosChar = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                auxPosChar = PosicionAbecedario(frase[i]);
                if (auxPosChar != -1)
                    aux += LETRAS[(auxPosChar + desplazamiento) % LETRAS.Length];
                else
                    aux += frase[i];
            }
            return aux;   
        }

        private static string Descifrado(string frase, int desplazamiento)
        {
            string aux = string.Empty;
            int auxPosChar = 0;

            for (int i = 0; i < frase.Length; i++)
            {
                auxPosChar = PosicionAbecedario(frase[i]);
                if (auxPosChar != -1)
                    aux += LETRAS[(auxPosChar - desplazamiento + 3) % LETRAS.Length];
                else
                    aux += frase[i];
            }
            return aux;
        }

        private static int PosicionAbecedario(char c)
        {
            for (int i = 0; i < LETRAS.Length; i++)
                if (c == LETRAS[i])
                    return i;
            return -1;
        }





    }
}
