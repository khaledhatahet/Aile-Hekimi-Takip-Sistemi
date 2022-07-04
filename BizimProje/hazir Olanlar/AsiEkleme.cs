using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimProje
{
    public partial class AsiEkleme : Form
    {
        public AsiEkleme()
        {
            InitializeComponent();
        }

        private void AsiEkleme_Load(object sender, EventArgs e)
        {

        }

        private void tbAsiAd_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void btAra_Click(object sender, EventArgs e)
        {
            try
            {
                lbMesaage.Text = "";
                string AsiAdi = tbAsiAdi.Text.Trim();
                string AsiNo = tbAsiNo.Text.Trim();


                Asi a = new Asi();
                a.AsiAdi1 = AsiAdi;
                a.AsiNo1 = AsiNo;

                int sonuc = a.AsiEkle(a);
                if (sonuc > 0)
                {
                    lbMesaage.Text = "Asi Eklendi";
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
