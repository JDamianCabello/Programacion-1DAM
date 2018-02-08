using System;

namespace Ejer8
{
    sealed class Coche:Vehiculo
    {
        string[] _modelos =
        {
            "Abarth",
            "Alfa Romeo",
            "Aro",
            "Asia",
            "Asia Motors",
            "Aston Martin",
            "Audi",
            "Austin",
            "Auverland",
            "Bentley",
            "Bertone",
            "Bmw",
            "Cadillac",
            "Chevrolet",
            "Chrysler",
            "Citroen",
            "Corvette",
            "Dacia",
            "Daewoo",
            "Daf",
            "Daihatsu",
            "Daimler",
            "Dodge",
            "Ferrari",
            "Fiat",
            "Ford",
            "Galloper",
            "Gmc",
            "Honda",
            "Hummer",
            "Hyundai",
            "Infiniti",
            "Innocenti",
            "Isuzu",
            "Iveco",
            "Iveco-pegaso",
            "Jaguar",
            "Jeep",
            "Kia",
            "Lada",
            "Lamborghini",
            "Lancia",
            "Land-rover",
            "Ldv",
            "Lexus",
            "Lotus",
            "Mahindra",
            "Maserati",
            "Maybach",
            "Mazda",
            "Mercedes-benz",
            "Mg",
            "Mini",
            "Mitsubishi",
            "Morgan",
            "Nissan",
            "Opel",
            "Peugeot",
            "Pontiac",
            "Porsche",
            "Renault",
            "Rolls-royce",
            "Rover",
            "Saab",
            "Santana",
            "Seat",
            "Skoda",
            "Smart",
            "Ssangyong",
            "Subaru",
            "Suzuki",
            "Talbot",
            "Tata",
            "Toyota",
            "Umm",
            "Vaz",
            "Volkswagen",
            "Volvo",
            "Wartburg",
        };
        
        uint _velocidadMaxima;
        public enum Estado { En_Movimiento, Parado };
        Estado _estado;


        public Coche()
        {
            Random rnd = new Random();
            Nombre = _modelos[rnd.Next(_modelos.Length)];
            NRuedas = 4;
            Color = Colores[rnd.Next(Colores.Length)];
            _velocidadMaxima = (uint)rnd.Next(301);
            _estado = rnd.Next(0, 2) == 1 ? Estado.En_Movimiento : Estado.Parado;
            AsignaTipoTraccion = (TipoTraccion)rnd.Next(0,5);
        }

        public override string ToString()
        {
            return "     DATOS DEL COCHE\n" + base.ToString() + "\n" + "ESTADO DEL COCHE: " + _estado + "\n" + "VELOCIDAD MÁXIMA: " + _velocidadMaxima + " Km/h";
        }
    }
}
