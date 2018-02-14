using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejer1
{
    public enum TipoMarco { Simple };

    public class Marco
    {
        uint _altoMax = (uint)Console.WindowHeight - 1;
        uint _largoMax = (uint)Console.WindowWidth - 2;
        public Marco(TipoMarco unTipoMarco)
        {
            switch(unTipoMarco)
            {
                case TipoMarco.Simple:
                    TSimple();
                    break;
                default:
                    break;
            }
        }

        private void TSimple()
        {
            PintaCabeza(1,3,'-', '+', '|');
            PintaCabeza(1, 15, '-', '+', '|');
        }

        private void PintaCabeza(int inicio, int fin, char horizontal, char esquinas, char vertical)
        {
            for(int i = 0; i < fin; i++)
            {
                Console.CursorLeft = inicio;
                for(int j = 0; j < _largoMax; j++)
                {
                    if(i == 0 && j == 0 || i == 0 && j == _largoMax - 1 || i == 2 && j == 0 || i == 2 && j == _largoMax - 1)
                        Console.Write(esquinas);
                    else if((i == 1 && j == 0) || (i== 1 && j == _largoMax - 1))
                        Console.Write(vertical);
                    else if (i== 0 || i == 2)
                        Console.Write(horizontal);
                    else
                        Console.Write(" ");
                }
                Console.Write("\n");Exception
            }
        }
    }
}
