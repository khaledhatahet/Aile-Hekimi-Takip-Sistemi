using BizimProje.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
   public class Korona_Testi
    {
        string SonucNo;
        string TestSonucu;
        string TestTarihiVeSaati;
        string SonucTarihiVeSaati;
        string KarantinaBaslangicTarihi;
        string KarantinaBitisTarihi;
        string HastaTcNo;

        public Korona_Testi()
        {
        }

        public Korona_Testi(string sonucNo, string testSonucu, string testTarihiVeSaati, string sonucTarihiVeSaati, string karantinaBaslangicTarihi, string karantinaBitisTarihi, string hastaTcNo)
        {
            SonucNo1 = sonucNo;
            TestSonucu1 = testSonucu;
            TestTarihiVeSaati1 = testTarihiVeSaati;
            SonucTarihiVeSaati1 = sonucTarihiVeSaati;
            KarantinaBaslangicTarihi1 = karantinaBaslangicTarihi;
            KarantinaBitisTarihi1 = karantinaBitisTarihi;
            HastaTcNo1 = hastaTcNo;
        }

        public string SonucNo1 { get => SonucNo; set => SonucNo = value; }
        public string TestSonucu1 { get => TestSonucu; set => TestSonucu = value; }
        public string TestTarihiVeSaati1 { get => TestTarihiVeSaati; set => TestTarihiVeSaati = value; }
        public string SonucTarihiVeSaati1 { get => SonucTarihiVeSaati; set => SonucTarihiVeSaati = value; }
        public string KarantinaBaslangicTarihi1 { get => KarantinaBaslangicTarihi; set => KarantinaBaslangicTarihi = value; }
        public string KarantinaBitisTarihi1 { get => KarantinaBitisTarihi; set => KarantinaBitisTarihi = value; }
        public string HastaTcNo1 { get => HastaTcNo; set => HastaTcNo = value; }

        public int RandevuNoBul(string Tarih)
        {
            try
            {

                string query = $"select RandevuNo from Randevu Where RandevuTarihi = '{Tarih}'";
                DataTable data = metotlar.Goruntule(query);

                if (data.Rows.Count == 1)
                {
                    string get = data.Rows[0]["RandevuNo"].ToString();

                    return int.Parse(get);
                }
                return 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }
        }
        public DataTable TC_ile_arama(string TCNo)
        {
            try
            {

                string query = $"select * from [Korona Testi] Where HastaTcNo = '{TCNo}'";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        public DataTable ButunRandevulariGoruntule()
        {
            try
            {

                string query = "select * from [Korona Testi]";
                return metotlar.Goruntule(query);

            }
            catch (Exception ex)
            {

                throw new Exception("Az sonra tekrar Deneyininz" + ex.Message);
            }

        }
        public int RandevuOlustur(Korona_Testi k)
        {
            try
            {
               
                string query = $"insert into [Korona Testi](TestTarihiVeSaati,HastaTcNo) values('{k.TestTarihiVeSaati1}','{k.HastaTcNo1}')";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int RandevuDuzenle(Korona_Testi k)
        {
            try
            {

                string query = $"update [Korona Testi] set TestTarihiVeSaati = '{k.TestTarihiVeSaati1}' , SonucTarihiVeSaati = '{k.SonucTarihiVeSaati1}' , TestSonucu = '{k.TestSonucu1}' , KarantinaBaslangicTarihi = '{k.KarantinaBaslangicTarihi1}' , KarantinaBitisTarihi = '{k.KarantinaBitisTarihi1}' where SonucNo = {k.SonucNo1}";
                return metotlar.islemler(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public DataTable TestSonucuAra(string TCNO)
        {
            try
            {

                string query = $"select * from [Korona Testi] Where HastaTcNo = '{TCNO}'";
                return metotlar.Goruntule(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
    }
}
