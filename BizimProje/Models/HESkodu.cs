using BizimProje.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BizimProje
{
   public class HESkodu
    {
        string HESKod;
      
        public HESkodu()
        {
        }

        public HESkodu(string hESKod)
        {
            HESKod1 = hESKod;
          
        }

        public string HESKod1 { get => HESKod; 
            set {
                if (string.IsNullOrEmpty(value))
                {
                    throw new Exception("Hes Kodu Boş Olamaz");
                }
                HESKod = value; 
            } 
        }
       
        public  bool HesKoduArama(string heskod)
        {
            try
            {

                string query = $"select * from HesKodu Where HESKod = '{heskod}'";
                return metotlar.Goruntule(query).Rows.Count>=1;
            }
            catch (Exception ex)
            {

                throw new Exception("Eşleşmiyor" + ex.Message);
            }

        }

        public int HesKoduEkle(HESkodu h)
        {
            try
            {
                if (HesKoduArama(h.HESKod1))
                {
                    throw new Exception("Bu Hes Kodu daha önce kullanılmış");
                }

                string query = $"insert into HesKodu(HESKod) values('{h.HESKod1}')" ;
                return metotlar.islemler(query);



            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }

        }

    }
}
