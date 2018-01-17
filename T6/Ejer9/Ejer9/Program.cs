using System;


namespace Ejer9
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] ccs = { "0958 2122 00 5759408964", "0958 2122 10 5759408964", "4847 1321 87 2041114031", "7427 3546 36 8167149541", "5840 4590 72 2880817296", "0840 4590 72 2880817296" };
            for (int i = 0; i < ccs.Length; i++)
            {
                if (ValidarCC(ccs[i]))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("El número de cuenta es válido.");
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("El número de cuenta no es válido.");
                }
                Console.ResetColor();
                Console.WriteLine("\n\n===================================\n\n");
            }
            Console.WriteLine("Pulsa una tecla para salir....");
            Console.ReadKey();
        }

            static bool ValidarCC(string cc)
        {
            string aux = cc.Replace(" ", "");
            if (aux.Length != 20)
                return false;
            int primerDC = PrimerCC(aux.Substring(0, 8));
            int segundoDC = SegundoCC(aux.Substring(10));

            Console.WriteLine("Número introducido: {0}\n",cc);
            Console.WriteLine("           ENTIDAD: {0}",aux.Substring(0,4));
            Console.WriteLine("          SUCURSAL: {0}", aux.Substring(4, 4));
            Console.WriteLine("    DIGITO CONTROL: {0}",aux.Substring(8,2));
            Console.WriteLine("         Nº CUENTA: {0}", aux.Substring(10));



            return primerDC == (int)char.GetNumericValue(aux[8]) && segundoDC == (int)char.GetNumericValue(aux[9]) ? true : false;


        }

        static int PrimerCC(string entidadMasSucursal)
        {
            int[] valores = { 4, 8, 5, 10, 9, 7, 3, 6 };
            int controlCC = 0;

            for (int i = 0; i < valores.Length; i++)
                controlCC += (int)char.GetNumericValue(entidadMasSucursal[i]) * valores[i];

            controlCC = 11 - (controlCC % 11);

            if (controlCC == 10)
                return 1;
            else if (controlCC == 11)
                return 0;
            else
                return controlCC;
        }

        static int SegundoCC(string nCuentaCorriente)
        {//                   5  7  5  9  4   0  8  9  6  4
            int[] valores = { 1, 2, 4, 8, 5, 10, 9, 7, 3, 6 };
            int controlCC = 0;

            for (int i = 0; i < valores.Length; i++)
                controlCC += (int)char.GetNumericValue(nCuentaCorriente[i]) * valores[i];

            controlCC = 11 - (controlCC % 11); //308

            if (controlCC == 10)
                return 1;
            else if (controlCC == 11)
                return 0;
            else
                return controlCC;
        }

    }
}
