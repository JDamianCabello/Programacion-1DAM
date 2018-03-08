using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//-------------------------------
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace App_SerializaPersona
{
    class GestionPersonas
    {
        string _fichero;

        public GestionPersonas(string fichero)
        {
            _fichero = fichero;
        }

        public bool Anadir(Persona p)
        {
            if(!File.Exists(_fichero))
            {
                FileStream tmpFilestram = File.Create(_fichero);
                tmpFilestram.Close();
            }

            IFormatter formato = new BinaryFormatter(); //No creamos objeto de la interface, pero si de las clases que la implementan
            using(FileStream flujo = new FileStream(_fichero, FileMode.Append, FileAccess.Write))
            {
                formato.Serialize(flujo, p);
            }

            return true;
        }

        public void Listar()
        {
            if(!File.Exists(_fichero))
            {
                Console.WriteLine("No existe el fichero....");
                Console.ReadKey();
                return;
            }

            Persona tmp = null;
            using(FileStream flujo = new FileStream(_fichero, FileMode.Open, FileAccess.Read))
            {
                IFormatter formato = new BinaryFormatter();

                while(true)
                {
                    try
                    {
                        tmp = (Persona)formato.Deserialize(flujo);
                        //Compruebo que no este borrado

                        if(tmp.Borrado)
                            continue;
                        Console.WriteLine(tmp.ToString());
                    }
                    catch
                    {
                        break;
                    }
                }
            }
            Console.ReadKey();
        }

        public bool Borrar()
        {
            FileStream fs = new FileStream(_fichero, FileMode.Truncate);
            fs.Close();
            return true;
        }
    }
}
