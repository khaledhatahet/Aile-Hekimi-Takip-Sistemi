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
    public partial class KoronaDuzelt : Form
    {
        public KoronaDuzelt()
        {
            InitializeComponent();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Korona_Testi testi = new Korona_Testi();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = testi.TC_ile_arama(tbarama.Text.Trim());
            if (tbarama.Text == "")
            {
                dataGridView1.DataSource = testi.ButunRandevulariGoruntule();

            }

            DataGridViewImageColumn data = new DataGridViewImageColumn();
            data.HeaderText = "Düzelt";
            data.Name = "btDuzelt";
            data.Image = Properties.Resources.icons8_edit_16;
            dataGridView1.Columns.Insert(0, data);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbMessage.Text = "";

                if (e.ColumnIndex == 0)
                {
                    string SonucNo = dataGridView1.Rows[e.RowIndex].Cells["SonucNo"].Value.ToString();
                    string TestTarihi = dataGridView1.Rows[e.RowIndex].Cells["TestTarihiVeSaati"].Value.ToString();
                    string SonucTarihi = dataGridView1.Rows[e.RowIndex].Cells["SonucTarihiVeSaati"].Value.ToString();
                    string TestSonucu = dataGridView1.Rows[e.RowIndex].Cells["TestSonucu"].Value.ToString();
                    string KarantinaBaslangic = dataGridView1.Rows[e.RowIndex].Cells["KarantinaBaslangicTarihi"].Value.ToString();
                    string KarantinaBitis = dataGridView1.Rows[e.RowIndex].Cells["KarantinaBitisTarihi"].Value.ToString();
                    string HastaTC = dataGridView1.Rows[e.RowIndex].Cells["HastaTcNo"].Value.ToString();


                    Korona_Testi testi = new Korona_Testi();

                    testi.SonucNo1 = SonucNo;
                    testi.TestTarihiVeSaati1 = TestTarihi;
                    testi.SonucTarihiVeSaati1 = SonucTarihi;
                    testi.TestSonucu1 = TestSonucu;
                    testi.KarantinaBaslangicTarihi1 = KarantinaBaslangic;
                    testi.KarantinaBitisTarihi1 = KarantinaBitis;
                    testi.HastaTcNo1 = HastaTC;
                    long i;
                    if (long.TryParse(testi.HastaTcNo1.Trim(), out i) == true)
                    {
                        testi.HastaTcNo1 = i.ToString();
                    }
                    else
                    {
                        throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                    }

                    if (testi.HastaTcNo1.Length != 11)
                    {
                        throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                    }

                    KoronaTestBilgileriDuzelt duzelt = new KoronaTestBilgileriDuzelt();
                    duzelt.test = testi;
                    duzelt.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Clear();
                    splitContainer1.Panel2.Controls.Add(duzelt);
                }
            }
            catch (Exception ex)
            {

                lbMessage.Text = ex.Message ;
                lbMessage.ForeColor = Color.Red;
            }
        }
    }
}
