using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace BizimProje
{
    public partial class RandevuBilgileriDuzelt : UserControl
    {
        public Randevu randevu { get; set; }
        public RandevuBilgileriDuzelt()
        {
            InitializeComponent();
        }

        private void RandevuBilgileriDuzelt_Load(object sender, EventArgs e)
        {

            try
            {
                if (randevu == null)
                {
                    throw new Exception("Randevu Boş");
                }
                tbTCNo.Text = randevu.HastaTcNo1;
                dateTimePicker1.Text = randevu.RandevuTarihi1;
                
                


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private void btAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (randevu == null)
                {
                    throw new Exception("Randevu Boş");

                }
                randevu.HastaTcNo1 = tbTCNo.Text.Trim();
                randevu.DoktorTcNo1 = randevu.HastaninDoktorunuBul(randevu.HastaTcNo1);
                randevu.RandevuNo1 = randevu.RandevuNoBul(randevu.RandevuTarihi1, randevu.DoktorTcNo1,randevu.HastaTcNo1);
                randevu.RandevuTarihi1 = dateTimePicker1.Value.ToString();
               

                int sonuc = randevu.RandevuDuzenle(randevu);
                if (sonuc > 0)
                {
                    lbMesaage.Text = "Randevu Güncellendi";
                    lbMesaage.ForeColor = Color.Green;
                }
               
            }
            catch (Exception ex)
            {
                lbMesaage.Text = ex.Message;
                lbMesaage.ForeColor = Color.Red;

            }
        }

        
    }
}
