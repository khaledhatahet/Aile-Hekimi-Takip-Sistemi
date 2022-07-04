using BizimProje.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
   public class Poliklinik
    {
        string PoliklinikNO;
        string BulunduguKat;
        string PoliklinikAdi;
        public Poliklinik()
        {
        }

        public Poliklinik(string poliklinikNO, string bulunduguKat)
        {
            PoliklinikNO1 = poliklinikNO;
            BulunduguKat1 = bulunduguKat;
        }

        public string PoliklinikNO1 { get => PoliklinikNO; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Poliklinik NO Boş Olamaz");
                }
                PoliklinikNO = value; 
            } 
        }
        public string BulunduguKat1 { get => BulunduguKat; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Bulunduğu Kat Boş Olamaz");
                }
                BulunduguKat = value; 
            } 
        }
        public string PoliklinikAdi1 {  get => PoliklinikAdi;
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Poliklinik Adı Boş Olamaz");
                }
                PoliklinikAdi = value;
            }
        }
        public DataTable ButunPoliklinikleriGoruntule()
        {
            try
            {

                string query = "select * from Poliklinik";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir hata oluştu" + ex.Message);
            }

        }
        public DataTable Ad_ile_arama(string ad)
        {
            try
            {

                string query = $"select * from Poliklinik where PoliklinikAdi like '%{ad}%'";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        private static bool PoliklinikArama(string PoliklinikNo)
        {
            try
            {

                string query = $"select * from Poliklinik where PoliklinikNO = '{PoliklinikNo}'";
                return metotlar.Goruntule(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {

                throw new Exception("Bir hata oluştu" + ex.Message);
            }

        }
        public string[] PoliklinikDoluKontrol(string TCNo)
        {
            try
            {

                string query = $"select PoliklinikNO from Doktor";
                DataTable data = metotlar.Goruntule(query);
                string[] Get = new string[data.Rows.Count];
                if (data.Rows.Count >= 1)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        Get[i] = data.Rows[i]["PoliklinikNO"].ToString();

                    }
                    return Get;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        public int PoliklinikEkle(Poliklinik p)
        {
            try
            {
                if (PoliklinikArama(p.PoliklinikNO1))
                {
                    throw new Exception("Bu Poliklinik Daha önce Eklenmiş");
                }
                string query = $"insert into Poliklinik(PoliklinikNO,BulunduguKat,PoliklinikAdi) values('{p.PoliklinikNO1}','{p.BulunduguKat1}','{p.PoliklinikAdi1}')";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int PoliklinikSil(string poliklinikNo)
        {
            try
            {

                string query = $"Delete Poliklinik where PoliklinikNO = '{poliklinikNo}'";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int PoliklinikDuzenle(Poliklinik p)
        {
            try
            {

                string query = $"update Poliklinik set PoliklinikNO = '{p.PoliklinikNO1}' , BulunduguKat= '{p.BulunduguKat1}' , PoliklinikAdi='{p.PoliklinikAdi1}' where PoliklinikNO = '{p.PoliklinikNO1}'";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
    }
}
