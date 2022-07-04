using BizimProje.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
   public class Doktor:kisi
    {
        string DoktorTcNo;
        string EmailHesabi;
        string Password;
        string MesaiSaatleri;
        string PoliklinikNO;

        public Doktor()
        {

        }
        public Doktor(string doktorTcNo, string emailHesabi, string password, string mesaiSaatleri, string poliklinikNO,
            string ad, string soyad, string cinsiyet, string telefonNo, string dogumYeri, string dogumTarihi, string adres, string not)
            :base(ad, soyad, cinsiyet, telefonNo, dogumYeri, dogumTarihi, adres, not)
        {
            DoktorTcNo1 = doktorTcNo;
            EmailHesabi1 = emailHesabi;
            Password1 = password;
            MesaiSaatleri1 = mesaiSaatleri;
            PoliklinikNO1 = poliklinikNO;
        }

        public string DoktorTcNo1 { get => DoktorTcNo;
            set {
                if (string.IsNullOrEmpty(value))
                { 
                    throw new Exception("TC NO Boş Olamaz");
                }
                DoktorTcNo = value;
            } 
        }
        public string EmailHesabi1 { get => EmailHesabi; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Email Boş Olamaz");
                }
                EmailHesabi = value; 
            } 
        }
        public string Password1 { get => Password; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Şifre Boş Olamaz");
                }
                Password = value; 
            } 
        }
        public string MesaiSaatleri1 { get => MesaiSaatleri; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Mesai Saatleri Boş Olamaz");
                }
                MesaiSaatleri = value; 
            } 
        }
        public string PoliklinikNO1 { get => PoliklinikNO; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Poliklinik No Boş Olamaz");
                }
                PoliklinikNO = value; 
            } 
        }

        public  Doktor Login(string email, string sifre)
        {
            try
            {
               
                    string query = $"select * from Doktor where EmailHesabi = '{email}' and Password = '{sifre}'";
                    DataTable dt = metotlar.Goruntule(query);

                    if (dt.Rows.Count > 0)
                    {
                        Doktor doktor = new Doktor();
                        doktor.DoktorTcNo1 = dt.Rows[0]["DoktorTcNo"].ToString();
                        doktor.Ad1 = dt.Rows[0]["Ad"].ToString();
                        doktor.Soyad1 = dt.Rows[0]["Soyad"].ToString();
                        doktor.TelefonNo1 = dt.Rows[0]["TelefonNo"].ToString();
                        return doktor;
                    }
                
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Giriş Yaparken sıkıntı oldu" + ex.Message);
            }
            
        }

        public DataTable ButunDoktorlariGoruntule()
        {
            try
            {
                
                    string query = "select * from Doktor";
                    return metotlar.Goruntule(query);
                    
            }
            catch (Exception ex)
            {

                throw new Exception("Az sonra tekrar Deneyininz" + ex.Message);
            }
            
        }
        public DataTable Ad_ile_arama(string ad)
        {
            try
            {

                string query = $"select * from Doktor Where Ad + ' ' + Soyad like '%{ad}%'";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        private static bool DoktorArama(string TCNo)
        {
            try
            {

                string query = $"select * from Doktor where DoktorTcNo = '{TCNo}'";
                return metotlar.Goruntule(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {

                throw new Exception("Bir hata oluştu" + ex.Message);
            }

        }
        public int DoktorEkle(Doktor d)
        {
            try
            {
                if (DoktorArama(d.DoktorTcNo1))
                {
                    throw new Exception("Doktor Daha önce eklenmiş");
                }
                string query = $"insert into Doktor(DoktorTcNo,Ad,Soyad,Cinsiyet,EmailHesabi,Password,MesaiSaatleri,TelefonNo,DogumTarihi,DogumYeri,Adres,PoliklinikNO) " +
                    $"values('{d.DoktorTcNo1}','{d.Ad1}','{d.Soyad1}','{d.Cinsiyet1}','{d.EmailHesabi1}','{d.Password1}','{d.MesaiSaatleri1}','{d.TelefonNo1}','{d.DogumTarihi1}','{d.DogumYeri1}','{d.Adres1}','{d.PoliklinikNO1}')";
                    return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int DoktorSil(string TCNO)
        {
            try
            {

                string query = $"Delete Doktor where DoktorTcNo = '{TCNO}'";
                return metotlar.islemler(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int DoktorDuzenle(Doktor d)
        {
            try
            {

                string query = $"update Doktor set DoktorTcNo = '{d.DoktorTcNo1}',Ad = '{d.Ad1}',Soyad='{d.Soyad1}',Cinsiyet='{d.Cinsiyet1}',EmailHesabi='{d.EmailHesabi1}',Password='{d.Password1}',MesaiSaatleri='{d.MesaiSaatleri1}',TelefonNo='{d.TelefonNo1}',DogumTarihi='{d.DogumTarihi1}',DogumYeri='{d.DogumYeri1}',Adres='{d.Adres1}',PoliklinikNO='{d.PoliklinikNO1}' where DoktorTcNo = '{d.DoktorTcNo1}'";
                return metotlar.islemler(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
    }
}
