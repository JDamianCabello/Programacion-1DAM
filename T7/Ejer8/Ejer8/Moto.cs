using System;

namespace Ejer8
{
    sealed class Moto:Vehiculo
    {
        string[] _modelos = { "Honda", "Yamaha", "Kawasaki", "Ducati", "Harley-Davidson", "Suzuki", "KTM", "MW Motorrad", "BMW", "Triumph", "Victoria" };
        uint _potencia;
        public enum TipoCombustible { mezcla, normal };
        TipoCombustible _tipoCombustible;
        public Moto()
        {
            Random rnd = new Random();
            Nombre = _modelos[rnd.Next(_modelos.Length)];
            NRuedas = 2;
            Color = Colores[rnd.Next(Colores.Length)];
            _potencia = (uint)rnd.Next(125,1000);
            _tipoCombustible = rnd.Next(0, 2) == 1 ? TipoCombustible.mezcla : TipoCombustible.normal;
            AsignaTipoTraccion = (TipoTraccion)rnd.Next(0, 5);
        }

        public override string ToString()
        {
            return "    DATOS DE LA MOTO\n" + base.ToString() + "\n"+"TIPO COMBUSTIBLE: " + _tipoCombustible + "\n" + "        POTENCIA: " + _potencia + " cc";
        }

    }
}
