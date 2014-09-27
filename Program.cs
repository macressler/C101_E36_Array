using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] C101Array;
            C101Array = new int[10];

            for (int x = 0; x < 10; x++)
            {
                C101Array[x] = x + 1;             //Filling up Array with the values
                Console.WriteLine(C101Array[x]);  //Printing out the values of Array
            }

            Console.Read();
        }
    }
}
