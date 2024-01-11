using System;

class HesapMakinesi
{
    public static int ToplamaSayisi { get; private set; }  // Static property

    // Static metod
    public static double Topla(double sayi1, double sayi2)
    {
        ToplamaSayisi++;  // Her çağrıldığında topma sayısını artır

        return sayi1 + sayi2;
    }

    // Static bir metot daha
    public static double Carp(double sayi1, double sayi2)
    {
        return sayi1 * sayi2;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Toplam: {0}", HesapMakinesi.Topla(5.5, 3.2));
        Console.WriteLine("Çarpım: {0}", HesapMakinesi.Carp(2.5, 4.0));

        Console.WriteLine("Toplama Sayısı: {0}", HesapMakinesi.ToplamaSayisi);

        // Başka işlemler ve sınıfın diğer özellikleri eklenebilir
    }
}
