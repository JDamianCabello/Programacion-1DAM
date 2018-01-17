using System;

namespace Ejer8
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] eans = { "8001090189349", "12345678" };

            for (int i = 0; i < eans.Length; i++)
            {
                if (ValidarEAN(eans[i]))
                    Console.WriteLine("El EAN es válido");
                else
                    Console.WriteLine("El EAN es inválido");
                Console.WriteLine("\n\n==================================\n\n");
            }        

            Console.ReadLine();
        }

        static bool ValidarEAN(string ean)
        {
            uint sumaPares = 0;
            uint sumaImpares = 0;
            uint division = 0;
            uint digitoControl = 0;

            //Comprobamos si el EAN es de 8 o 13 ya que solo existen esos dos.
            if (ean.Length != 13 && ean.Length != 8)
                return false;

            //Sumamos los pares e impares por un lado (Aquí estan cambiados debido a que la primera posición en un string es 0, cuando debería ser 1).
            for (int i = 0; i < ean.Length - 1; i++)
                if (i % 2 == 0)
                    sumaImpares += (uint)Char.GetNumericValue(ean[i]);
                else
                    sumaPares += (uint)Char.GetNumericValue(ean[i]);

            //Si el EAN es de 13 dígitos se multiplican los pares por 3, si es de 8 dígitos son los impares los que se multiplican.
            if (ean.Length == 13)
                sumaPares *= 3;
            else
                sumaImpares *= 3;

            //Calculamos el resto de sumar pares e impares entre 10. 
            division = (sumaPares + sumaImpares) % 10;

            //A esa división le restamos 10 para obtener el dígito de control.
            digitoControl = 10 - division;

            //Sí el dígito de control es 10, lo cambiamos por 0, en caso contrário es su valor.
            digitoControl = digitoControl == 10 ? 0 : digitoControl;


            Console.Write("            Número EAN: {0}        Control: ",ean);
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write(ean[ean.Length - 1]+"\n");
            Console.ResetColor();
            Console.WriteLine("       Suma pares : {0}",sumaPares);
            Console.WriteLine("     Suma impares : {0}", sumaImpares);
            Console.WriteLine("Resultado división: {0}",division);
            Console.WriteLine("   Dígito control : {0}",digitoControl);

            //Devolvemos true o false si el ultimo dígito del EAN (el dígito de control) es igual al nuestro o no.
            return digitoControl == (int)Char.GetNumericValue(ean[ean.Length-1]) ? true : false;
            


        }

    }
}
