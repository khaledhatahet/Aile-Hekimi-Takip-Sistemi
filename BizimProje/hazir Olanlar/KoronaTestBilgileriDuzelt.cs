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
    public partial class KoronaTestBilgileriDuzelt : UserControl
    {
        public Korona_Testi test { get; set; }
        public KoronaTestBilgileriDuzelt()
        {
            InitializeComponent();
        }

        private void btAra_Click(object sender, EventArgs e)
        {
            try
            {
                if (test == null)
                {
                    throw new Exception("Randevu Boş");

                }
                test.HastaTcNo1 = tbTCNo.Text.Trim();
                test.TestTarihiVeSaati1 = textBox1.Text.Trim();
                test.SonucTarihiVeSaati1 = SonucTarihi.Value.ToString();
                test.TestSonucu1 = TestSonucu.SelectedItem.ToString();
                test.KarantinaBaslangicTarihi1 = KarantinaBaslangic.Value.ToString();
                test.KarantinaBitisTarihi1 = KarantinaBitis.Value.ToString();

                long i;
                if (long.TryParse(test.HastaTcNo1.Trim(), out i) == true)
                {
                    test.HastaTcNo1 = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (test.HastaTcNo1.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }

                int sonuc = test.RandevuDuzenle(test);
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

        private void KoronaTestBilgileriDuzelt_Load(object sender, EventArgs e)
        {
            try
            {
                if (test == null)
                {
                    throw new Exception("Randevu Boş");
                }
                tbTCNo.Text = test.HastaTcNo1;
                textBox1.Text = test.TestTarihiVeSaati1;
                SonucTarihi.Text = test.SonucTarihiVeSaati1;
                TestSonucu.SelectedItem = test.TestSonucu1;
                KarantinaBaslangic.Text = test.KarantinaBaslangicTarihi1;
                KarantinaBitis.Text = test.KarantinaBitisTarihi1;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
