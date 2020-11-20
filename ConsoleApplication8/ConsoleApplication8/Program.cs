using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication8
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {

                //loop for 40 stars
                for (int j = 0; j < 40; j++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();

                //loop for spaces
                for (int l = 0; l <= i; l++)
                {
                    Console.Write("  ");//two space
                }
            }
        }
    }
}
