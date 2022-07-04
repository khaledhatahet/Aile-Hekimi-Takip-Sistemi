using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BizimProje
{
    public partial class AsiBilgileriDuzelt : UserControl
    {
        public Asi asi { get; set; }
        public AsiBilgileriDuzelt()
        {
            InitializeComponent();
        }

        private void AsiBilgileriDuzelt_Load(object sender, EventArgs e)
        {
            try
            {
                if (asi == null)
                {
                    throw new Exception("Aşı Boş");
                }
                tbAsiAdi.Text = asi.AsiAdi1;
                tbAsiNo.Text = asi.AsiNo1;

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
                if (asi == null)
                {
                    throw new Exception("Aşı Boş");

                }
                asi.AsiAdi1 = tbAsiAdi.Text.Trim();
                int sonuc = asi.AsiDuzenle(asi);
                if (sonuc>0)
                {
                    lbMesaage.Text = "Aşı Güncellendi";
                    lbMesaage.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                lbMesaage.Text = "Aşı Güncellenemedi";
                lbMesaage.ForeColor = Color.Red;

            }

        }
    }
}
