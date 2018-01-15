using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Clases_2
{
    class Program
    {
        static void Main(string[] args)
        {
            LienzoImpresora hp = new LienzoImpresora(20,15,5,3,"azul");
            LienzoImpresora otraImpresora = new LienzoImpresora();
            hp.Dibuja();
            Console.WriteLine("============================");
            otraImpresora.Dibuja();
        }
    }
}
