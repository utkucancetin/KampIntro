using System;
using System.Text;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //string MusteriAdi = "Ahmet";

            //string MusteriSoyadi = "Yılmaaz";

            // double MusteriTelNo = 05325005050;

            //double MusteriKimlikNo = 1234567890;

            //string[] musteriler = new string[] { };

            Musteri musteri1 = new Musteri();
            musteri1.MusteriID = 1;
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Yılmaz";
            musteri1.MusteriTelNo = 05325005050;
            musteri1.MusteriKimlikNo = 1234567890;

            Musteri musteri2 = new Musteri();
            musteri2.MusteriID = 2;
            musteri2.MusteriAdi = "Furkan";
            musteri2.MusteriSoyadi = "Demir";
            musteri2.MusteriTelNo = 05425005050;
            musteri2.MusteriKimlikNo = 0123456789;

            Musteri musteri3 = new Musteri();
            musteri3.MusteriID = 3;
            musteri3.MusteriAdi = "Ali";
            musteri3.MusteriSoyadi = "Bayrak";
            musteri3.MusteriTelNo = 05425005050;
            musteri3.MusteriKimlikNo = 0123456789;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3 };

            foreach (Musteri m in musteriler)
            {
                Console.WriteLine(m.MusteriID);
                Console.WriteLine(m.MusteriAdi);
                Console.WriteLine(m.MusteriSoyadi);
                Console.WriteLine(m.MusteriTelNo);
                Console.WriteLine(m.MusteriKimlikNo);
                Console.WriteLine("---------------------");


            }

            MusteriManager MusteriManager = new MusteriManager();
            MusteriManager.Ekle(musteri1);
            MusteriManager.Ekle(musteri2);
            MusteriManager.Ekle(musteri3);

            Console.WriteLine("---------------------");


            MusteriManager.Listele(musteri1);
            MusteriManager.Listele(musteri2);
            MusteriManager.Listele(musteri3);

            Console.WriteLine("---------------------");


            MusteriManager.Silme(musteri1);
            MusteriManager.Silme(musteri2);
            MusteriManager.Silme(musteri3);


        }


    }
}
