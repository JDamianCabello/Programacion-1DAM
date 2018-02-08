using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Interface
{
    public delegate void DAnotacion(string s);


    interface IPrueba
    {
        void Mostrar();
        string Anotacion { get; set; }
        string this[int indice] { get; }
        event DAnotacion Anadido;
    }


    class Agenda : IPrueba
    {
        public void Mostrar()
        {
            throw new NotImplementedException();
        }

        public string Anotacion
        {
            get
            {
                throw new NotImplementedException();
            }
            set
            {
                throw new NotImplementedException();
            }
        }

        public string this[int indice]
        {
            get { throw new NotImplementedException(); }
        }

        public event DAnotacion Anadido;
    }

}
