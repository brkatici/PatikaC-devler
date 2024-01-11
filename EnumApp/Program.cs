using System;

class Program
{
    // Enum tanımı
    enum YemekTuru
    {
        Corba,
        AnaYemek,
        Salata,
        Tatli
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Hoş geldiniz! Lütfen sipariş veriniz:");

        // Kullanıcıdan bir yemek türü seçmesini iste
        Console.WriteLine("Yemek Türleri:");
        foreach (var tur in Enum.GetValues(typeof(YemekTuru)))
        {
            Console.WriteLine($"{(int)tur}. {tur}");
        }

        int secilenYemekTuruIndex;
        if (int.TryParse(Console.ReadLine(), out secilenYemekTuruIndex) && Enum.IsDefined(typeof(YemekTuru), secilenYemekTuruIndex))
        {
            // Enum değişkeni üzerinden seçilen yemek türünü yazdır
            YemekTuru secilenYemekTuru = (YemekTuru)secilenYemekTuruIndex;
            Console.WriteLine($"Seçilen yemek türü: {secilenYemekTuru}");

            // Sipariş alındı mesajı
            Console.WriteLine("Siparişiniz alınmıştır. Afiyet olsun!");
        }
        else
        {
            Console.WriteLine("Geçersiz giriş. Lütfen doğru bir yemek türü seçiniz.");
        }
    }
}
