using System;

namespace Ejer8
{
    sealed class BicicletaPaseo:Bicicleta
    {
        string[] _modelos = { "PASEO URBANAS", "FIXIE", "CRUISER", "TRICICLOS DE PASEO" };
        string[] _nombres = { "BICICLETA MONTY CITY 3 2017", "BICICLETA ORBEA CONFORT 40 2017", "BICICLETA BH RENEGADE 2018" };

        string _modelo;
        string _marca;
        uint _nCestas;
        string[] _marcas = { "MONTY", "ORBEA", "BH" };
        public BicicletaPaseo()
        {
            int aux;
            Random rnd = new Random();
            aux = rnd.Next(_modelos.Length-1);
            Nombre = _nombres[rnd.Next(_modelos.Length -1)];
            _modelo = _modelos[aux];
            _marca = _marcas[aux];
            NRuedas = 2;
            _nCestas = (uint)rnd.Next(2);
            Color = Colores[rnd.Next(Colores.Length)];
            AsignaTipoTraccion = TipoTraccion.VTH;
            Precio = (uint)rnd.Next(5000);
            FechaCompra = DateTime.Today.AddDays(-rnd.Next(2*365));
        }

        public override string ToString()
        {
            return "   DATOS DE LA BICICLETA DE PASEO" + base.ToString() + "\n" + "          MODELO: " +_modelo + "\n           MARCA: " + _marca + "\n" + "NÚMERO DE CESTAS: " + _nCestas ;
        }
    }
}
