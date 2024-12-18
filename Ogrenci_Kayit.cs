using System;
using System.Collections.Generic;
using System.IO;

class Program
{
    static void Main()
    {
        List<Ogrenci> ogrenciler = new List<Ogrenci>();

        while (true)
        {
            Console.WriteLine("1-Kayıt Ekle\n2-Kayıtları Listele\n3-Kayıt Ara\n4-Kayıt Düzenle\n5-Çıkış");
            int secim = Convert.ToInt32(Console.ReadLine());

            switch (secim)
            {
                case 1:
                    OgrenciKayitEkle(ogrenciler);
                    break;

                case 2:
                    OgrenciListele(ogrenciler);
                    break;

                case 3:
                    OgrenciAra(ogrenciler);
                    break;

                case 4:
                    OgrenciDuzenle(ogrenciler);
                    break;

                case 5:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Geçersiz seçim. Lütfen tekrar deneyin.");
                    break;
            }
        }
    }

    static void OgrenciKayitEkle(List<Ogrenci> ogrenciler)
    {
        Console.WriteLine("Ad:");
        string ad = Console.ReadLine();

        Console.WriteLine("Soyad:");
        string soyad = Console.ReadLine();

        Console.WriteLine("Numara:");
        int numara = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Bölüm:");
        string bolum = Console.ReadLine();

        Console.WriteLine("Cinsiyet:");
        string cinsiyet = Console.ReadLine();

        Console.WriteLine("Doğum Yeri:");
        string dogumYeri = Console.ReadLine();

        Console.WriteLine("Yaş:");
        int yas = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Telefon Numarası:");
        string telefonNumarasi = Console.ReadLine();

        Ogrenci yeniOgrenci = new Ogrenci(ad, soyad, numara, bolum, cinsiyet, dogumYeri, yas, telefonNumarasi);
        ogrenciler.Add(yeniOgrenci);

        Console.WriteLine("Öğrenci başarıyla eklendi.");
    }

    static void OgrenciListele(List<Ogrenci> ogrenciler)
    {
        foreach (var ogrenci in ogrenciler)
        {
            Console.WriteLine(ogrenci);
        }
    }

    static void OgrenciAra(List<Ogrenci> ogrenciler)
    {
        Console.WriteLine("Aranacak öğrencinin adını girin:");
        string arananAd = Console.ReadLine();

        Ogrenci bulunanOgrenci = ogrenciler.Find(ogrenci => ogrenci.Ad == arananAd);

        if (bulunanOgrenci != null)
        {
            Console.WriteLine("Öğrenci bulundu:\n" + bulunanOgrenci);
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı.");
        }
    }

    static void OgrenciDuzenle(List<Ogrenci> ogrenciler)
    {
        Console.WriteLine("Düzenlenecek öğrencinin adını girin:");
        string duzenlenecekAd = Console.ReadLine();

        Ogrenci duzenlenecekOgrenci = ogrenciler.Find(ogrenci => ogrenci.Ad == duzenlenecekAd);

        if (duzenlenecekOgrenci != null)
        {
            Console.WriteLine("Yeni ad:");
            duzenlenecekOgrenci.Ad = Console.ReadLine();

            // Diğer öğrenci bilgilerini buraya ekleyin

            Console.WriteLine("Öğrenci başarıyla düzenlendi.");
        }
        else
        {
            Console.WriteLine("Öğrenci bulunamadı.");
        }
    }
}

class Ogrenci
{
    public string Ad { get; set; }
    public string Soyad { get; set; }
    public int Numara { get; set; }
    public string Bolum { get; set; }
    public string Cinsiyet { get; set; }
    public string DogumYeri { get; set; }
    public int Yas { get; set; }
    public string TelefonNumarasi { get; set; }

    public Ogrenci(string ad, string soyad, int numara, string bolum, string cinsiyet, string dogumYeri, int yas, string telefonNumarasi)
    {
        Ad = ad;
        Soyad = soyad;
        Numara = numara;
        Bolum = bolum;
        Cinsiyet = cinsiyet;
        DogumYeri = dogumYeri;
        Yas = yas;
        TelefonNumarasi = telefonNumarasi;
    }

    public override string ToString()
    {
        return $"Ad: {Ad}, Soyad: {Soyad}, Numara: {Numara}, Bölüm: {Bolum}, Cinsiyet: {Cinsiyet}, Doğum Yeri: {DogumYeri}, Yaş: {Yas}, Telefon Numarası: {TelefonNumarasi}";
    }
}