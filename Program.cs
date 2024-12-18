using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamirHane
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool cikis = false;
            while (cikis != true)
            {
                uint aracSayi = 0;
                uint tekneSayi = 0;
                Console.WriteLine("****************************Hosgeldiniz****************************");
                
                Console.WriteLine("Eklemek İstediğiniz Arac Tipini Seciniz");
                Console.WriteLine("1-Araba\n2-Tekne");
                int tipSecim = Convert.ToInt32(Console.ReadLine());
                switch (tipSecim)
                {
                    case 1:
                        Console.Clear();
                        Console.WriteLine("Araç Sahibinin İsimini Giriniz: "); string aa = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Aracın Markasını Giriniz: "); string ab = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Aracın Model Yilini Giriniz: "); int ac = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                        Console.WriteLine("Degisim Yapilacak Parca Sayisini Giriniz: "); int ad = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                        Console.WriteLine("Araca Yapilacak Islemi Giriniz: "); string ae = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Aracın Rengini Giriniz: "); string af = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Aracın Motor Tipini Giriniz: "); string ag = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Aracın Kilometresini Giriniz: "); uint ah = Convert.ToUInt32(Console.ReadLine()); Console.Clear();

                        Araba araba1 = new Araba(aa, ab, ac, ad, ae, af, ag, ah, aracSayi);
                        aracSayi++;
                        break;

                    case 2:
                        Console.Clear();
                        Console.WriteLine("Tekne Sahibinin İsimini Giriniz: "); string ta = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Teknenin Markasını Giriniz: "); string tb = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Teknenin Model Yilini Giriniz: "); int tc = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                        Console.WriteLine("Degisim Yapilacak Parca Sayisini Giriniz: "); int td = Convert.ToInt32(Console.ReadLine()); Console.Clear();
                        Console.WriteLine("Tekneye Yapilacak Islemi Giriniz: "); string te = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Teknenin Rengini Giriniz: "); string tf = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Teknenin Gövde Tipini Giriniz: "); string tg = Console.ReadLine(); Console.Clear();
                        Console.WriteLine("Teknenin Çalişma Saatini Giriniz: "); uint th = Convert.ToUInt32(Console.ReadLine()); Console.Clear();


                        Tekne tekne1 = new Tekne(ta, tb, tc, td, te, tf, tg, th, tekneSayi);
                        tekneSayi++;
                        break;
                }
                
                Console.Write("\n\nYeni Vasıta Ekle (E/H)");
                char cikmak = Convert.ToChar(Console.ReadLine());
                Console.Clear();
                if (cikmak == 'h' || cikmak == 'H')
                {
                    cikis = true; return;
                }
                else
                {
                    cikis = false;
                }

            }
            Console.ReadKey();

        }
    }
}
