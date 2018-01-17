using System;

namespace Ejer15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] frases =
            {
                "Sé verlas al revés.",
                "Átale, demoníaco Caín, o me delata.",
                "Sólo dí sol a los ídolos.",
                "Allí tápase Menem esa patilla.",
                "Roma le da té o pan a poeta del amor.",
                "Yo dono rosas, oro no doy.",
                "Ella te dara detalle.",
                "Esto no es palindromo",
                "Yo hago yoga hoy.",
                "ANITA LAVA LA TINA.",
                "DÁBALE ARROZ A LA ZORRA EL ABAD.",
                "NO TARDES Y SED RATÓN.",
                "NO DESEO ESE DON.",
                "ABAJO ME MOJABA .",
                "AGOTA LA TOGA.",
                "Un ejemplo malo",
                "AMIGO, NO GIMA.",
                "ANA LLEVA AL OSO LA AVELLANA.",
                "ES RARO DORARSE.",
                "OÍR ESE RÍO.",
                "SE VAN SUS NAVES.",
                "SOMOS O NO SOMOS.",
                "YO VOY.",
                "Me aburrí haciendo el ejercicio....",
                "LUZ AZUL.",
                "A Mercedes ése de crema.",
            };
            string fraseAux = string.Empty;
            Console.WriteLine("Programa que dice si una frase es palíndroma.\n\n");

            for (int i = 0; i < frases.Length; i++)
            {
                fraseAux = Estandariza(frases[i]);

                Console.Write("[{0}]: {1}        ",(i + 1).ToString().PadLeft(2),frases[i].PadLeft(50));

                if (EsPalindromo(fraseAux))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("[Es palíndromo]");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("[No es palíndromo]");
                }
                Console.ResetColor();
            }

            
            Console.WriteLine("\n\nPulsa una tecla para salir.....");
            Console.ReadKey();
        }

        static string Estandariza(string frase)
        {
            frase = frase.ToLower();
            string[] oldCaracter = { " ", "á", "é", "í", "ó", "ú", ",","." };
            string[] newCaracter = { "", "a", "e", "i", "o", "u","","" };

            for (int i = 0; i < oldCaracter.Length; i++)
                frase = frase.Replace(oldCaracter[i], newCaracter[i]);
            return frase;
        }

        static bool EsPalindromo(string s)
        {
            string aux = string.Empty;

            for (int i = s.Length - 1; i >= 0; i--)
                aux += s[i];

            return s.ToUpper() == aux.ToUpper() ? true : false;
        }
    }
}
