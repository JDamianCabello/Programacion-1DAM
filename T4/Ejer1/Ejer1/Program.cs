using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejer1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.CursorVisible = false;
            while(true)
            {
                for(int i = 23; i < 24; i--)
                    for(int j = 59; j < 60; j--)
                        for(int k = 59; k < 60; k--)
                        {
                            Console.SetCursorPosition(40, 10);
                            Console.WriteLine("{0:00}:{1:00}:{2:00}", i, j, k);
                            Thread.Sleep(1000);
                        } 
            }
        }
    }
}
