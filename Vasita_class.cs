using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TamirHane
{
    public class Vasita
    {
        public string vasitaSahibi;
        public string marka;
        public int model_yili;
        public int parcaSayisi;
        public string yapilanİslem;
        
          public Vasita(string _vasitaSahibi, string _marka, int _model_yili, int _parcaSayisi, string _yapilanİslem) 
        {
            this.vasitaSahibi = _vasitaSahibi;
            this.marka = _marka;
            this.model_yili = _model_yili;
            this.parcaSayisi = _parcaSayisi;
            this.yapilanİslem = _yapilanİslem;
            
        
        }
    }
    public class Araba :Vasita
    {
        public string arabaRengi;
        public string aracMotorTipi;
        public uint aracKm;
        public uint aracSayisi;
          public Araba(string vasitaSahibi, string marka,int model_yili, int parcaSayisi,string yapilanİslem,string _arabaRengi, string _aracMotorTipi, uint _aracKm,uint _aracSayisi):base(vasitaSahibi,marka,model_yili,parcaSayisi,yapilanİslem)
        {
            this.arabaRengi = _arabaRengi;
            this.aracMotorTipi = _aracMotorTipi;
            this.aracKm = _aracKm;
            this.aracSayisi= _aracSayisi;
            _aracSayisi++;
            DateTime girisTarihi = DateTime.Now;
            Console.WriteLine("Araç Sahibinin Adı:{0}\nAracın Markası:{1}\nAracın Model Yili:{2}\nAracın Rengi:{3}\nAracın Motor Tipi:{4}\nAracın Kilometresi:{5}\nAraca Yapilacak İslem:{6}\nİslemde Kullanilacak Parca Sayisi:{7}\nServise Giriş Tarihi:{8}\nServisteki Araç Sayisi:{9}", vasitaSahibi,marka,model_yili,_arabaRengi,_aracMotorTipi,_aracKm,yapilanİslem,parcaSayisi,girisTarihi,_aracSayisi);

        }
    }
    public class Tekne : Vasita 
    {
        public string tekneRengi;
        public string govde;
        public uint tekneCalismaSaati; 
        public uint tekneSayisi;
        
        public Tekne(string vasitaSahibi, string marka, int model_yili, int parcaSayisi, string yapilanİslem, string _tekneRengi, string _govde, uint _tekneCalismaSaati, uint _tekneSayisi) : base(vasitaSahibi, marka, model_yili, parcaSayisi, yapilanİslem)
        {
            this.tekneRengi = _tekneRengi;
            this.govde = _govde;
            this.tekneCalismaSaati = _tekneCalismaSaati;
            this.tekneSayisi = _tekneSayisi;
            _tekneSayisi++;
            DateTime girisTarihi = DateTime.Now;
            Console.WriteLine("Tekne Sahibinin Adı:{0}\nTeknenin Markası:{1}\nTeknenin Model Yili:{2}\nTeknenin Rengi:{3}\nTeknenin Gövde Tipi:{4}\nTeknenin Çalışma Saati:{5}\nTekneye Yapilacak İslem:{6}\nİslemde Kullanilacak Parca Sayisi:{7}\nServise Giriş Tarihi:{8}\nServisteki Tekne Sayisi:{9}", vasitaSahibi, marka, model_yili, _tekneRengi, _govde,_tekneCalismaSaati, yapilanİslem, parcaSayisi, girisTarihi, _tekneSayisi);
        }
    }
}
