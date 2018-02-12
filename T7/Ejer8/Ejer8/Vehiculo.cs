using System;

namespace Ejer8
{


    abstract class Vehiculo
    {
        string _nombre;
        uint _nRuedas;
        string _color;
        TipoTraccion _tipoTraccion;
        public enum TipoTraccion { FWD, AWD, RWD, _4WD, _4x4, VTH };
        string[] _colores = { "negro", "azul", "aguamarina", "azul marino", "verde azulado", "gris oscuro", "verde oscuro", "púrpura", "rojo oscuro", "ocre", "gris", "verde", "fucsia", "rojo", "blanco", "amarillo" };


        public string Nombre
        {
            get
            { return _nombre; }
            set
            {
                if(value == "")
                    throw new ArgumentNullException();
                else
                    _nombre = value;
            }
        }

        public uint NRuedas
        {
            get
            { return _nRuedas; }
            set
            {
                if(value < 1 || value > 50)
                    throw new ArgumentOutOfRangeException();
                else
                    _nRuedas = value;
            }
        }

        public string Color
        {
            get
            { return _color; }
            set
            {
                if(value != _color)
                    _color = value;
            }
        }

        public TipoTraccion AsignaTipoTraccion
        {
            get
            { return _tipoTraccion; }
            set
            {
                if (value != _tipoTraccion)
                    _tipoTraccion = value;
            }
        }

        public string[] Colores { get { return _colores; } set { _colores = value; } }

        public override string ToString()
        {
            return "---------------------------------------------\n" +
                    "          NOMBRE: " + Nombre + "\n" +
                    "NÚMERO DE RUEDAS: " + NRuedas + "\n" +
                    "           COLOR: " + Color + "\n" +
                    "   TIPO TRACCIÓN: " + AsignaTipoTraccion + "\n" +
                    "   TIPO VEHÍCULO: " + this.GetType().Name;
        }
    }
}
