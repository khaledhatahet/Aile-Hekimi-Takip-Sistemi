using BizimProje.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
  public  class Sekreter : kisi
    {
        string SekreterTcNo;
        string SekreterEmailHesabi;
        string SekreterPassword;
        string SekreterMesaiSaatleri;

        public Sekreter()
        {

        }

        public Sekreter(string sekreterTcNo,string sekreterEmailHesabi, string sekreterPassword,string sekreterMesaiSaatleri, string ad,
            string soyad, string cinsiyet, string telefonNo, string dogumYeri, string dogumTarihi, string adres, string not)
            :base(ad,soyad,cinsiyet,telefonNo,dogumYeri,dogumTarihi,adres,not)
        {
            SekreterTcNo1 = sekreterTcNo;  
            SekreterEmailHesabi1 = sekreterEmailHesabi;
            SekreterPassword1 = sekreterPassword;
            SekreterMesaiSaatleri1 = sekreterMesaiSaatleri;
            
        }

        public string SekreterTcNo1 { get => SekreterTcNo; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("TC NO Boş Olamaz");
                }
                SekreterTcNo = value; 
            } 
        }
        public string SekreterEmailHesabi1 { get => SekreterEmailHesabi; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Email Boş Olamaz");
                }
                SekreterEmailHesabi = value; 
            } 
        }
        public string SekreterPassword1 { get => SekreterPassword; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Şifre Boş Olamaz");
                }
                SekreterPassword = value; 
            } 
        }
        public string SekreterMesaiSaatleri1 { get => SekreterMesaiSaatleri; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Mesai Saatleri Boş Olamaz");
                }
                SekreterMesaiSaatleri = value; 
            } 
        }
        public kisi Login(string email, string sifre)
        {
            try
            {

                string query = $"select * from Sekreter where EmailHesabi = '{email}' and Password = '{sifre}'";
                DataTable dt = metotlar.Goruntule(query);

                if (dt.Rows.Count > 0)
                {
                    Sekreter sekreter = new Sekreter();
                    sekreter.SekreterTcNo1 = dt.Rows[0]["SekreterTcNo"].ToString();
                    sekreter.Ad1 = dt.Rows[0]["Ad"].ToString();
                    sekreter.Soyad1 = dt.Rows[0]["Soyad"].ToString();
                    return sekreter;
                }

                return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Giriş Yaparken sıkıntı oldu" + ex.Message);
            }

        }

        public DataTable Ad_ile_arama(string ad)
        {
            try
            {

                string query = $"select * from Sekreter Where Ad + ' ' + Soyad like '%{ad}%'";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        private static bool SekreterArama(string TCNo)
        {
            try
            {

                string query = $"select * from Sekreter where SekreterTcNo = '{TCNo}'";
                return metotlar.Goruntule(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {

                throw new Exception("Bir hata oluştu" + ex.Message);
            }

        }
        public int SekreterEkle(Sekreter s)
        {
            try
            {
                if (SekreterArama(s.SekreterTcNo1))
                {
                    throw new Exception("Sekreter Daha önce eklenmiş");
                }
                string query = $"insert into Sekreter(SekreterTcNo,Ad,Soyad,Cinsiyet,EmailHesabi,Password,MesaiSaatleri,TelefonNo,DogumTarihi,DogumYeri,Adres)" +
                    $" values('{s.SekreterTcNo1}','{s.Ad1}','{s.Soyad1}','{s.Cinsiyet1}','{s.SekreterEmailHesabi1}','{s.SekreterPassword1}','{s.SekreterMesaiSaatleri1}','{s.TelefonNo1}','{s.DogumTarihi1}','{s.DogumYeri1}','{s.Adres1}')";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int SekreterSil(string TCNO)
        {
            try
            {

                string query = $"Delete Sekreter where SekreterTcNo = '{TCNO}'";
                return metotlar.islemler(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int SekreterDuzenle(Sekreter s)
        {
            try
            {

                string query = $"update Sekreter set SekreterTcNo = '{s.SekreterTcNo1}',Ad = '{s.Ad1}',Soyad='{s.Soyad1}',Cinsiyet='{s.Cinsiyet1}',EmailHesabi='{s.SekreterEmailHesabi1}',Password='{s.SekreterPassword1}', MesaiSaatleri = '{s.SekreterMesaiSaatleri1}' ,TelefonNo='{s.TelefonNo1}',DogumTarihi='{s.DogumTarihi1}',DogumYeri='{s.DogumYeri1}',Adres='{s.Adres1}' where SekreterTcNo = '{s.SekreterTcNo1}'";
                return metotlar.islemler(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }


    }
}
