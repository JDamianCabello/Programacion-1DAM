using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_Clase_List_Cartas
{
    class Program
    {
        enum Palos { Oro, Copa, Espada, Basto };

        struct Carta
        {
            #region CamposDeLaEstructura

            int valor;      //Valor de la carta.
            string nombre;  //Nombre de la carta
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
                string[] nombres = { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Sota", "Caballo", "Rey" };

                valor = valor < 1 ? 1 : valor;
                valor = valor > 12 ? 12 : valor;

                this.valor = valor;
                this.nombre = nombres[valor - 1];
                this.palo = palo;

                this.peso = valor >= 1 && valor <= 9 ? valor : .5;  //.x es lo mismo que poner 0.x
            }



            #region Método que acceden a los campos PRIVADOS.

            public int GetValor() { return this.valor; }
            public string GetNombre() { return this.nombre; }
            public Palos GetPalo() { return this.palo; }
            public double GetPeso() { return this.peso; }

            public override string ToString()
            {
                string[] nombres = { "Uno", "Dos", "Tres", "Cuatro", "Cinco", "Seis", "Siete", "Ocho", "Nueve", "Sota", "Caballo", "Rey" };
                return nombres[valor - 1] + " de " + palo.ToString();
            }

            #endregion
        }

        static List<Carta> Baraja1 = new List<Carta>();
        static Random rnd = new Random();

        static void Main(string[] args)
        {
            Baraja1.Add(CrearCarta());
            AnnadirVariasCartas(Baraja1, 20);
            ListadoBaraja(Baraja1);
        }


        #region Métodos que gestionan barajas (o lo intentan porque son deprecated).

        /// <summary>
        /// Método que crea una carta aleatoria
        /// </summary>
        /// <returns>La dirección de una carta.</returns>
        static Carta CrearCarta()
        {
            return new Carta(rnd.Next(1, 13), (Palos)rnd.Next(0, 4));
        }

        /// <summary>
        /// Muestra información sobre una carta en concreto.
        /// </summary>
        /// <param name="carta">La carta de la que veremos la información</param>
        static void VerCarta(Carta carta)
        {
            Console.WriteLine();
            Console.WriteLine("     Valor: {0}", carta.GetValor());
            Console.WriteLine("    Nombre: {0}", carta.GetNombre());
            Console.WriteLine("     Palo : {0}", carta.GetPalo());
            Console.WriteLine("      Peso: {0}", carta.GetPeso());
        }

        /// <summary>
        /// Añade N cartas a una lista.
        /// </summary>
        /// <param name="baraja">La lista a la que añadiremos el intervalo de cartas.</param>
        /// <param name="nCartas">El total de cartas a añadir.</param>
        static void AnnadirVariasCartas(List<Carta> baraja, int nCartas)
        {
            for(int i = 0; i < nCartas; i++)
                baraja.Add(CrearCarta());
        }

        /// <summary>
        /// Muestra un listado en consola de una lista de cartas.
        /// </summary>
        /// <param name="baraja">La baraja que queremos listar.</param>
        static void ListadoBaraja(List<Carta> baraja)
        {

            Console.WriteLine("{0,3}\t{1}\t{2}\t{3}", "Nombre", "Valor", "Palo", "Peso");

            foreach(Carta unaCarta in baraja)
                Console.WriteLine("{0,3}\t{1}\t{2}\t{3}", unaCarta.GetValor(), unaCarta.GetNombre(), unaCarta.GetPalo(), unaCarta.GetPeso());
        }

        /// <summary>
        /// Muestra información de una baraja completa.
        /// </summary>
        /// <param name="baraja">La baraja para ver detalladamente.</param>
        static void VerBaraja(List<Carta> baraja)
        {
            foreach(Carta UnaCarta in baraja)
                VerCarta(UnaCarta);
        }

        #endregion
    }
}
