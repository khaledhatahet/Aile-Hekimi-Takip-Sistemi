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
    public partial class PoliklinikSilme : Form
    {
        public PoliklinikSilme()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Poliklinik poliklinik = new Poliklinik();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = poliklinik.Ad_ile_arama(tbarama.Text.Trim());

            DataGridViewImageColumn data = new DataGridViewImageColumn();
            data.HeaderText = "Sil";
            data.Name = "btSil";
            data.Image = Properties.Resources.icons8_delete_16;
            dataGridView1.Columns.Insert(0, data);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbMessage.Text = "";

                if (e.ColumnIndex == 0)
                {
                    var sonuc = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Poliklinik Silme Mesajı",
                    MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        string poliklinikNo = dataGridView1.Rows[e.RowIndex].Cells["PoliklinikNO"].Value.ToString();

                        Poliklinik poliklinik = new Poliklinik();

                        int s = poliklinik.PoliklinikSil(poliklinikNo);

                        if (s > 0)
                        {
                            lbMessage.Text = "poliklinik Silindi";
                            lbMessage.ForeColor = Color.Green;
                        }
                    }
                }
            }
            catch (Exception)
            {

                lbMessage.Text = "Bir Sıkıntı İle Karşılaştık.";
                lbMessage.ForeColor = Color.Red;
            }
        }
    }
}
