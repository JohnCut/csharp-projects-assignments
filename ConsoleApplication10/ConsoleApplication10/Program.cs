using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            method1();
            //Console.WriteLine(ikikati(5));
            //Console.WriteLine(topla(5,12));
            //Console.WriteLine(faktoriyel(6));
            //Console.WriteLine(fonk(8));
            //Console.WriteLine(ortalama(4,5,7));
            //Console.WriteLine(sonharf("nurgul"));
            int[] dizi12 = { 5, 2, 4, 9, 6 };
            Console.WriteLine(ortdizi(dizi12));
        }

        static void method1()
        {
            Console.WriteLine("method 1");
        }

        static void write(int a)
        {
            Console.WriteLine(a);
        }

        static int bes()
        {
            return 5;
        }

        static int ikikati(int a)
        {
            return a * 2;
        }

        static int topla(int a, int b)
        {
            return a + b;
        }

        static int faktoriyel(int a)
        {
            int fak = 1;
            for (int i = 1; i <= a; i++)
            {
                fak *= i;
            }
            return fak;
        }

        static int fonk(int a)
        {
            if (a % 2 == 0)
                return a * a;
            else
                return faktoriyel(a);
        }


        static float ortalama(int a, int b, int c)
        {
            return (a + b + c) / 3f;
        }


        static char ilkharf(string kelime)
        {
            return kelime[0];
        }

        static char sonharf(string kelime)
        {
            return kelime[kelime.Length - 1];
        }


        static double ortdizi(int[] dizi)
        {
            int top = 0;
            for (int i = 0; i < dizi.Length; i++)
            {
                top += dizi[i];
            }
            double ort = (double)top / dizi.Length;

            return ort;
        }
    }
}