using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] boy = { 182, 156, 163, 172, 190, 170, 168, 180, 156, 171, 172, 193, 180, 168 };
            int[] kilo = { 80, 52, 59, 68, 92, 75, 78, 86, 60, 59, 68, 92, 75, 78 };
            int[] ayakNu = { 42, 36, 40, 41, 44, 41, 37, 43, 38, 39, 41, 46, 39, 34 };
            int[,] bay = new int[,] { { 182, 80, 42 }, { 172, 68, 41 }, { 190, 92, 44 }, { 170, 75, 41 }, { 180, 86, 43 }, { 172, 68, 41 }, { 193, 92, 46 } };
            int[,] bayan = new int[,] { { 156, 52, 36 }, { 163, 59, 40 }, { 168, 78, 37 }, { 156, 60, 38 }, { 171, 59, 39 }, { 180, 75, 39 }, { 168, 78, 34 } };

            Console.WriteLine("Yeni bir boy değeri giriniz : ");
            int yeniB = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni bir kilo değeri giriniz : ");
            int yeniK = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Yeni bir ayakkabı numarası giriniz : ");
            int yeniAN = Convert.ToInt32(Console.ReadLine());
            {
                double bKaresi = 0, kKaresi = 0, anKaresi = 0;
                for (int i = 0; i < boy.Length; i++)
                {
                    bKaresi += Math.Pow((boy[i] + yeniB), 2);
                }
                for (int i = 0; i < kilo.Length; i++)
                {
                    kKaresi += Math.Pow((kilo[i] - yeniK), 2);
                }
                for (int i = 0; i < boy.Length; i++)
                {
                    anKaresi += Math.Pow((ayakNu[i] - yeniAN), 2);
                }
                Console.Write("Öklid Uzaklığı : ");
                Console.WriteLine(Math.Sqrt(bKaresi+kKaresi+anKaresi));
            }
        }
    }
}
