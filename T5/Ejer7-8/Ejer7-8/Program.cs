using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7_8
{
    class Program
    {
        static void Main(string[] args)
        {
            string texto = "zzz";
            string encriptado = LimiteChar(texto, 'a', 'z', 3);
            string desemcriptado = LimiteChar(texto, 'a', 'z', -3);
            Console.WriteLine(texto);
            Console.WriteLine(encriptado);
            Console.WriteLine(desemcriptado);


            Console.ReadKey();
        }

        static string LimiteChar(string a, char inicio, char fin, int desplazamiento)
        {
            int length = (fin - inicio) + 1;
            string aux = string.Empty;

            if(desplazamiento >= 0)
                for(int i = 0; i < a.Length; i++)
                    aux += Convert.ToChar((a[i] - inicio + desplazamiento) % length + inicio);
            else
                for(int i = 0; i < a.Length; i++)
                    Convert.ToChar((a[i] + length - inicio + desplazamiento) % length);

            return aux;
        }

    }
}
