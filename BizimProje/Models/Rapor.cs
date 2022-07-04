using BizimProje.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
   public class Rapor
    {
        int RaporNo;
        string RaporOlusturmaTarihi;
        string SonGecerlilikTarihi;
        string RaporNot;
        string HastaTcNo;
        string DoktorTcNo;

        public Rapor()
        {
        }

        public Rapor(int raporNo, string raporOlusturmaTarihi, string sonGecerlilikTarihi, string raporNot, string hastaTcNo, string doktorTcNo)
        {
            RaporNo1 = raporNo;
            RaporOlusturmaTarihi1 = raporOlusturmaTarihi;
            SonGecerlilikTarihi1 = sonGecerlilikTarihi;
            RaporNot1 = raporNot;
            HastaTcNo1 = hastaTcNo;
            DoktorTcNo1 = doktorTcNo;
        }

        public int RaporNo1 { get => RaporNo; set => RaporNo = value; }
        public string RaporOlusturmaTarihi1 { get => RaporOlusturmaTarihi; set => RaporOlusturmaTarihi = value; }
        public string SonGecerlilikTarihi1 { get => SonGecerlilikTarihi; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Son Geçerlilik Tarihi Giriniz.");
                }
                SonGecerlilikTarihi = value; 
            } 
        }
        public string RaporNot1 { get => RaporNot; 
            set 
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception(" Lütfen Not Kısmına Açıklama Giriniz.");
                }
                RaporNot = value; 
            } 
        }
        public string HastaTcNo1 { get => HastaTcNo; 
            set 
            {
                if ((string.IsNullOrEmpty(value)) || (value.Length > 11))
                {
                    throw new Exception(" Hasta TC No Kontrol Ediniz.");
                }
                HastaTcNo = value; 
            } 
        }
        public string DoktorTcNo1 { get => DoktorTcNo; set => DoktorTcNo = value;  }

       
        public Hasta HastaninBilgileriniBul(string TCNo)
        {
            try
            {

                string query = $"select * from Hasta  where HastaTcNo = '{TCNo}'";
                DataTable data = metotlar.Goruntule(query);

                if (data.Rows.Count == 1)
                {
                    Hasta hasta = new Hasta();
                    hasta.Ad1 = data.Rows[0]["Ad"].ToString();
                    hasta.Soyad1 = data.Rows[0]["Soyad"].ToString();
                    hasta.AnneAdi1 = data.Rows[0]["AnneAdi"].ToString();
                    hasta.BabaAdi1 = data.Rows[0]["BabaAdi"].ToString();
                    hasta.DogumTarihi1 = data.Rows[0]["DogumTarihi"].ToString();
                    hasta.DogumYeri1 = data.Rows[0]["DogumYeri"].ToString();
                    hasta.DoktorTcNo1 = data.Rows[0]["DoktorTcNo"].ToString();

                    return hasta;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        public Doktor HastaninDoktorununBilgileriniBul(string TCNo)
        {
            try
            {
                Hasta hasta1 = new Hasta();
                hasta1.DoktorTcNo1 = HastaninBilgileriniBul(TCNo).DoktorTcNo1;           
                string query = $"select * from Doktor  where DoktorTcNo = '{ hasta1.DoktorTcNo1}'";
                DataTable data = metotlar.Goruntule(query);

                if (data.Rows.Count == 1)
                {
                    Doktor doktor = new Doktor();
                    doktor.DoktorTcNo1 = data.Rows[0]["DoktorTcNo"].ToString();
                    doktor.Ad1 = data.Rows[0]["Ad"].ToString();
                    doktor.Soyad1 = data.Rows[0]["Soyad"].ToString();
                    doktor.PoliklinikNO1 = data.Rows[0]["PoliklinikNO"].ToString();
                    

                    return doktor;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }
        public int RaporOlustur(Rapor r)
        {
            try
            {
               
                string query = $"insert into Rapor(RaporOlusturmaTarihi,SonGecerlilikTarihi,HastaTcNo,DoktorTcNo,RaporNot) values('{r.RaporOlusturmaTarihi1}','{r.SonGecerlilikTarihi1}','{r.HastaTcNo1}','{r.DoktorTcNo1}','{r.RaporNot1}')";
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }
        public int RaporNoBul(Rapor r)
        {
            try
            {

                string query = $"select [RaporNo] from Rapor where HastaTcNo='{r.HastaTcNo1}' and DoktorTcNo = '{r.DoktorTcNo1}' and RaporOlusturmaTarihi = '{r.RaporOlusturmaTarihi1}' and SonGecerlilikTarihi = '{r.SonGecerlilikTarihi1}'";
                DataTable data = metotlar.Goruntule(query);

                if (data.Rows.Count == 1)
                {
                    string get = data.Rows[0]["RaporNo"].ToString();

                    return int.Parse(get);
                }
                return 0;
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }
        }
    }
}
