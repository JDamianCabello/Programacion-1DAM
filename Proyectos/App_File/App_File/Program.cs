using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_File
{
    class Program
    {
        static void Main(string[] args)
        {
            string ruta = @"..\..\..\..\_FicherosApps\txtApp_File.txt";
            string texto = "Esto esta copiado desde C#";
            char saltoLinea = '\n';


            for(int i = 0; i < 100; i++)
            {
                File.AppendAllText(ruta,texto+"_"+i.ToString("##0")+saltoLinea);
            }

            Console.WriteLine(File.ReadAllText(ruta));

            Console.ReadLine();
        }
    }
}
