using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-----------------------------
using Geometria;

namespace PruebaGeometria
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Dado un vértice (3,3) y un largo (15)");
            Cuadrado cuadrado1 = new Cuadrado(new Punto(3, 3), 15);
            cuadrado1.Pinta(ConsoleColor.DarkBlue);
            Console.ResetColor();
            Console.WriteLine("\n\n");
            Console.WriteLine("Dado un vértice1 (3, 25) y un vertice 3 (3, 40)");
            Cuadrado cuadrado2 = new Cuadrado(new Punto(3, 25), new Punto(3, 40));
            cuadrado2.Pinta(ConsoleColor.Yellow);

            Console.ReadKey();
        }
    }
}

namespace Geometria
{
    public class Punto
    {
        int _x;
        int _y;

        public int X { get => _x; }
        public int Y { get => _y; }

        public Punto(int x, int y)
        {
            _x = x;
            _y = y;
        }
    }

    public class Cuadrado
    {
        Punto _vertice1;
        Punto _vertice2;
        Punto _vertice3;
        Punto _vertice4;
        int _lado;
        int _area;
        int _perimetro;

        public Punto Vertice1 { get => _vertice1; }
        public Punto Vertice2 { get => _vertice2; }
        public Punto Vertice3 { get => _vertice3; }
        public Punto Vertice4 { get => _vertice4; }
        public int Lado { get => _lado; set => _lado = value; }
        public int Area { get => _area; }
        public int Perimetro { get => _perimetro; }

        public Cuadrado(Punto v1, int longitudLado)
        {
            Lado = longitudLado;
            _vertice1 = v1;
            _vertice2 = new Punto(Vertice1.X + Lado, Vertice1.Y);
            _vertice3 = new Punto(Vertice1.X, _vertice1.Y + Lado);
            _vertice4 = new Punto(Vertice1.X + Lado, Vertice1.Y + Lado);
            _area = (int)Math.Pow(Lado, 2);
            _perimetro = Lado * 4;
        }

        public Cuadrado(Punto v1, Punto v3)
        {
            _vertice1 = v1;
            _vertice3 = v3;
            Lado = Vertice3.Y - Vertice1.Y;
            _vertice2 = new Punto(Vertice1.X + Lado, Vertice1.Y);
            _vertice4 = new Punto(Vertice1.X + Lado, Vertice1.Y + Lado);
            _area = (int)Math.Pow(Lado, 2);
            _perimetro = Lado * 4;
        }

        public void Pinta(ConsoleColor colorCuadrado)
        {
            for (int i = 0; i < Lado; i++)
            {
                for (int j = 0; j < Lado; j++)
                {
                    Console.SetCursorPosition(Vertice1.X + j, Vertice1.Y + i);
                    Console.BackgroundColor = colorCuadrado;
                    Console.Write(' ');
                }
                Console.WriteLine();
            }
        }
    }
}
