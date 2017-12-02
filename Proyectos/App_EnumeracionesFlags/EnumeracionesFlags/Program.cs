using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeracionesFlags
{
    class Program
    {
        [Flags]
        public enum ValoresBits : uint
        {
            noBit = 0x0,
            bit1 = 0x1,
            bit2 = 0x2,
            bit3 = 0x4,
            bit4 = 0x8,
            bit5 = 0x10,
            todos = 0xFFFFFFFF
        };

        static void Main(string[] args)
        {
            ValoresBits unBit = ValoresBits.bit1;
            ValoresBits resultado = ValoresBits.bit1 | ValoresBits.bit3; //Es un OR binario.
            Console.WriteLine(@"[Flags]
        public enum ValoresBits : uint
        {
            noBit = 0x0,
            bit1 = 0x1,
            bit2 = 0x2,
            bit3 = 0x4,
            bit4 = 0x8,
            bit5 = 0x10,
            todos = 0xFFFFFFFF
        };");


            Console.WriteLine("Bit1 -> {0:X}",unBit);
            Console.WriteLine("Bit3 -> {0:X}", ValoresBits.bit3);
            Console.WriteLine("Bit1 | bit 3 -> {0:X}", resultado);
            Console.WriteLine("Bit1 | bit 3 -> {0}", (ValoresBits)resultado);

        }
    }
}
