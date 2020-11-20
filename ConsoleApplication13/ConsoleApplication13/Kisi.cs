using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication13
{
    class Kisi
    {
        public string adi;
        public string soyadi;
        public Kisi() { }
        public Kisi(string adi, string soyadi)
        {
            this.adi = adi;
            this.soyadi = soyadi;
        }
        public void yazdir()
        {
            
            Console.WriteLine("Kişi adı:{0}, soyadı:{1}", adi, soyadi);
        }
    }
}
