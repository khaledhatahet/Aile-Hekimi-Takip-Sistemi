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
   public class Hasta : kisi
    {
        string HastaTcNo;
        string AnneAdi;
        string BabaAdi;
        string KanGrubu;
        string HESKod;
        string DoktorTcNo;
        public Hasta() 
        {

        }
        public Hasta(string hastaTcNo,string anneAdi, string babaAdi,string kanGrubu,string hESKod, string doktorTcNo , string ad,
            string soyad, string cinsiyet, string telefonNo, string dogumYeri, string dogumTarihi, string adres, string not)
            : base(ad, soyad, cinsiyet, telefonNo, dogumYeri, dogumTarihi, adres, not)

        {
            HastaTcNo1 = hastaTcNo;
            AnneAdi1 = anneAdi;
            BabaAdi1 = babaAdi;
            KanGrubu1 = kanGrubu;
            HESKod1 = hESKod;
            DoktorTcNo1 = doktorTcNo;
        }

        public string HastaTcNo1 { get => HastaTcNo; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("tc no boş olamaz");
                }
                HastaTcNo = value; 
            } 
        }
        public string AnneAdi1 { get => AnneAdi; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Anne Adı Boş Olamaz");
                }
                AnneAdi = value; 
            } 
        }
        public string BabaAdi1 { get => BabaAdi; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Baba Adı Boş Olamaz");
                }
                BabaAdi = value; 
            } 
        }
        public string KanGrubu1 { get => KanGrubu; set => KanGrubu = value; }
        public string HESKod1 { get => HESKod; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("HES Kodu Boş Olamaz");
                }
                HESKod = value; 
            } 
        }
        public string DoktorTcNo1 { get => DoktorTcNo; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Doktor TC NO Boş Olamaz");
                }
                DoktorTcNo = value; 
            } 
        }




        public DataTable ButunHastalariGoruntule()
        {
            try
            {
                
                    string query = "select * from Hasta";
                   return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir hata oluştu" + ex.Message);
            }
           
        }
        public DataTable TCNo_ile_arama(string TCNo)
        {
            try
            {
               
                    string query = $"select * from Hasta Where HastaTcNo = '{TCNo}'";
                    return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }
            
        }
        public DataTable DoktorTCNo_ile_arama(string TCNo)
        {
            try
            {

                string query = $"select * from Hasta Where DoktorTcNo = '{TCNo}'";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        public DataTable HastaninDoktorunuBulma(string Ad , string doktor)
        {
            try
            {

                string query = $"select * from Hasta Where Ad + ' ' + Soyad like '%{Ad}%' and DoktorTcNo = '{doktor}'";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }

        public DataTable Ad_ile_arama(string ad)
        {
            try
            {
               
                    string query = $"select * from Hasta Where Ad + ' ' + Soyad like '%{ad}%'";
                    return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }
           
        }
        private static bool HastaArama(string TCNo)
        {
            try
            {

                string query = $"select * from Hasta where HastaTcNo = '{TCNo}'";
                return metotlar.Goruntule(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {

                throw new Exception("Bir hata oluştu" + ex.Message);
            }

        }
        public int HastaEkle(Hasta s)
        {
            try
            {
                if (HastaArama(s.HastaTcNo1))
                {
                    throw new Exception("Bu hasta Daha Önce Eklenmiş.");
                }
                string query = $"insert into Hasta(HastaTcNo,Ad,Soyad,Cinsiyet,AnneAdi,BabaAdi,TelefonNo,DogumTarihi,DogumYeri,KanGrubu,Adres,HESKod,DoktorTcNo)" +
                $" values('{s.HastaTcNo1}','{s.Ad1}','{s.Soyad1}','{s.Cinsiyet1}','{s.AnneAdi1}','{s.BabaAdi1}','{s.TelefonNo1}','{s.DogumTarihi1}','{s.DogumYeri1}','{s.KanGrubu1}','{s.Adres1}','{s.HESKod1}','{s.DoktorTcNo1}')";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }
            
        }
        public int HastaSil(string TCNO)
        {
            try
            {

                string query = $"Delete Hasta where HastaTcNo = '{TCNO}'";
                return metotlar.islemler(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int HastaDuzenle(Hasta s)
        {
            try
            {

                string query = $"update Hasta set HastaTcNo = '{s.HastaTcNo1}',Ad = '{s.Ad1}',Soyad='{s.Soyad1}',Cinsiyet='{s.Cinsiyet1}',AnneAdi='{s.AnneAdi1}',BabaAdi='{s.BabaAdi1}',TelefonNo='{s.TelefonNo1}',DogumTarihi='{s.DogumTarihi1}',DogumYeri='{s.DogumYeri1}',KanGrubu='{s.KanGrubu1}',Adres='{s.Adres1}',HESKod='{s.HESKod1}',DoktorTcNo='{s.DoktorTcNo1}' where HastaTcNo = '{s.HastaTcNo1}'";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
    }
}
