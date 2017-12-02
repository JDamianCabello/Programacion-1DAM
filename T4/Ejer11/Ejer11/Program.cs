namespace Ejer11
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < args.Length; i++)
                System.Console.WriteLine("[{0,2}]\t{1}",i+1,args[i]);

            System.Console.WriteLine("\n\n\nLectura de parámetros terminada. Pulsa una tecla para salir.");
            System.Console.ReadKey();
        }
    }
}
