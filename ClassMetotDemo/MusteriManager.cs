using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi +"isimli" + musteri.Soyadi +"Soyadi" + musteri.Id + "İd");
        }

        public void Sil (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + "isimli" + musteri.Soyadi + "Soyadi" + musteri.Id + "İd");
        }

        public void Listele (Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + "isimli" + musteri.Soyadi + "Soyadi" + musteri.Id + "İd");
        }

    }
}
