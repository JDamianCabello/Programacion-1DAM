using System;

namespace App_ClonaciónProfundaRectangulo
{
    class Rectangulo : ICloneable
    {
        ConsoleColor color;
        char textura;
        public Punto[] puntos; //Cuatro puntos forman el rectángulo

        public Rectangulo()
        {
            puntos = new Punto[4];
            textura = ' ';
            color = ConsoleColor.White;
        }

        public Rectangulo(Punto p1, Punto p3)
        {
            Punto p2 = new Punto(p3.X, p1.Y);
            Punto p4 = new Punto(p1.X, p3.Y);
            puntos = new Punto[4] { p1, p2, p3, p4 };
            textura = '.';
            color = ConsoleColor.Cyan;
        }


        public object Clone() 
        {
            Rectangulo clonacion = new Rectangulo();
            clonacion = (Rectangulo)this.MemberwiseClone(); //Esto copia todo menos el array.

            //Recorremos el array para devolver en "Clonacion" un array totalmente distinto de el primero.
            for(int i = 0; i < puntos.Length; i++)
                clonacion.puntos[i] = this.puntos[i];

            return clonacion;
        }

        public void Informacion()
        {
            Console.WriteLine("    INFORMACION");
            Console.WriteLine("---------------------");

            Console.WriteLine("\nPUNTOS:");
            Console.WriteLine("\t[P1]: {0}", puntos[0]);
            Console.WriteLine("\t[P2]: {0}", puntos[1]);
            Console.WriteLine("\t[P3]: {0}", puntos[2]);
            Console.WriteLine("\t[P4]: {0}", puntos[3]);

            Console.WriteLine("\nCOLOR:");
            Console.WriteLine("\t[Color]: {0}", color);

            Console.WriteLine("\nTEXTURA:");
            Console.WriteLine("\t[Textura]: {0}", textura);
        }

        public void Dibuja()
        {
            Console.BackgroundColor = color;

            for(int i = puntos[0].X; i < puntos[2].X; i++)
                for(int j = puntos[0].Y; j < puntos[2].Y; j++)
                {
                    Console.SetCursorPosition(i, j);
                    Console.Write(textura);
                }

            Console.ResetColor();
        }
    }
}
