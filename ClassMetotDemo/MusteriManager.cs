using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {

        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adı + " " + musteri.Soyadı + " " + musteri.Id + " " + musteri.HesapNo+"musteri eklendi.");
        }


        public void MusteriSil(Musteri musteri)
        {

            Console.WriteLine(musteri.Adı +" "+musteri.Soyadı +" "+musteri.Id+" "+musteri.HesapNo+ "Müşteri sistemden silinmiştir.");

        }

        public void listeleme(Musteri musteri)
        {
            Console.WriteLine(musteri.Adı + " " + musteri.Soyadı + " " + musteri.Id + " " + musteri.HesapNo);
        }
       
    }

}
