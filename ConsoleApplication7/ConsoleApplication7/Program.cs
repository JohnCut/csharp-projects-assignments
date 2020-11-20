using System;

namespace ConsoleApplication7
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
            //{
            bool cikis = false;
            
            //    for (int i = 0; i < 7; i++)
            //    {
            //        toplam += boy[i];
            //    }
            //    Console.WriteLine("Boy Ortalaması : " + toplam / 7);
            //}
            //for (int i = 0; i < boy.Length-7; i++)
            //{
            //    for (int j = 7; j < boy.Length; j++)
            //    {
            //        toplam = toplam + [i,j];
            //    }
            //    Console.WriteLine("Boy Ortalaması : " + toplam / 7);
            //for (int i = 0; i < 7; i++)
            //{

            //    for (int j = i; j < boy.Length; j++)
            //    {

            //        toplam += boy[j];
            //    }

            //    Console.WriteLine("Boy Ortalaması : " + toplam / 7);
            //    i++;
            //}
            //for (int i = 0; i < boy.Length; i++)
            //{

            //    for (int j = i; j < boy.Length-7; j++)
            //    {

            //        toplam = toplam + boy[j];

            //    }
            //    Console.WriteLine("Boy Ortalaması : " + toplam / 7);
            //}
            



                int toplam = 0 ;
            for (int i = 0; i < boy.Length-7; i++)
            {
                    for (int j = 7; j < boy.Length; j++)
                    {
                        for (int z = i; z < j; z++)
                        {
                        
                            toplam += boy[z];
                        for (int k = 0; k < z; k++)
                        {
                            Console.WriteLine("Boy Ortalaması : " + toplam / 7);
                        }
                        }
                        

                    
                }
 }
            }
            
        }

    }
            
        
    
