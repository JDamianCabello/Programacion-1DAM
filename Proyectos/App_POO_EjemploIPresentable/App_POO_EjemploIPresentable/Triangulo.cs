using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_EjemploIPresentable
{
    class Triangulo : IPresentable
    {
        public event EventHandler OnPresentar;



        double _base;
        double _altura;


        public Triangulo(double _base, double _altura)
        {
            this._base = _base;
            this._altura = _altura;
        }

        public double Area
        {
            get { return _base * _altura / 2; }
        }

        public void Presentar()
        {
            if(OnPresentar != null)
                OnPresentar(this, null);
            Console.WriteLine("Base:".PadLeft(15) + " {0,4}", _base);
            Console.WriteLine("Altura:".PadLeft(15) + " {0,4}", _altura);
            Console.WriteLine("Area:".PadLeft(15) + " {0,4}", Area);
        }
    }
}
