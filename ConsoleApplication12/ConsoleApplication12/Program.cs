using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication12
{
    class Program
    {
        static void Main(string[] args)
        {
            //Ev d1 = new Ev();
            //d1.kisiEkle(new Kisi("Jankat", "Örüm"));
            Ev h1 = new Ev();
            Console.WriteLine("isim gir");
            h1.adi = Console.ReadLine();
            
        }
    }
}
