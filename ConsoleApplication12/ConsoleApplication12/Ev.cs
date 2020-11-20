using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication12
{
    class Ev
    {
        public string adi;
        public string soyadi;
        public Ev() { }
        public Ev(string adi, string soyadi)
        {
            this.adi = adi;
            this.soyadi = soyadi;
        }
        List<Kisi> kisiler = new List<Kisi>();
        public void kisiEkle(Kisi k)
        {
            kisiler.Add(k);

        }

    }
}
