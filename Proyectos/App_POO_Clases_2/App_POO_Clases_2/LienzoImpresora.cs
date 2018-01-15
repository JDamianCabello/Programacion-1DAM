using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Clases_2
{
    class LienzoImpresora : Lienzo
    {
        string _color;

        public LienzoImpresora(): base()
        {
            _color = "negro";
        }

        public LienzoImpresora(int x, int y, int alto, int ancho, string color): base(x,y,alto,ancho)
        {
            _color = color;
        }

        /// <summary>
        /// Oculta el mienbro dibuja de la clase padre.
        /// </summary>
        public new void Dibuja()
        {
            base.Dibuja(); //Llama a Dibuja() en su clase padre.
            Console.WriteLine("[IMPRESORA]: Realizando la impresión  en color {0}",_color);
        }
    }
}
