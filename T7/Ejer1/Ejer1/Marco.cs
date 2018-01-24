using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    public enum TipoMarco { Simple };

    class Marco
    {
        public Marco(TipoMarco unTipoMarco, int largoMax, int anchoMax)
        {
            switch(unTipoMarco)
            {
                case TipoMarco.Simple:
                    TSimple(largoMax, anchoMax);
                    break;
                default:
                    break;
            }
        }

        private void TSimple(int largo, int ancho)
        {
            Console.WriteLine(largo);
            Console.WriteLine(ancho);
        }
    }
}
