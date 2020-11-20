//15220024 CANKAT ÖRÜM
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW1VY15220024
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cikis = false;
            while (cikis != true)
            {
                Postfix pf1 = new Postfix(); /*Postfix sınıfındaki Stack öğesine ulaşır.*/
                Console.WriteLine("Hesaplamak istediğiniz Postfix ifadeyi giriniz.");
                pf1.pfix = Console.ReadLine(); /*Postfix ifadesi girilir ve pfix değerine atar.*/
                pf1.islem(); /*islem metodu uygulanır.*/
                Console.WriteLine("İşleminizin sonucu = {0}", pf1.sonuc); /*Sonuç gösterilir.*/
                Console.WriteLine("Baştan başlamak için 'e'ye basın.\nProgramdan Çıkmak İçin Başka Bir Tuşa Basın."); /*Tekrar etme ya da çıkış sorgusu*/
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
        }
    }
}
