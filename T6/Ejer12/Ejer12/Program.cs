using System;

namespace Ejer12
{
    class Program
    {
        static void Main(string[] args)
        {
            string frase = string.Empty;
            Console.WriteLine("Programa que convierte frases a mayúsculas");
            Console.Write("Introduce tu frase: ");
            frase = Console.ReadLine();

            Console.WriteLine("Frase en mayúsculas: {0}",Mayuscula(frase));
            Console.WriteLine("Pulsa una tecla para salir....");
            Console.ReadKey();


        }


        static string Mayuscula(string frase)
        {
            string aux = string.Empty;
            for (int i = 0; i < frase.Length; i++)
                if (char.IsLetter(frase[i]))
                    aux += Convert.ToChar(char.ToLower(frase[i]) - 32);
                else
                    aux += frase[i];

            return aux;
        }
    }
}
