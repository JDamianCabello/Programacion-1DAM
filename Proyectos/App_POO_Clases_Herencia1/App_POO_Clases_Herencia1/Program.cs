using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_POO_Clases_Herencia1
{
    class Program
    {
        static void Main(string[] args)
        {
            ClaseDerivada cd = new ClaseDerivada();
            Console.WriteLine(cd.Saluda());
        }
    }

    //Esta clase tiene como base Object.
    abstract class ClaseBase
    {
        public string Saluda(){return "Hola primoh, soy la claseBase...";}
        public abstract string SaludaAbs(string s);
    }

    //Esta clase hereda de ClaseBase y tiene por tanto el método Saluda().
    class ClaseDerivada : ClaseBase
    {
        public override string SaludaAbs(string s)
        {
            throw new NotImplementedException();
        }
    }
}
