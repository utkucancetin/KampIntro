using System;

namespace KampIntro
{
    class Prgram
    {
        static void Main(string[] args)
        {

            Urun urun1 = new Urun();
            urun1.urunID = 1;
            urun1.urunAdi = "Cep Telefonu";
            urun1.urunFiyati = 15000;
            urun1.goruntulenmeSayisi = 1564;


            Urun urun2 = new Urun();
            urun2.urunID = 2;
            urun2.urunAdi = "Bilgisyar";
            urun2.urunFiyati = 24200;
            urun2.goruntulenmeSayisi = 2132;


            Urun urun3 = new Urun();
            urun3.urunID = 3;
            urun3.urunAdi = "Tablet";
            urun3.urunFiyati = 12670;
            urun3.goruntulenmeSayisi = 953;

            //Console.WriteLine(urun1.urunAdi +":"+ urun1.urunFiyati);

            Urun[] urunler = new Urun[] { urun1, urun2, urun3 };


            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine(urunler[i].urunID+" - "+urunler[i].urunAdi + " : " + urunler[i].urunFiyati + " : " + urunler[i].goruntulenmeSayisi);
            }

            Console.WriteLine("---FOR BİTTİ---");

            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.urunID+" - "+ urun.urunAdi + " : " + urun.urunFiyati + " : " + urun.goruntulenmeSayisi);
            }

            Console.WriteLine("---FOREACH BİTTİ---");
            
            int a = 0;  
            while (a < urunler.Length)
            {
                Console.WriteLine(urunler[a].urunID+ " : " + urunler[a].urunAdi+ " + " +urunler[a].urunFiyati+ " : " + urunler[a].goruntulenmeSayisi );
                a++;    
            }
            Console.WriteLine("---WHILE BİTTİ---");

        }
    }

    class Urun
    {
        public int urunID { get; set; }
        public string urunAdi { get; set; }
        public int urunFiyati { get; set; }
        public int goruntulenmeSayisi { get; set; }
    }

}




