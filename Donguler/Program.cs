using System;

namespace KampIntro
{ 
    class Prgram 
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirme Kampı";
            string kurs2 = "Proglamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);   
            Console.WriteLine(kurs3);   
            Console.WriteLine(kurs4);   

            // array - dizi

            string[] kurslar = new string[] { "Yazılım Geliştirme Kampı", "Proglamaya başlangıç için temel kurs" , "Java" ,"Python","C#" };
           


            for (int i = 0; i <kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Bitti");
            
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);    
            }

            Console.WriteLine("sayfa sonu - footor");
        } 
    }
}

