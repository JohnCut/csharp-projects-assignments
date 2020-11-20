using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication13
{
    class Ev:Kisi
    {
        
        List<Kisi> kisiler = new List<Kisi>();

        public void kisiEkle(Kisi k)
        {
            kisiler.Add(k);
        }
        public void kisiSil(Kisi k)
        {
            kisiler.Remove(k);
        }
        public void yazdir() /*DÜZELT*/
        {
            
            foreach (var kisi in kisiler)
            {
                Console.WriteLine("Kişi adı:{0}, soyadı:{1}", adi, soyadi);
            }
        }
        
    }
}
