using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + "adlı müşteri sisteme başarıyla eklendi !\n");
        }

        public void Sil(Musteri musteri)
        {
            Console.WriteLine(musteri.Adi + " " + "adlı müşteri sistemden başarıyla silindi !\n");
        }
        
        public void Listele(Musteri[] musteriler)
        {
            foreach (Musteri musteri in musteriler)
            {
                Console.WriteLine("\n-----Müşteri Bilgisi-----\n");

                Console.WriteLine("Müşteri adı = " + musteri.Adi);
                Console.WriteLine("Müşteri TC'si = " + musteri.Tc);
                Console.WriteLine("Müşteri cinsiyeti = " + musteri.Cinsiyeti);
                Console.WriteLine("Müşteri yaşı = " + musteri.Yasi);
            }
        }
    }
}
