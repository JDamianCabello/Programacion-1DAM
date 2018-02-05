using System;

namespace App_ClonaciónProfundaRectangulo
{
    class Program
    {
        static void Main(string[] args)
        {
            Punto p1 = new Punto(5, 5);
            Punto p3 = new Punto(20, 10);
            Rectangulo r1 = new Rectangulo(p1, p3);

            
            r1.Dibuja();
            Console.WriteLine("\n\n");
            r1.Informacion();


            //Hacer la copia
            Console.WriteLine("Copia del Rectángulo en p1(0,0)");
            Rectangulo copia = (Rectangulo)r1.Clone();
            copia.puntos[0].X = 0;
            copia.puntos[0].Y = 0;
            copia.Informacion();
            r1.Informacion();
            copia.Dibuja();

            Console.ReadKey();
            Console.WriteLine();

            //Mostrar original
            Console.Clear();
            r1.Dibuja();
            Console.WriteLine();
            r1.Informacion();


            Console.ReadKey();
        }
    }
}
