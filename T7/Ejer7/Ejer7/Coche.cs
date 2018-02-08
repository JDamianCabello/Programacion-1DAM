using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer7
{
    class Coche:ICarrera
    {
        string _modelo;
        uint _velocidad;

        string[] nombres = 
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

        public Coche()
        {
            Random rnd = new Random();
            _modelo = nombres[rnd.Next(0,nombres.Length)];
            _velocidad = (uint)rnd.Next(1,301);
        }

        public void Correr()
        {
            Console.WriteLine("El coche del tipo {0} está en marcha a {1} km´s por hora.",_modelo,_velocidad);
        }
    }
}
