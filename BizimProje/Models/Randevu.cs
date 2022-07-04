using BizimProje.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
   public class Randevu
    {
        int    RandevuNo;
        string RandevuTarihi;
        string HastaTcNo;
        string DoktorTcNo;

        public Randevu()
        {
        }

        public Randevu(int randevuNo, string randevuTarihi, string randevuSaati, string hastaTcNo, string doktorTcNo)
        {
            RandevuNo1 = randevuNo;
            RandevuTarihi1 = randevuTarihi;
            HastaTcNo1 = hastaTcNo;
            DoktorTcNo1 = doktorTcNo;
        }

        public int RandevuNo1 { get => RandevuNo; set => RandevuNo = value; }
        public string RandevuTarihi1 { get => RandevuTarihi; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Randevu Tarihi Boş Olamaz");
                }
                RandevuTarihi = value; 
            } 
        }
        public string HastaTcNo1 { get => HastaTcNo; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Hasta TC No Boş Olamaz");
                }
                HastaTcNo = value; 
            } 
        }
        public string DoktorTcNo1 { get => DoktorTcNo; set => DoktorTcNo = value; }



        public DataTable TC_ile_arama(string TCNo)
        {
            try
            {

                string query = $"select * from Randevu Where HastaTcNo = '{TCNo}'";
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

                string query = "select * from Randevu";
                return metotlar.Goruntule(query);

            }
            catch (Exception ex)
            {

                throw new Exception("Az sonra tekrar Deneyininz" + ex.Message);
            }

        }
        public string RandevuNoileHastaBul(string randevu)
        {
            try
            {

                string query = $"select HastaTcNo from Randevu where RandevuTarihi like '%{randevu}%'";
                DataTable data = metotlar.Goruntule(query);

                if (data.Rows.Count == 1)
                {
                    Hasta hasta = new Hasta();
                    hasta.HastaTcNo1 = data.Rows[0]["HastaTcNo"].ToString();
                    return hasta.HastaTcNo1;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        public string[] BugunOlanRandevulariBul(string Tc)
        {
            try
            {

                string query = $"select [HastaTcNo] from Randevu where RandevuTarihi like '%{DateTime.Today.Day}%' and DoktorTcNo = '{Tc}'";
                DataTable data = metotlar.Goruntule(query);
                string[] Get = new string[data.Rows.Count];
                if (data.Rows.Count >= 1)
                {
                    for (int i = 0; i < data.Rows.Count; i++)
                    {
                        Get[i] = data.Rows[i]["HastaTcNo"].ToString();

                    }   
                    return Get;
                }
                return null;

            }
            catch (Exception ex)
            {

                throw new Exception("Az sonra tekrar Deneyininz" + ex.Message);
            }

        }
        public DataTable BugunOlanRandevulariBul1(string[] dizi , string tc)
        {
            try
            {
                
                dizi = BugunOlanRandevulariBul(tc);
                string ad = "";
                if (dizi != null)
                {
                    for (int i = 0; i < dizi.Length; i++)
                    {
                        ad += "'" + dizi[i] + "',";
                    }

                    ad = ad.TrimEnd(',');
                    string query = $"select Ad,Soyad,RandevuTarihi from Hasta h1,Randevu r1 where h1.HastaTcNo in({ad}) and h1.HastaTcNo = r1.HastaTcNo and r1.RandevuTarihi like '%{DateTime.Today.Day}%'";
                    return metotlar.Goruntule(query);
                }

                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {

                throw new Exception("Az sonra tekrar Deneyininz" + ex.Message);
            }

        }
        public string HastaninDoktorunuBul(string TCNo)
        {
            try
            {

                string query = $"select DoktorTcNo from Hasta Where HastaTcNo = '{TCNo}'";
                DataTable data =  metotlar.Goruntule(query);

                if (data.Rows.Count == 1)
                {
                    Hasta hasta = new Hasta();
                    hasta.DoktorTcNo1 = data.Rows[0]["DoktorTCNo"].ToString();
                    return hasta.DoktorTcNo1;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        public int RandevuNoBul(string Tarih , string TC , string hastaTc)
        {
            try
            {

                string query = $"select RandevuNo from Randevu Where RandevuTarihi = '{Tarih}' and DoktorTcNo = '{TC}' and HastaTcNo = '{hastaTc}'";
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
        private static bool RandevuArama(string RandevuTarihi , string DoktorTc)
        {
            try
            {

                string query = $"select * from Randevu where RandevuTarihi = '{RandevuTarihi}' and DoktorTcNo = '{DoktorTc}'";
                return metotlar.Goruntule(query).Rows.Count >= 1;
            }
            catch (Exception ex)
            {

                throw new Exception("Bir hata oluştu" + ex.Message);
            }

        }
        public int RandevuOlustur(Randevu r)
        {
            try
            {
                r.DoktorTcNo1 = HastaninDoktorunuBul(r.HastaTcNo1);

                if (RandevuArama(r.RandevuTarihi1,r.DoktorTcNo1))
                {
                    throw new Exception("Bu saatte Başka Bir Randevu Var");
                }
                string query = $"insert into Randevu(RandevuTarihi,HastaTcNo,DoktorTcNo) values('{r.RandevuTarihi1}','{r.HastaTcNo1}','{r.DoktorTcNo1}')";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int RandevuSilme(int No)
        {
            try
            {

                string query = $"Delete Randevu where RandevuNo='{No}'";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int RandevuDuzenle(Randevu r)
        {
            try
            {
                r.DoktorTcNo1 = HastaninDoktorunuBul(r.HastaTcNo1);
                if (RandevuArama(r.RandevuTarihi1, r.DoktorTcNo1))
                {
                    throw new Exception("bu saatte başka bir randevu var");
                }
                string query = $"update Randevu set RandevuTarihi = '{r.RandevuTarihi1}' where RandevuNo = {r.RandevuNo1}";
                return metotlar.islemler(query);
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
    }

    

    
}
