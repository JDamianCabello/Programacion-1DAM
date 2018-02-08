using System;
using System.Collections.Generic;

namespace Ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehiculo> tiendaVehiculos = new List<Vehiculo>();
            Random rnd = new Random();
            for (int i = 0; i <= 20; i++)
            {
                switch (rnd.Next(0,4))
                {
                    case 0:
                        tiendaVehiculos.Add(new Moto());
                        break;
                    case 1:
                        tiendaVehiculos.Add(new Coche());
                        break;
                    case 2:
                        tiendaVehiculos.Add(new BicicletaPaseo());
                        break;
                    case 3:
                        tiendaVehiculos.Add(new BicicletaMontana());
                        break;
                }
                System.Threading.Thread.Sleep(5);
            }

            foreach (Vehiculo unVehiculo in tiendaVehiculos)
                Console.WriteLine(unVehiculo.ToString() + "\n\n");

            Console.WriteLine("Pulsa una tecla para salir....");
            

            Console.ReadKey();
            
        }
    }
}
