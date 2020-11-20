using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication14
{
    class Harcama
    {
        //Harcama sınıfı özellikleri tanımlandı.
        public Kisi adi;
        public string _harcayan;
        public double _miktar;
        public DateTime _zaman;

        //Harcama sınıfı kurucu metodu.
        public Harcama(string harcayan, double miktar, DateTime zaman)
        {
            _harcayan = harcayan;
            _miktar = miktar;
            _zaman = zaman;
        }
    }
}
