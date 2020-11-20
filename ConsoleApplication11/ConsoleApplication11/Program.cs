using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication11
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi = Convert.ToInt32(Console.ReadLine());
 
            for (int i = 2; i <= sayi; i++)
            {
 
                int kalan = sayi % i;
 
                if (kalan == 0)
                {
 
                    Console.WriteLine(sayi+" sayısı asal değildir");
 
                    break;
 
                }
 
                if (i == sayi - 1)
                {
 
                    Console.WriteLine(sayi+" sayısı asaldır");
 
                    break;
 
                }
 
            }
 
        }
    }
}
