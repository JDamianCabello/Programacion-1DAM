using System;

namespace Ejer10
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ibanes = { "es0700120345030000067890", "BE89999999999999", "es0100120345030000067890", "ES6621000418401234567891", "ES1036431613551926201034" };
            for (int i = 0; i < ibanes.Length; i++)
            {
                if (ValidarIBAN(ibanes[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El IBAN es válido.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El IBAN es inválido.");
                }
                Console.ResetColor();
                Console.WriteLine("\n\n===================================\n\n");
            }
            Console.WriteLine("Pulsa una tecla para salir....");
            Console.ReadKey();
        }

        static bool ValidarIBAN(string iban)
        {
            string aux = string.Empty;
            string modulo = string.Empty;


            if (iban.Length != 24 && iban.Length!=16)
                return false;
            aux = iban.Substring(4) + CalculaLetra(iban.Substring(0, 4));
            modulo = CalcularModulo(aux);


            Console.WriteLine("             País: " + iban.Substring(0,2).ToUpper());
            Console.WriteLine("Dígito de control: " + iban.Substring(2,2));
            Console.WriteLine(" Número de cuenta: " + iban.Substring(5));
            Console.WriteLine("        Módulo 97: " + modulo);

            if (Convert.ToInt32(modulo) == 1)
                return true;
            return false;
        }

        static string CalculaLetra(string letrasCuenta)
        {
            string aux = string.Empty;
            const string LETRAS = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

            for (int i = 0; i < letrasCuenta.Length; i++)
                if (Char.IsLetter(letrasCuenta[i]))
                {
                    for (int j = 0; j < LETRAS.Length; j++)
                        if (Char.ToUpper(letrasCuenta[i]) == LETRAS[j])
                        {
                            aux += (10 + j).ToString();
                            break;
                        }
                }
                else
                {
                    aux += letrasCuenta[i];
                }


            return aux;
        }

        static string CalcularModulo(string dividendo)
        {
            string aux = string.Empty;
            const int DIVISOR = 97;
            long modulo = 0;
            int contador = 0;

            while (contador != dividendo.Length)
            {
                if (((dividendo.Length + aux.Length) - contador) >= 9)
                {
                    if (aux.Length == 2)
                    {
                        aux += dividendo.Substring(contador, 7);
                        contador += 7;
                    }
                    else
                    {
                        aux += dividendo.Substring(contador, 9);
                        contador += 9;
                    }                   
                }
                else
                {
                    aux += dividendo.Substring(contador);
                    contador = (sbyte)dividendo.Length;
                }

                modulo = Convert.ToInt32(aux) % DIVISOR;

                aux = modulo.ToString();
            }
            return modulo.ToString().Length == 1 ? "0" + modulo.ToString() : modulo.ToString();
            
        }
    }
}
