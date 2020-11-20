using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication11
{
    class Program
    {
        public static Queue<string> TersCevir(Queue<string> kuyruk)
        {
            Stack<string> stk = new Stack<string>();

            int a = kuyruk.Count;
            //Bir Stack tanımlanır.
            for (int i = 0; i < a; i++)
            {

                stk.Push(kuyruk.Dequeue());
                //Kuyruk Stack'e eklenir.
            }


            for (int i = 0; i < a; i++)
            {

                kuyruk.Enqueue(stk.Pop());
                //Tekrar geri çevrilir.
            }

            return kuyruk;
            //Fonksiyon geri çevrilir.
        }

        static void Main(string[] args)
        {

            Queue<string> que = new Queue<string>(4);
            que.Enqueue("İlkbahar");
            que.Enqueue("Yaz");
            que.Enqueue("Sonbahar");
            que.Enqueue("Kış");
            //Queue tanımlanır.
            que = TersCevir(que);
            //Metod çağrılır.
            foreach (string item in que)
            {

                Console.WriteLine(item);
                //Ekrana yazdırılır.
            }
        }
    }
}

