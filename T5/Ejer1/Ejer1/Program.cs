using System;


namespace Ejer1
{
    class Program
    {
        private static void Main(string[] args)
        {
            char c = ' ';
            int n = 0;
            string[] dias = { "L", "M", "X", "J", "V", "S", "D" };

            Console.WriteLine(" El tipo de un entero es: {0}", n.GetType());
            Console.WriteLine(" El tipo char es: {0}", c.GetType());
            Console.WriteLine(" El valor máximo de un entero es: {0}", int.MaxValue);
            Console.WriteLine(" El valor máximo de un char es: {0}", (int)char.MaxValue);
            Console.WriteLine(" El tamaño de dias es: {0}", dias.Length);

            Console.ReadLine();
        }
    }
}
