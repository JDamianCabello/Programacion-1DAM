using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Deportista:ICarrera
    {
        string[] _nombres = { "maria", "teresa", "mariana", "jose", "pedro", "juan" };
        string _nombre;
        uint _dorsal;
        uint _velocidad;

        public Deportista()
        {
            Random rnd = new Random();
            _nombre = _nombres[rnd.Next(_nombres.Length)];
            _dorsal = (uint)rnd.Next(100);
            _velocidad = (uint)rnd.Next(1, 100);
        }

        public void Correr()
        {
            Console.WriteLine("El deportista {0} con dorsal {1} esta corriendo a {2} km´s hora, mientras un coche intenta atropellarlo.",_nombre,_dorsal,_velocidad);
        }
    }
}
