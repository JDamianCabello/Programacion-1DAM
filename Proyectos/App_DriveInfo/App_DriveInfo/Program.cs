using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_DriveInfo
{
    class Program
    {
        static void Main(string[] args)
        {
            DriveInfo[] unidades = DriveInfo.GetDrives();

            foreach(var item in unidades)
            {
                Console.WriteLine("             Unidad:{0}", item.Name);
                Console.WriteLine("     Tipo de unidad:{0}", item.DriveType);


                if(item.IsReady)//Comprobamos que la unidad esta lista (está montada).
                {
                    Console.WriteLine(" Volumen de la unidad: {0}",item.VolumeLabel);
                    Console.WriteLine("  Sistema de archivos: {0}",item.DriveFormat);
                    Console.WriteLine("   Espacio disponible: {0}", item.AvailableFreeSpace);
                    Console.WriteLine("        Espacio libre: {0}", item.TotalFreeSpace);
                    Console.WriteLine("  Tamaño de la unidad: {0}", item.TotalSize);
                }
            }
            Console.ReadKey();
        }
    }
}
