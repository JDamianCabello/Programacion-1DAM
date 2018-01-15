using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_PropiedadesClase
{
    class Program
    {
        static void Main(string[] args)
        {
            Ficha f1 = new Ficha();
            f1.Nombre = "Damián Cabello";
            f1.Edad = 24;
            f1.Nota = 7.75F;


            //OJO!! esta ficha tiene un -34 de nota que está controlado mediante la propiedad la cual si es > 10 pone 10 o < 0 con valor 0.
            Ficha f2 = new Ficha("Juanito el loco", 20, -34.7F);
            Console.WriteLine(f1.ToString());
            Console.WriteLine(f2.ToString());
            Console.ReadKey();
        }
    }

    public class Ficha
    {
        string _nombre;
        int _edad;
        float _nota;

        public Ficha()
        { }

        public Ficha(string nombre, int edad, float nota)
        {
            Nombre = nombre;
            Edad = edad;
            Nota = nota;
        }

        //Propiedades escritas por mi.
        public string Nombre
        {
            get 
            {
                return _nombre;
            }

            set
            {
                _nombre = value;
            }
        }
        public float Nota
        {
            get { return _nota; }
            set 
            {
                if(value > 10)
                    value = 10;
                _nota = value < 0 ? 0 : value;
            }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }

        //Propiedades autoimplementadas/autopropiedades (La verdad no es demasiado recomendable...).
        public string NExpediente { get; set; }

        public override string ToString()
        {
            return _nombre + ";" + _edad.ToString() + ";" + _nota;
        }
    }
}
