using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
                musteri1.Adı = "Nazmi Can";
                musteri1.Soyadı = "Baş";
                musteri1.Id = 1907;
                musteri1.HesapNo = 19072002;  
            
            Musteri musteri2 = new Musteri();
                musteri2.Adı = "Ömer";
                musteri2.Soyadı = "kubal";
                musteri2.Id = 78201;
                musteri2.HesapNo = 965474;

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };

            MusteriManager musteriManager = new MusteriManager();

            Console.WriteLine("Müşteri ekleme");
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);

            Console.WriteLine("Müşteri Silme");
            musteriManager.MusteriSil(musteri1);
            musteriManager.MusteriSil(musteri2);

            Console.WriteLine("Listeleme");
            musteriManager.listeleme(musteri1);
            musteriManager.listeleme(musteri2);





        }

        
    }
}
