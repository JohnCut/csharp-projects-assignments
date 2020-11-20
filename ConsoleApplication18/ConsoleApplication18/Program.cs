using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication18
{
    class Program
    {
        static void Main(string[] args)
        {
            string vert = "000101";
            int j = 0;

            foreach (char item in vert)
            {
                if (item.ToString() == "1")
                {
                    Console.WriteLine(j);
                }
                j++;
            }
        }
    }
}
