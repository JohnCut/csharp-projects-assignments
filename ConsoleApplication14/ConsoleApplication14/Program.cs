//CANKAT ÖRÜM 15220024
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApplication14
    //CANKAT ÖRÜM 15220024
{
    class Program
    {
        static void Main(string[] args)
        {
            //List<T> yapıları oluşturuldu.
            List<Harcama> harcamalar = new List<Harcama>();
            List<Kisi> kisiler = new List<Kisi>();
            List<Borc> borclar = new List<Borc>();
            
            //İşlemler bitince ana menüye dönmek için kod.(devamı en altta(***))    
            bool cikis = false;
            while (cikis != true)
            {
                //Ana menü
                Console.WriteLine("Ev Harcamaları Takibi\n-----===========-----\n1) Kişi ekle\n2) Kişileri listele\n3) Harcama ekle\n4) Harcamaları listele\n5) Borçları hesapla\n6) Borçları yazdır\n7) Borç sıfırla\n8) Herşeyi sıfırla\n9) Çıkış\n-----===========-----");
                Console.Write("Seçiminiz: ");
                int x = Int32.Parse(Console.ReadLine());

              
                if (x == 1)     /*Kişi ekler.*/
                {
                    Console.Write("Adı: ");
                    string ad = Console.ReadLine();

                    Console.Write("Soyadı: ");
                    string soyad = (Console.ReadLine());

                    Kisi ksler = new Kisi(ad, soyad);
                    kisiler.Add(ksler);
                }
                else if (x == 2)        /*Kişi listesini görüntüler.*/
                {
                    foreach (var k in kisiler)
                    {
                        Console.WriteLine("Adı: {0}\nSoyadı: {1}", k.adi, k.soyadi);
                    }
                }
                else if (x == 3)       /* Harcama ekler.*/
                {
                    Console.Write("Harcama yapan kişi: ");
                    string harcayan = Console.ReadLine();

                    Console.Write("Harcama miktarı: ");
                    double miktar = Int32.Parse(Console.ReadLine());

                    DateTime zaman = DateTime.Now;

                    Harcama hrcma = new Harcama(harcayan, miktar, zaman);
                    harcamalar.Add(hrcma);
                }
                else if (x == 4)        /*Harcama listesini görüntüler.*/
                {
                    foreach (var h in harcamalar)
                    {
                        Console.WriteLine("Harcama yapan kişi: {0}\nHarcama miktarı: {1}\nHarcama zamanı: ", h._harcayan, h._miktar, h._zaman);
                    }
                }
                else if (x == 5)        /*Borçları hesaplar.*/
                {
                    double alacak = 0;      /*Alacak değişkeni tanımlandı.*/
                    double toplamBorc = borclar.ConvertAll(Convert.ToDouble).Sum();
                    double ortBorc = toplamBorc / borclar.Count;
                    for (double i = 0; i < borclar.Count; i++)
                    {
                        alacak = i + ortBorc;
                    }
                }
                else if (x == 6)        /*Borçları yazdırır.*/
                {
                    foreach (var b in borclar)
                    {
                        Console.WriteLine("Kime: {0}\nBorç Miktarı: {1}", b._kime, b._miktar);
                    }
                }
                else if (x == 7)        /*Borçlar listesini sıfırlar.*/
                {
                    borclar.Clear();
                }
                else if (x == 8)        /*Herşeyi sıfırlar.*/
                {
                    kisiler.Clear();
                    harcamalar.Clear();
                    borclar.Clear();
                }
                else if (x == 9)        /*Programdan çıkış yapar.*/
                {
                    Console.WriteLine("Ana Menüye Dönmek İçin 'e'ye basın.\nProgramdan Çıkmak İçin Başka Bir Tuşa Basın.");
                    char quit = Convert.ToChar(Console.ReadLine());
                    if (quit == 'e' || quit == 'E')
                    {
                        cikis = false;
                    }
                    else
                    {
                        cikis = true;
                    }
                }
                else
                {
                    Console.WriteLine("1 ile 9 arasında bir sayı giriniz.");
                }
            }
            cikis = false;      /* *** İşlemler bitince ana menüye geri döndüren kod*/
        }
    }
}
//CANKAT ÖRÜM 15220024