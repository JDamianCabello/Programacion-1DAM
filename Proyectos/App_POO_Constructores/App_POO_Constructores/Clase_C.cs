using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian.App_POO_Constructores
{
    class Clase_C
    {
        //Constructor de clase, no se llama y es único por clase. No está en todas las clases.
        //Es público por defecto por lo que no hace falta ponerlo como tal.

        static Clase_C()
        {
            Console.WriteLine("Clase_C: Constructor de CLASE (static)");
        }

        //Constructor de instancia
        public Clase_C()
        {
            Console.WriteLine("Clase_C: Constructor de INSTANCIA");
        }

        //Destructor
        ~Clase_C()
        {
            Console.WriteLine("Clase_C: Destructor");
        }
    }

    class Clase_B : Clase_C
    {
        //Constructor de clase
        static Clase_B()
        {
            Console.WriteLine("Clase_B: Constructor de CLASE (static)");
        }

        //Constructor de instancia
        public Clase_B()
        {
            Console.WriteLine("Clase_B: Constructor de INSTANCIA");
        }

        //Destructor
        ~Clase_B()
        {
            Console.WriteLine("Clase_B: Destructor");
        }
    }

    class Clase_A : Clase_B
    {
        //Constructor de clase
        static Clase_A()
        {
            Console.WriteLine("Clase_A: Constructor de CLASE (static)");
        }

        //Constructor de instancia
        public Clase_A()
        {
            Console.WriteLine("Clase_A: Constructor de INSTANCIA");
        }

        //Destructor
        ~Clase_A()
        {
            Console.WriteLine("Clase_A: Destructor");
        }
    }
}
