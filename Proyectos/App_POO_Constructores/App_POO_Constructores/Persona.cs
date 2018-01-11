using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Damian.App_POO_Constructores
{
    class Persona
    {
        public static string quienSoy = "La clase persona to flama";

        #region camposDeLaClase

        // Campos: Se utilizan en las clases para almacenar el estado o los valores de la clase.
        public string _nombre;
        int _edad;
        string _nif;  

        #endregion 
      

        #region constructores

        public Persona()
        {
            _nombre = "EmptyName";
            _edad = 0;
            _nif = "00000000-A";
        }

        public Persona(string n, int e, string nif)
        {
            _nombre = n;
            _edad = e;
            _nif = nif;
        } 

        #endregion

        // Destructor de la clase
        ~Persona()
        {
            //Codigo adecuado
        }
    }
}
