//15220024 CANKAT ÖRÜM
using System;
using System.Collections;   
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1VY15220024
{
    class Postfix
    {
        Stack yıgıt = new Stack(); /*Stack öğesi oluşturuldu.*/
        public string pfix; /*Stack'e atılacak postfix string değişkeni tanımlandı.*/
        public string sonuc; /*Sonuç değişkeni tanımlandı.*/

        public void islem()
        {
            var bosluksil = new string[] { " " }; /*Kullanıcı girişindeki postfix ifadedeki boşluklar kaldırıldı.*/
            foreach (var c in bosluksil)
            {
                pfix = pfix.Replace(c, string.Empty);
            }

            int fir, sec, snc; /*işleme ait değişkenler*/
            for (int i = 0; i < pfix.Length; i++) /*Postfix ifadesi for döngüsü ile okunuyor.*/
            {
                string cur = pfix.Substring(i, 1); /*Postfix ifadesinin i'inci değeri alınıyor.*/
                if (cur.Equals("*") || cur.Equals("x")) 
                {
                    string popf = (string)yıgıt.Pop(); /*İlk string çekilir.*/
                    string pops = (string)yıgıt.Pop(); /*İkinci string çekilir*/
                    fir = Convert.ToInt32(popf); /*İlk string, int'e çevrilir.*/
                    sec = Convert.ToInt32(pops); /*İkinci string, int'e çevrilir.*/
                    snc = fir * sec; /*İşlem yapılır.*/
                    yıgıt.Push(snc.ToString()); /*int halindeli sonuç, string'e çevrilerek Stack'e pushlanır.*/

                }
                else if (cur.Equals("/") || cur.Equals(":"))
                {
                    string popf = (string)yıgıt.Pop(); /*İlk string çekilir.*/
                    string pops = (string)yıgıt.Pop(); /*İkinci string çekilir*/
                    fir = Convert.ToInt32(popf); /*İlk string, int'e çevrilir.*/
                    sec = Convert.ToInt32(pops); /*İkinci string, int'e çevrilir.*/
                    snc = fir / sec; /*İşlem yapılır.*/
                    yıgıt.Push(snc.ToString()); /*int halindeli sonuç, string'e çevrilerek Stack'e pushlanır.*/
                }
                else if (cur.Equals("+"))
                {
                    string popf = (string)yıgıt.Pop(); /*İlk string çekilir.*/
                    string pops = (string)yıgıt.Pop(); /*İkinci string çekilir*/
                    fir = Convert.ToInt32(popf); /*İlk string, int'e çevrilir.*/
                    sec = Convert.ToInt32(pops); /*İkinci string, int'e çevrilir.*/
                    snc = fir + sec; /*İşlem yapılır.*/
                    yıgıt.Push(snc.ToString()); /*int halindeli sonuç, string'e çevrilerek Stack'e pushlanır.*/

                }
                else if (cur.Equals("-"))
                {
                    string popf = (string)yıgıt.Pop(); /*İlk string çekilir.*/
                    string pops = (string)yıgıt.Pop(); /*İkinci string çekilir*/
                    fir = Convert.ToInt32(popf); /*İlk string, int'e çevrilir.*/
                    sec = Convert.ToInt32(pops); /*İkinci string, int'e çevrilir.*/
                    snc = fir - sec; /*İşlem yapılır.*/
                    yıgıt.Push(snc.ToString()); /*int halindeli sonuç, string'e çevrilerek Stack'e pushlanır.*/

                }
                else
                {
                    yıgıt.Push(pfix.Substring(i, 1)); /*Rakam olan sayılar Stack'e pushlanır.*/
                }
            }
            sonuc = (string)yıgıt.Pop(); /*Sonuç Stack'e pushlanır.*/
        }
    }
}
