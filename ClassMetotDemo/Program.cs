using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri(); //Class’ın değişkenini ayarlamak için yapacağın hareket bu.
            musteri1.Id = 1;
            musteri1.Adi = "Engin";
            musteri1.Soyadi = "Demirog";

            Musteri musteri2 = new Musteri(); //Class’ın değişkenini ayarlamak için yapacağın hareket bu.
            musteri2.Id = 2;
            musteri2.Adi = "Gorkem ";
            musteri2.Soyadi = "Arısoy";

            Musteri musteri3 = new Musteri(); //Class’ın değişkenini ayarlamak için yapacağın hareket bu.
            musteri3.Id = 3;
            musteri3.Adi = "Selin";
            musteri3.Soyadi = "Muradov";

            Musteri musteri4 = new Musteri(); //Class’ın değişkenini ayarlamak için yapacağın hareket bu.
            musteri4.Id = 4;
            musteri4.Adi = "Çağrı";
            musteri4.Soyadi = "Arısoy";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2, musteri3, musteri4 };

            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);
            musteriManager.Ekle(musteri3);
            musteriManager.Ekle(musteri4);

            musteriManager.Cikar(musteri2);

            for (int i = 0; i < musteriler.Length; i++)
            {
                musteriManager.Listele(musteriler[i]);
            }
            
            
        }
    }
}

//Projeniz şunu yapacak.

//    Bir bankada müşteri takibi yapmak istiyorsunuz.
//    Musteri isimli bir Class oluşturunuz. Müşteriye istediğiniz özellikleri ekleyiniz. (Id, Ad, Soyad....)
//MusteriManager sınıfı oluşturunuz. Musteri parametresi alarak Musteri ekleme, listeleme, silme gibi metotları simule ediniz.
