using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace App_txtBinarios
{
    class Program
    {
        static void Main(string[] args)
        {
            Escribe();
            Lee();
            Console.ReadKey();
        }

        static void Lee()
        {
            string ruta = @"c:/basura/txtBinario.txt";

            FileStream fs = new FileStream(ruta, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fs);

            Console.WriteLine(br.ReadString());
            Console.WriteLine(br.ReadInt32());
            Console.WriteLine(br.ReadDouble());

            fs.Dispose();
        }

        static void Escribe()
        {
            string ruta = @"c:/basura/txtBinario.txt";
            string texto = "Tengo sueño!";
            int entero = 14;
            double doble = Math.PI;


            FileStream fs = new FileStream(ruta, FileMode.OpenOrCreate, FileAccess.Write);

            BinaryWriter bw = new BinaryWriter(fs);

            bw.Write(texto);
            bw.Write(entero);
            bw.Write(doble);

            fs.Close();

            if(bw != null)
                bw.Close();
        }
    }
}
