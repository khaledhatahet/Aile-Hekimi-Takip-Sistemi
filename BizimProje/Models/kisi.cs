using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
   public abstract class kisi
    {
        private string Ad;
        private string Soyad;
        private string Cinsiyet;
        private string TelefonNo;
        private string DogumYeri;
        private string DogumTarihi;
        private string Adres;
        private string Not;

        public kisi()
        {

        }

        protected kisi(string ad, string soyad, string cinsiyet, string telefonNo, string dogumYeri, string dogumTarihi, string adres, string not)
        {
            Ad1 = ad;
            Soyad1 = soyad;
            Cinsiyet1 = cinsiyet;
            TelefonNo1 = telefonNo;
            DogumYeri1 = dogumYeri;
            DogumTarihi1 = dogumTarihi;
            Adres1 = adres;
            Not1 = not;
        }

        public string Ad1 { get => Ad; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Ad Boş Olamaz");
                }
                Ad = value; 
            } 
        }
        public string Soyad1 { get => Soyad; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("SoyAd Boş Olamaz");
                }
                Soyad = value; 
            } 
        }
        public string Cinsiyet1 { get => Cinsiyet; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Cinsiyet Boş Olamaz");
                }
                Cinsiyet = value; 
            } 
        }
        public string TelefonNo1 { get => TelefonNo; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Telefon No Boş Olamaz");
                }
                TelefonNo = value; 
            } 
        }
        public string DogumYeri1 { get => DogumYeri; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Doğum Yeri Boş Olamaz");
                }
                DogumYeri = value; 
            } 
        }
        public string DogumTarihi1 { get => DogumTarihi; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Doğum Tarihi Boş Olamaz");
                }
                DogumTarihi = value; 
            } 
        }
        public string Adres1 { get => Adres; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Adres Boş Olamaz");
                }
                Adres = value; 
            } 
        }
        public string Not1 { get => Not; set => Not = value; }

       
    }
}
