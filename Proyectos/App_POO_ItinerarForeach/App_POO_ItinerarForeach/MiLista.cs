using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//---------------------------
using System.Collections; //Necesario para las interfaces

namespace App_POO_ItinerarForeach
{
    class MiLista: IEnumerator, IEnumerable
    {
        int[] numeros = { 1, 3, 5, 99, 110, 4, 7 };
        int posicion = -1;

        public object Current
        {
            //Devuelve el elemento de la posicion actual
            get { return numeros[posicion]; }
        }

        public bool MoveNext()
        {
            /* Desplaza el índice al siguiente valor
             * Devuelve: true, si se avanzó con éxito
             *           false, si se alcanzó el final de la colección
             * 
             */

            if(posicion < numeros.Length - 1)
            {
                posicion++;
                return true;
            }
            else
            {
                Reset();
                return false;
            }
        }

        public void Reset()
        {
            posicion = -1;
        }

        public IEnumerator GetEnumerator()
        {
            //Necesita devolver un IEnumerator, pues se devuelve a ella misma. Al implementar de IEnumerator se convierte en uno.
            return this;
        }
    }
}
