using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            //BOY, KİLO, AYAKKABI NUMARASI VE CİNSİYET DEĞERLERİ DİZİLERLE GİRİLDİ.
            int[] boy = { 182, 156, 163, 172, 190, 170, 168, 180, 156, 171, 172, 193, 180, 168 };
            int[] kilo = { 80, 52, 59, 68, 92, 75, 78, 86, 60, 59, 68, 92, 75, 78 };
            int[] ayakNu = { 42, 36, 40, 41, 44, 41, 37, 43, 38, 39, 41, 46, 39, 34 };
            bool[] cinsiyet = { true, false, false, true, true, true, false, true, false, false, true, true, false, false };
            int[,] bay = new int[,] { { 182, 80, 42 }, { 172, 68, 41 }, { 190, 92, 44 }, { 170, 75, 41 }, { 180, 86, 43 }, { 172, 68, 41 }, { 193, 92, 46 } };
            int[,] bayan = new int[,] { { 156, 52, 36 }, { 163, 59, 40 }, { 168, 78, 37 }, { 156, 60, 38 }, { 171, 59, 39 }, { 180, 75, 39 }, { 168, 78, 34 } };

            bool cikis = false;
            while (cikis != true)
            {
                //ANA MENÜ YAZDIRILDI.
                Console.WriteLine("1. Max. Değer Hesaplama\n   1.1. Boy\n   1.2. Kilo\n   1.3. Ayakkabı Numarası\n\n2. Min. Değer Hesaplama\n   2.1. Boy\n   2.2. Kilo\n   2.3. Ayakkabı Numarası\n\n3. Ortalama Hesaplama\n   3.1. Boy\n   3.2. Kilo\n   3.3. Ayakkabı Numarası\n\n4. Büyükten Küçüğe Sıralama\n   4.1. Boy\n   4.2. Kilo\n   4.3. Ayakkabı Numarası\n\n5. Listele\n   5.1. Bay\n   5.2. Bayan\n\n6. Standart Sapma Hesaplama\n   6.1. Boy\n   6.2. Kilo\n   6.3. Ayakkabı Numarası\n\n7. Hareketli Ortalama Hesaplama\n   7.1. Boy\n   7.2. Kilo\n   7.3. Ayakkabı Numarası\n\n8. KNN\n\n9. ÇIKIŞ\n");
                int x = Convert.ToInt32(Console.ReadLine());
                //MAKSİMUM DEĞERLER HESAPLANDI.
                if (x == 1)
                {
                    Console.WriteLine("Max. Değer Hesaplama\n1. Boy\n2. Kilo\n3. Ayakkabı Numarası");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        int boymax = boy.Max();
                        Console.WriteLine("Max. Boy Değeri : " + boymax);
                    }
                    else if (y == 2)
                    {
                        int kilomax = kilo.Max();
                        Console.WriteLine("Max. Kilo Değeri : " + kilomax);
                    }
                    else if (y == 3)
                    {
                        int anumax = ayakNu.Max();
                        Console.WriteLine("Max. Boy Değeri : " + anumax);
                    }
                    else
                    {
                        Console.WriteLine("1 ile 3 arasında bir değer girniz.");
                    }
                }
                //MİNİMUM DEĞERLER HESAPLANDI.
                else if (x == 2)
                {
                    Console.WriteLine("Min. Değer Hesaplama\n1. Boy\n2. Kilo\n3. Ayakkabı Numarası");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        int boymin = boy.Min();
                        Console.WriteLine("Min. Boy Değeri : " + boymin);
                    }
                    else if (y == 2)
                    {
                        int kilomin = kilo.Min();
                        Console.WriteLine("Min. Kilo Değeri : " + kilomin);
                    }
                    else if (y == 3)
                    {
                        int anumin = ayakNu.Min();
                        Console.WriteLine("Min. Boy Değeri : " + anumin);
                    }
                    else
                    {
                        Console.WriteLine("1 ile 3 arasında bir değer girniz.");
                    }
                }
                //ORTALAMALAR HESAPLANDI.
                else if (x == 3)
                {
                    Console.WriteLine("Ortalama Hesaplama\n1. Boy\n2. Kilo\n3. Ayakkabı Numarası");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int toplam = 0;
                    if (y == 1)
                    {
                        for (int i = 0; i < boy.Length; i++)
                        {
                            toplam += boy[i];
                        }
                        Console.WriteLine("Boy Ortalaması : " + toplam / boy.Length);
                    }
                    else if (y == 2)
                    {
                        for (int i = 0; i < kilo.Length; i++)
                        {
                            toplam += kilo[i];
                        }
                        Console.WriteLine("Kilo Ortalaması : " + toplam / kilo.Length);
                    }
                    else if (y == 3)
                    {
                        for (int i = 0; i < ayakNu.Length; i++)
                        {
                            toplam += ayakNu[i];
                        }
                        Console.WriteLine("Ayakkabı Numarası Ortalaması : " + toplam / ayakNu.Length);
                    }
                    else
                    {
                        Console.WriteLine("1 ile 3 arasında bir değer girniz.");
                    }
                }
                //DEĞERLER BÜYÜKTEN KÜÇÜĞE DOĞRU SIRALANDI.
                else if (x == 4)
                {
                    Console.WriteLine("Büyükten Küçüğe Sıralama\n1. Boy\n2. Kilo\n3. Ayakkabı Numarası");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int gecici;
                    if (y == 1)
                    {
                        for (int i = 0; i < boy.Length; i++)
                        {
                            for (int t = 0; t < boy.Length; t++)
                            {
                                if (boy[t] < boy[i])
                                {

                                    gecici = boy[i];

                                    boy[i] = boy[t];

                                    boy[t] = gecici;

                                }
                            }
                        }
                        Console.WriteLine("Boy Değerlerinin Büyükten Küçüğe Sıralanması :");
                        foreach (int i in boy)
                        {

                            Console.WriteLine("{0}", i);

                        }
                    }
                    else if (y == 2)
                    {
                        for (int i = 0; i < kilo.Length; i++)
                        {
                            for (int t = 0; t < kilo.Length; t++)
                            {
                                if (kilo[t] < kilo[i])
                                {

                                    gecici = kilo[i];

                                    kilo[i] = kilo[t];

                                    kilo[t] = gecici;

                                }
                            }
                        }
                        Console.WriteLine("Kilo Değerlerinin Büyükten Küçüğe Sıralanması :");
                        foreach (int i in kilo)
                        {

                            Console.WriteLine("{0}", i);

                        }
                    }
                    else if (y == 3)
                    {
                        for (int i = 0; i < ayakNu.Length; i++)
                        {
                            for (int t = 0; t < ayakNu.Length; t++)
                            {
                                if (ayakNu[t] < ayakNu[i])
                                {

                                    gecici = ayakNu[i];

                                    ayakNu[i] = ayakNu[t];

                                    ayakNu[t] = gecici;

                                }
                            }
                        }
                        Console.WriteLine("Ayakkabı Numaralarının Büyükten Küçüğe Sıralanması :");
                        foreach (int i in ayakNu)
                        {

                            Console.WriteLine("{0}", i);

                        }
                    }
                    else
                    {
                        Console.WriteLine("1 ile 3 arasında bir değer girniz.");
                    }
                }
                //BAYANLAR VE BAYLAR LİSTELENDİ.
                else if (x == 5)
                {
                    Console.WriteLine("Listele\n1. Bayan\n2. Bay");
                    int y = Convert.ToInt32(Console.ReadLine());
                    int diziElemani = bay.Length;
                    if (y == 1)
                    {
                        Console.WriteLine("Bayanlar :\nBoy Kilo Ayakkabı Numarası\n--- ---  ------------------");
                        for (int i = 0; i < bayan.GetLength(0); i++)
                        {
                            for (int j = 0; j < bayan.GetLength(1); j++)
                            {
                                Console.Write("{0}  ", bayan[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else if (y == 2)
                    {
                        Console.WriteLine("Baylar :\nBoy Kilo Ayakkabı Numarası\n--- ---  ------------------");
                        for (int i = 0; i < bay.GetLength(0); i++)
                        {
                            for (int j = 0; j < bay.GetLength(1); j++)
                            {
                                Console.Write("{0}  ", bay[i, j]);
                            }
                            Console.WriteLine();
                        }
                    }
                    else
                    {
                        Console.WriteLine("1 ile 2 arasında bir değer girniz.");
                    }
                }
                //DEĞERLERİN STANDART SAPMALARI HESAPLANDI.
                else if (x == 6)
                {
                    Console.WriteLine("Standart Sapma Hesaplama\n1. Boy\n2. Kilo\n3. Ayakkabı Numarası");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        double toplam = 0;
                        for (int i = 0; i < boy.Length; i++)
                        {
                            toplam += boy[i];
                        }
                        double ort = toplam / 14;
                        double kareleri = 0;
                        for (int i = 0; i < boy.Length; i++)
                        {
                            kareleri += Math.Pow((boy[i] - ort), 2);
                        }
                        Console.Write("Boy Değerlerinin Standart Sapması : ");
                        Console.WriteLine(Math.Sqrt(kareleri / (boy.Length - 1)));
                    }
                    else if (y == 2)
                    {
                        double toplam = 0;
                        for (int i = 0; i < kilo.Length; i++)
                        {
                            toplam += kilo[i];
                        }
                        double ort = toplam / 14;
                        double kareleri = 0;
                        for (int i = 0; i < kilo.Length; i++)
                        {
                            kareleri += Math.Pow((kilo[i] - ort), 2);
                        }
                        Console.Write("Kilo Değerlerinin Standart Sapması : ");
                        Console.WriteLine(Math.Sqrt(kareleri / (kilo.Length - 1)));
                    }
                    else if (y == 3)
                    {
                        double toplam = 0;
                        for (int i = 0; i < ayakNu.Length; i++)
                        {
                            toplam += ayakNu[i];
                        }
                        double ort = toplam / 14;
                        double kareleri = 0;
                        for (int i = 0; i < ayakNu.Length; i++)
                        {
                            kareleri += Math.Pow((ayakNu[i] - ort), 2);
                        }
                        Console.Write("Ayakkabı Numaralarının Standart Sapması : ");
                        Console.WriteLine(Math.Sqrt(kareleri / (ayakNu.Length - 1)));
                    }
                    else
                    {
                        Console.WriteLine("1 ile 3 arasında bir değer girniz.");
                    }
                }
                //DEĞERLERİN HREKETLİ ORTALAMALARI HESAPLANDI.
                else if (x == 7)
                {
                    Console.WriteLine("Hareketli Ortalama Hesaplama\n1. Boy\n2. Kilo\n3. Ayakkabı Numarası");
                    int y = Convert.ToInt32(Console.ReadLine());
                    if (y == 1)
                    {
                        int toplam = 0;
                        for (int i = 0; i <= 7; i++)
                        {
                            toplam = 0;
                            for (int j = i; j < 7 + i; j++)
                            {
                                toplam += boy[j];
                            }
                            Console.WriteLine(toplam / 7);
                        }
                    }
                    else if (y == 2)
                    {
                        int toplam = 0;
                        for (int i = 0; i <= 7; i++)
                        {
                            toplam = 0;
                            for (int j = i; j < 7 + i; j++)
                            {
                                toplam += kilo[j];
                            }
                            Console.WriteLine(toplam / 7);
                        }
                    }
                    else if (y == 3)
                    {
                        int toplam = 0;
                        for (int i = 0; i <= 7; i++)
                        {
                            toplam = 0;
                            for (int j = i; j < 7 + i; j++)
                            {
                                toplam += ayakNu[j];
                            }
                            Console.WriteLine(toplam / 7);
                        }
                    }
                    else
                    {
                        Console.WriteLine("1 ile 3 arasında bir değer girniz.");
                    }
                }
                //ÖKLİD UZAKLIĞI VE KNN HESAPLANDI.
                else if (x == 8)
                {
                    Console.WriteLine("KNN ve ÖKLİD UZAKLIĞI HESAPLAMA\n-------------------------------");
                    Console.WriteLine("Yeni bir boy değeri giriniz : ");
                    int yeniB = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yeni bir kilo değeri giriniz : ");
                    int yeniK = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yeni bir ayakkabı numarası giriniz : ");
                    int yeniAN = Convert.ToInt32(Console.ReadLine());
                    
                        double bKaresi = 0, kKaresi = 0, anKaresi = 0;

                    bKaresi = Math.Pow(boy[0]-yeniB,2);
                    kKaresi = Math.Pow(kilo[0]-yeniK,2);
                    anKaresi = Math.Pow(ayakNu[0]-yeniAN,2);

                    double min = Math.Sqrt((double)(bKaresi+kKaresi+anKaresi));
                    bool cins = cinsiyet[0];
                    for (int i = 0; i < boy.Length; i++)
                    {
                        bKaresi = Math.Pow(boy[i] - yeniB, 2);
                        kKaresi = Math.Pow(kilo[i] - yeniK, 2);
                        anKaresi = Math.Pow(ayakNu[i] - yeniAN, 2);

                        double minO = Math.Sqrt((double)(bKaresi + kKaresi + anKaresi));

                        if(minO<min)
                        {
                            min = minO;
                            cins = cinsiyet[i];
                        }
                    }
                    Console.WriteLine("Cinsiyet : "+ ((cins == true)?"Bay":"Bayan"));

                }
                //ÇIKIŞ YAPILDI.
                else if (x == 9)
                {
                    cikis = true; return;
                }
                else
                {
                    Console.WriteLine("1 ile 9 arasında bir değer giriniz.");
                }
                //PROGRAMDAN ÇIKIŞ YAPILMAK İSTENİLİYOR MU DİYE SORULDU.
                Console.Write("\n\nAna Menüye Dönmek İçin 'e'ye basın.\nProgramdan Çıkmak İçin Başka Bir Tuşa Basın.");
                char rtm = Convert.ToChar(Console.ReadLine());
                if (rtm == 'e' || rtm == 'E')
                {
                    cikis = false;
                }
                else
                {
                    cikis = true;
                }
            }
            }
    }
}