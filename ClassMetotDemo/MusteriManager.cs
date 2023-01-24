using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Tebrikler Kaydınız Oluşturuldu:  " + musteri.MusteriAdi + "  " + musteri.MusteriSoyadi);

        }

        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriID+ " " + musteri.MusteriAdi + "  " + musteri.MusteriSoyadi + "  " + musteri.MusteriTelNo + " " + musteri.MusteriKimlikNo );

        }

        public void Silme(Musteri musteri) 
        {
            Console.WriteLine("Kaydınız Silindi: " + musteri.MusteriAdi+ " " + musteri.MusteriSoyadi);
        
        }





    }
}

