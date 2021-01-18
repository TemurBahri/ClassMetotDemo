using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {


            MusteriManager musteriManager = new MusteriManager();
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Sultan";
            musteri1.Soyadi = "Özden";
            musteri1.Id = 25;


            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ceren";
            musteri2.Soyadi = "Tuncay";
            musteri2.Id = 50;



            Musteri[] musterileri = new Musteri[] { musteri1, musteri2 };

            Console.WriteLine("Müşteri Sistemi");
            Console.WriteLine("-----------------------------------------------------");

            foreach (Musteri musteri in musterileri)
            {

                Console.WriteLine(musteri.Adi);
                Console.WriteLine(musteri.Soyadi);
                Console.WriteLine(musteri.Id);

                Console.WriteLine("------------------");

            }

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            Console.WriteLine("Eklendii");


            musteriManager.Sil(musteri1);

            Console.WriteLine("Silindi");


            Console.WriteLine("Listelendii");

            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri1);

        }
    }
}
