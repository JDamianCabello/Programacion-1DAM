using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer20
{
    enum Palos { Oro, Copa, Espada, Basto };

    struct Carta
    {
        #region CamposDeLaEstructura

        int valor;      //Valor de la carta.
        Palos palo;     //Palo de la carta.
        double peso;    //Peso de carta dado el juego. 

        #endregion


        /// <summary>
        /// Crea una structura del tipo carta.
        /// </summary>
        /// <param name="valor">El valor numérico de la carta.</param>
        /// <param name="palo">El palo de la carta.</param>
        public Carta(int valor, Palos palo)
        {


            valor = valor < 1 ? 1 : valor;
            valor = valor > 12 ? 12 : valor;

            this.valor = valor;
            this.palo = palo;

            this.peso = valor >= 1 && valor <= 9 ? valor : .5;  //.x es lo mismo que poner 0.x
        }



        #region Método que acceden a los campos PRIVADOS.

        public int GetValor() { return this.valor; }
        public Palos GetPalo() { return this.palo; }
        public double GetPeso() { return this.peso; }

        public override string ToString()
        {
            string[] nombres = { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Sota", "Caballo", "Rey" };
            return nombres[valor - 1] + " de " + palo.ToString();
        }

        #endregion
    }
    class Program
    {
        static void Main(string[] args)
        {
        }

        private static List<Carta> CreaBarajaSieteYMedia()
        {
            List<Carta> barajaAux = new List<Carta>();

            for(int palo = 1; palo < 4; palo++)
                for(int valor = 1; valor < 13; valor++)
                    if(valor != 8 || valor != 9)
                        barajaAux.Add(new Carta(valor, (Palos)palo));

            return barajaAux;
        }
    }
}
