using BizimProje.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
   public class Asi
    {
        string AsiNo;
        string AsiAdi;
        string AsiTarihi;

        public Asi()
        {
        }

        public Asi(string asiNo, string asiAdi, string asiTarihi)
        {
            AsiNo1 = asiNo;
            AsiAdi1 = asiAdi;
            AsiTarihi1 = asiTarihi;
        }

        public string AsiNo1 { get => AsiNo;
            set {
                if (string.IsNullOrEmpty(value))
                {

                    throw new Exception("Aşı NO Boş Olamaz.");
                }
                AsiNo = value; 
            }
        }
        public string AsiAdi1
        {
            get => AsiAdi;
            set
            {
                if (string.IsNullOrEmpty(value)) {

                    throw new Exception("Aşı Adı Boş Olamaz.");
                }
                AsiAdi = value;
            }
        }
        public string AsiTarihi1 { get => AsiTarihi; set => AsiTarihi = value; }



        public DataTable ButunAsilariGoruntule()
        {
            try
            {

                string query = "select * from Asi";
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

                string query = $"select * from Asi where AsiAdi like '%{ad}%'";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        public int AsiEkle(Asi a)
        {
            try
            {

                string query = $"insert into Asi(AsiAdi,AsiNo) values('{a.AsiAdi1}','{a.AsiNo1}')";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int AsiSilme(int asiNo)
        {
            try
            {

                string query = $"Delete Asi where AsiNo={asiNo}";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int AsiDuzenle(Asi a)
        {
            try
            {

                string query = $"update Asi set AsiAdi = '{a.AsiAdi1}',AsiNo={a.AsiNo1} where AsiNo = {a.AsiNo1}";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
    }
}
