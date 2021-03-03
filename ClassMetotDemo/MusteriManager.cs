using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Müşteri eklendi :" + musteri.Adi);
        }
        public void Cikar(Musteri musteri)
        {
            Console.WriteLine("Müşteri çıkarıldı :" + musteri.Adi);
        }
        public void Listele(Musteri musteri)
        {
            
            Console.WriteLine("Id :" + musteri.Id + "    Müşteri Adı   :" + musteri.Adi);
            
        }
    }
}
