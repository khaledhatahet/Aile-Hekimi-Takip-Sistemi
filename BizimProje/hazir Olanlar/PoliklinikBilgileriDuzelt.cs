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
    public partial class PoliklinikBilgileriDuzelt : UserControl
    {
        public Poliklinik poliklinik { get; set; }
        public PoliklinikBilgileriDuzelt()
        {
            InitializeComponent();
        }
        private void PoliklinikBilgileriDuzelt_Load(object sender, EventArgs e)
        {
            try
            {
                if (poliklinik == null)
                {
                    throw new Exception("poliklinik Boş");
                }
                tbPoliklinikNO.Text = poliklinik.PoliklinikNO1;
                tbPoliklinikAdi.Text = poliklinik.PoliklinikAdi1;
                tbKat.Text = poliklinik.BulunduguKat1;

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
                if (poliklinik == null)
                {
                    throw new Exception("poliklinik Boş");

                }
                poliklinik.PoliklinikNO1 = tbPoliklinikNO.Text;
                poliklinik.PoliklinikAdi1 = tbPoliklinikAdi.Text;
                poliklinik.BulunduguKat1 = tbKat.Text; 
                int sonuc = poliklinik.PoliklinikDuzenle(poliklinik);
                if (sonuc > 0)
                {
                    lbMesaage.Text = "poliklinik Güncellendi";
                    lbMesaage.ForeColor = Color.Green;
                }
            }
            catch (Exception)
            {
                lbMesaage.Text = "poliklinik Güncellenemedi";
                lbMesaage.ForeColor = Color.Red;

            }
        }
    }
}
