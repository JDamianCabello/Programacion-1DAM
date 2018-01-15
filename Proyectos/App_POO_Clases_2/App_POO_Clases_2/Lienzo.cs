using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Clases_2
{
    public class Lienzo
    {
        //Estos campos deberían estar controlados por propiedades.
        public int _x;
        public int _y;
        public int _alto;
        public int _ancho;


        public Lienzo()
        {
            _alto = 1;
            _ancho = 1;
            _x = 0;
            _y = 0;
        }

        public Lienzo(int x, int y, int alto, int ancho)
        {
            _alto = alto;
            _ancho = ancho;
            _x = x;
            _y = y;
        }

        //Aquí los miembros de la clase (métodos, propiedades, etc...)
        public void Dibuja()
        {
            Console.WriteLine("[LIENZO]: Preparando el dibujo de {0} de alto y {1} de ancho en las coordenadas X:{2}, y:{3}", _alto,_ancho,_x,_y);
        }
    }
}
