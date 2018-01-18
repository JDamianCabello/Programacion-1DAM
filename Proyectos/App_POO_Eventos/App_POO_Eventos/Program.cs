using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Eventos
{
    class Program
    {
        static void Main(string[] args)
        {
            Contador c1 = new Contador();

            //Nos suscribimos a los eventos.
            c1.cambioValor += c1_cambioValor;
            c1.cambioValorMultiplo5 += c1_cambioValorMultiplo5;

            c1.Iniciar = true;
            c1.VerContador();

            Console.ReadLine();
        }

        static void c1_cambioValorMultiplo5()
        {
            Console.WriteLine("Es múltiplo de 5");
        }

        static void c1_cambioValor()
        {
            Random rnd = new Random();
            Console.ForegroundColor = (ConsoleColor)rnd.Next(1,16);
        }
    }

    class Contador
    {
        //Delegado a para los eventos.
        public delegate void CambiaContador();

        //Eventos de nuestra clase.
        public event CambiaContador cambioValor;
        public event CambiaContador cambioValorMultiplo5;

        int _contador;
        bool _iniciar;
        int _fin;

        public Contador()
        {
            _contador = 0;
            _iniciar = false;
            _fin = 100;
        }

        public bool Iniciar
        {
            get { return _iniciar; }
            set { _iniciar = value; }
        }

        public void VerContador()
        {
            //En esta clase si no esta iniciado no lo veriamos.
            if(!_iniciar)
                return;

            for(int i = 0; i < _fin; i++)
            {
                System.Threading.Thread.Sleep(500);
                Console.SetCursorPosition(10, 10);
                Console.WriteLine(++_contador);

                //Comprobamos si hay alguien suscrito a nuestra clase de ser asi ya no sería null y lanzaría el evento.
                if(cambioValor != null)
                    cambioValor();
                if(cambioValorMultiplo5 != null && _contador % 5 == 0)
                    cambioValorMultiplo5();
            }
        }
    }
}
