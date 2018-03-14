using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_SerializaPersona
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"c:\basura\personas.dat";

            GestionPersonas personas = new GestionPersonas(ruta);

            personas.Borrar();

            personas.Anadir(new Persona("Pepito","Grillo", 123.66F));
            personas.Anadir(new Persona("Romso", "Kimary", 1223.66F));
            personas.Anadir(new Persona("Ichigo", "Kurosaki", 123.66F));

            personas.Listar();
            
        }
    }
}
