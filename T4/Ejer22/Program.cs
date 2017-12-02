using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejer_2;
using Ejer_4;
using Ejer_10;
using Ejer_12;
using Ejer_13;
using Ejer_14;
using Ejer_15;
using Ejer_16;
using Ejer_17;

namespace Ejer_22
{
    class Program
    {
        static void Main(string[] args)
        {
            char caracter = '\0';
            string texto = string.Empty;
            int numero = 0;
            int numero2 = 0;
            bool salida = true;
            double numerodoble = 0;
            double numeroDoble2 = 0;
            string opcion = string.Empty;
            do
            {
                uiMenu();
                opcion = Console.ReadLine();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.Title = "Lista Caracteres";
                        Console.WriteLine("DLL que dibuja una lista de caracteres dado un caracter y el total de veces que se debe repetir.");
                        Console.Write("Introduce el caracter: ");
                        caracter = (char)Console.Read();
                        Console.ReadLine();
                        Console.Write("Introduce cuantas veces quieres que se repita: ");
                        if (int.TryParse(Console.ReadLine(),out numero))
                            {
                            texto = Dibuja.dibujaCaracter(caracter, numero);
                            Console.WriteLine(texto);
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();  
                            }
                        else
                        {
                            Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();
                        }
                      
                        break;
                    case "2":
                        Console.Clear();
                        Console.Title = "Primo de número";
                        Console.WriteLine("DLL que muestra si un número entero es primo o no.");
                        Console.Write("Introduce el número: ");
                            if (int.TryParse(Console.ReadLine(), out numero))
                            {
                                if (EsPrimo.primo(numero))
                                    Console.WriteLine("El numero {0} es primo.",numero);
                                else
                                    Console.WriteLine("El numero {0} no primo.", numero);
                                    Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                                    Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                                Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                                Console.ReadLine();
                            }
                        break;
                    case "3":
                        Console.Clear();
                        Console.Title = "Valor absoluto";
                        Console.WriteLine("DLL que muestra el valor absoluto de un número entero.");
                        Console.Write("Introduce el número: ");

                        if (double.TryParse(Console.ReadLine(), out numeroDoble2))
                        {
                            numerodoble = ValorAbsoluto.valorAbsolutoNumero(numeroDoble2);
                            Console.WriteLine("El valor absoluto de {0} es {1}", numeroDoble2, numerodoble);
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();  
                        }
                        else
                        {
                            Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();
                        }
                        
                        break;
                    case "4":
                        Console.Clear();
                        Console.Title = "Factorial recursivo número";
                        Console.WriteLine("DLL que muestra el factorial recursivo de un número entero.");
                        Console.Write("Introduce el número: ");

                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.WriteLine("El factorial recursivo de {0} es {1}", numero, RecursivaFactorial.factorialRecursivoNum(numero));
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine(); 
                        }
                        else
                        {
                            Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();
                        }
                        break;
                    case "5":
                        Console.Clear();
                        Console.Title = "Factorial iterativo número";
                        Console.WriteLine("DLL que muestra el factorial iterativo de un número entero.");
                        Console.Write("Introduce el número: ");

                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.WriteLine("El factorial iterativo de {0} es {1}", numero, Class1.FactorialIterativo(numero));
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();  
                        }
                        else
                        {
                            Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();
                        }
                        break;
                    case "6":
                        Console.Clear();
                        Console.Title = "Suma recursivo número";
                        Console.WriteLine("DLL que muestra la suma recursiva de un número entero.");
                        Console.Write("Introduce el número: ");

                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.WriteLine("El la suma recursiva de {0} es {1}", numero, SumaRecursiva.SumRecursiva(numero));
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();  
                        }
                        else
                        {
                            Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();
                        }
                        break;
                    case "7":
                        Console.Clear();
                        Console.Title = "Suma iterativa número";
                        Console.WriteLine("DLL que muestra la suma iterativa de un número entero.");
                        Console.Write("Introduce el número: ");

                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.WriteLine("El la suma iterativa de {0} es {1}", numero, SumaIterativa.SumIterativa(numero));
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine(); 
                        }
                        else
                        {
                            Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();
                        }
                        break;
                    case "8":
                        Console.Clear();
                        Console.Title = "Potencia recursiva número";
                        Console.WriteLine("DLL que muestra la potencia recursiva de un número entero.");
                        Console.Write("Introduce la base: ");
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.Write("Introduce el exponente: ");
                            if (int.TryParse(Console.ReadLine(), out numero2))
                            {
                                Console.WriteLine("El la potencia recursiva de {0}^{1} es {2}", numero, numero2, PotenciaRecursiva.PotRecursiva(numero, numero2));
                                Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                                Console.ReadLine();  
                            }
                            else
                            {
                                Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                                Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();
                        }
                        break;
                    case "9":
                        Console.Clear();
                        Console.Title = "Resto división";
                        Console.WriteLine("DLL que muestra resto de una división dado el divisor y el dividendo.");
                        Console.Write("Introduce el divisor: ");
                        if (int.TryParse(Console.ReadLine(), out numero))
                        {
                            Console.Write("Introduce el dividendo: ");
                            if (int.TryParse(Console.ReadLine(), out numero2))
                            {
                                Console.WriteLine("El resultado de dividor/dividendo es {0}", numero / numero2);
                                Console.WriteLine("El resto de esa división sería: {0}", RestoDivision.restoNum(numero, numero2));
                                Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                                Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                                Console.ReadLine();
                            }
                        }
                        else
                        {
                            Console.WriteLine("Una de las variables introducidas no cumple el formato.");
                            Console.WriteLine("Pulsa Enter (Intro) para continuar.");
                            Console.ReadLine();
                        }
                        
                        break;
                    case "0":
                        salida = false;
                        break;
                    default:
                        break;
                }
            } while (salida);
        }

        static void uiMenu()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 80; i++)
            {
                Console.Write("=");
                if (i == 80)
                    Console.Write("\n");
            }
            Console.ResetColor();
            Console.WriteLine("\t\tMENU\tPRINCIPAL\tRelación de Ejercicios 4");
            Console.ForegroundColor = ConsoleColor.Cyan;
            for (int i = 0; i < 80; i++)
            {
                Console.Write("=");
                if (i == 80)
                    Console.Write("\n");
            }
            Console.ResetColor();
            Console.WriteLine("\n\t\t1.\tMostrar lista caracteres (Ej_02).");
            Console.WriteLine("\t\t2.\tProbar si un número es primo (Ej_04).");
            Console.WriteLine("\t\t3.\tValor absoluto (Ej_10).");
            Console.WriteLine("\t\t4.\tFactorial recursivo (Ej_12).");
            Console.WriteLine("\t\t5.\tFactorial iterativo (Ej_13).");
            Console.WriteLine("\t\t6.\tSuma recursiva (Ej_14).");
            Console.WriteLine("\t\t7.\tSuma iterativa (Ej_15).");
            Console.WriteLine("\t\t8.\tPotencia recursiva (Ej_16).");
            Console.WriteLine("\t\t9.\tObtener el resto de división (Ej_17).");
            Console.WriteLine("\n\t\t0.\tSalir.");
            Console.Write("\n\n\t\tSelecciona una opción: ");
        }
    }
}
