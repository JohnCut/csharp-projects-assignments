using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication13
{
    class Program
    {
        static void Main(string[] args)
        {
            //Kisi e1 = new Kisi("Masa", "150.0");
            //Kisi e2 = new Kisi("Hoca Koltuğu", "200");
            //Kisi e3 = new Kisi("Bilgisayar", "4500");

            //Ev d1 = new Ev("Lab 1");
            //d1.esyaEkle(e1);
            //d1.esyaEkle(e2);
            //d1.esyaEkle(e3);
            //d1.esyaEkle(new Kisi("LG Televizyon", "2800"));
            //d1.yazdir();

            bool cikis = false;
            while (cikis != true)

            {
                Ev d1 = new Ev();
                Kisi h1 = new Kisi();
                Console.WriteLine("isim gir");
                h1.adi = Console.ReadLine();
                Console.WriteLine("soyisim gir");
                h1.soyadi = Console.ReadLine();
                d1.kisiEkle(h1);
                d1.yazdir();
                
            }
            cikis = false;
        }
    }
}
