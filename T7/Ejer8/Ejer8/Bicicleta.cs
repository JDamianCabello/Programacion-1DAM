using System;

namespace Ejer8
{
    abstract class Bicicleta:Vehiculo
    {
        uint _precio;
        DateTime _fechaCompra;

        public uint Precio { get => _precio; set => _precio = value; }
        public DateTime FechaCompra { get => _fechaCompra; set => _fechaCompra = value; }

        public override string ToString()
        {
            return "\n" + base.ToString() + "\n" + "          PRECIO: " + Precio + " Euros\n" + " FECHA DE COMPRA: " + FechaCompra.ToLongDateString();
        }
    }
}
