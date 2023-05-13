using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ucak_rezervasyon_programi;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime Tarihsaat1 = new DateTime(2023, 06, 23, 11, 00, 0);
            DateTime Tarihsaat2 = new DateTime(2023, 06, 24, 11, 30, 0);
            DateTime TarihSaat3 = new DateTime(2023, 06, 25, 12, 00, 0);
            DateTime Tarihsaat4 = new DateTime(2023, 06, 26, 13, 00, 0);

            UcakBilgileri ucak = new UcakBilgileri();
            ucak.kadinYolcusayisi = 18;
            ucak.erkekYolcusayisi = 20;
            ucak.yolcuKapasitesi = 50;
            ucak.ucakrengi = "siyah";
            ucak.seriNo = 2425255252555;


            LokasyonBilgileri ulke = new LokasyonBilgileri();
            Console.WriteLine("Nereye Gitmek İstiyorsunuz ?");
            ulke.ulke = Console.ReadLine();
            Console.WriteLine("Hangi Sehire Gitmek Istıyorsunuz ?");
            ulke.sehir = Console.ReadLine();
            Console.WriteLine("Hangi Havaalanina Gitmek Istıyorsunuz ?");
            ulke.havaalani = Console.ReadLine();

            MusteriBilgileri musteriler = new MusteriBilgileri();
            Console.WriteLine("Hangi Sinifi Tercih Ediyorsunuz ?");
            musteriler.tercihEdilenSinif = Console.ReadLine();

            RezervasyonBilgileri koltuk = new RezervasyonBilgileri();
            Console.WriteLine("Koltuk Numaranızı Ogrenebilir miyim ?");
            koltuk.koltukNo = Console.ReadLine();
            Console.WriteLine("Hangi Tarihte Ucacaksiniz ?");
            koltuk.tarihsaat = Console.ReadLine();
            Console.WriteLine("Ucus Bilgileriniz:" + ulke.ulke + " / " + ulke.sehir + " / " + ulke.havaalani + "" + musteriler.tercihEdilenSinif + " " + koltuk.koltukNo+ " " + koltuk.tarihsaat);
        }
    }
}

              
                
                



                

            
    


    



