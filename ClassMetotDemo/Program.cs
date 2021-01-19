using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Adi = "Ahmet";
            musteri1.Tc = "11111111111";
            musteri1.Cinsiyeti = "Erkek";
            musteri1.Yasi = 28;

            Musteri musteri2 = new Musteri();
            musteri2.Adi = "Ayşe";
            musteri2.Tc = "22222222222";
            musteri2.Cinsiyeti = "Kadın";
            musteri2.Yasi = 35;

            Musteri musteri3 = new Musteri();
            musteri3.Adi = "Ceren";
            musteri3.Tc = "33333333333";
            musteri3.Cinsiyeti = "Kadın";
            musteri3.Yasi = 42;

            Musteri musteri4 = new Musteri();
            musteri4.Adi = "Mehmet";
            musteri4.Tc = "44444444444";
            musteri4.Cinsiyeti = "Erkek";
            musteri4.Yasi = 32;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Sil(musteri2);
            musteriManager.Listele(musteriler);


        }
    }
}
