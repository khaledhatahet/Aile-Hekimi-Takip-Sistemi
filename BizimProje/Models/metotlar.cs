using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace BizimProje.Models
{
    public static class metotlar
    {
        public static DataTable Goruntule(string query)
        {
            SqlConnection baglanti = null;
            try
            {
                // string sqlbaglanti = " Server = LAPTOP-9N1GPMSP; Database = Proje; Trusted_Connection = True";
                string sqlbaglanti = ConfigurationManager.AppSettings["constring"].ToString();  
                baglanti = new SqlConnection(sqlbaglanti);
                baglanti.Open();
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, baglanti);
                    SqlDataAdapter adapter = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
                return null;
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }

        public static int islemler(string query)
        {
            SqlConnection baglanti = null;
            try
            {
                //string sqlbaglanti = " Server = LAPTOP-9N1GPMSP; Database = Proje; Trusted_Connection = True";
                string sqlbaglanti = ConfigurationManager.AppSettings["constring"].ToString();
                baglanti = new SqlConnection(sqlbaglanti);
                baglanti.Open();
                if (baglanti.State == System.Data.ConnectionState.Open)
                {
                    SqlCommand sqlCommand = new SqlCommand(query, baglanti);
                    return sqlCommand.ExecuteNonQuery();
                    
                }
                else
                {
                    throw new Exception("Bir Hata oluştu");
                }
                
            }
            catch (Exception ex)
            {

                throw new Exception("Bir Hata oluştu" + ex.Message);
            }
            finally
            {
                baglanti.Close();
            }
        }
    }
}
