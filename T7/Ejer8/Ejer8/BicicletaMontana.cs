using System;

namespace Ejer8
{
    sealed class BicicletaMontana:Bicicleta
    {
        string[] _nombres = { "RALLON M-LTD", "OCCAM AM M-LTD", "LAUFEY 27+ H30", "ALMA M-LTD" };
        enum TipoAmortiguacion { Hiráulica, Muelle,No_tiene};
        TipoAmortiguacion _tipoAmortiguacion;
        string _kitReparacion;
        uint _diametroDeLasRuedas;

        public BicicletaMontana() : base()
        {
            Random rnd = new Random();
            Nombre = _nombres[rnd.Next(_nombres.Length - 1)];
            NRuedas = 2;
            _kitReparacion = rnd.Next(0, 2) == 1 ? "Kit Incluido" : "Debe ser comprado aparte";
            _diametroDeLasRuedas = (uint)rnd.Next(18,29);
            Color = Colores[rnd.Next(Colores.Length)];
            AsignaTipoTraccion = TipoTraccion.VTH;
            Precio = (uint)rnd.Next(5000);
            FechaCompra = DateTime.Today.AddDays(-rnd.Next(2 * 365));
            _tipoAmortiguacion = (TipoAmortiguacion)rnd.Next(0, 3);
        }

    public override string ToString()
    {
        return "   DATOS DE LA BICICLETA DE MONTAÑA" + base.ToString() + "\n" + "  KIT REPARACION: " + _kitReparacion + "\n DIÁMETRO RUEDAS: " + _diametroDeLasRuedas + "\"\n" + "T. AMORTIGUACION:" + _tipoAmortiguacion;
    }
}
}
