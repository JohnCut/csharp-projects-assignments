//CANKAT ÖRÜM 15220024
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW2VY15220024
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int vertexNu = Convert.ToInt32(Console.ReadLine()); //Düğüm sayısı

            Queue vertexQue = new Queue(); //Düğümlerin tutulduğu kuyruk
            for (int i = 1; i <= vertexNu; i++) //Düğümler girilir ve kuyruğa aktarılır.
            {
                Console.WriteLine("{0}. düğümü giriniz.", i);
                string vertexStr = Console.ReadLine();
                vertexQue.Enqueue(vertexStr);
            }

            string vertexRe; //Düğüm kuyruğundaki her bir düğüm
            int j = 0; //sayaç
            Queue edges = new Queue(); //Kenarların(1'lerin) tutulduğu kuyruk 
            for (int q = 0; q < vertexQue.Count; q++) //Kenarlar(1'ler) belirlenir ve kenar kuyruğuna atılır.
            {
                vertexRe = (string)vertexQue.Dequeue();
                foreach (char item in vertexRe)
                {
                    if (item.ToString() == "1")
                    {
                        edges.Enqueue(j);
                    }
                    j++;
                }
            }

            string edgesChar; //Kenar kuyruğundaki her bir kenar
            for (int e = 0; e < edges.Count; e++) //Komşuluk listesi oluşturulur.
            {
                if (e % 2 == 0)
                {
                    Console.WriteLine();
                }
                edgesChar = (string)edges.Dequeue();
                Console.Write("{0} | {1} ,", e, edgesChar);
            }
        }
    }
}
