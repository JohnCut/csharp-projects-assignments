using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication14
{
    class Borc
    {
        //Borç sınıfı özellikleri tanımlandı.
        public Kisi ad;
        public string _kime;
        public double _miktar;

        //Borç sınıfı kurucu metodu.
        public Borc(string kime, double miktar)
        {
            _kime = kime;
            _miktar = miktar;
        }
    }
}
