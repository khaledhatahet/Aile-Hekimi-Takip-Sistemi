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
    public partial class SekreterSil : Form
    {
        public SekreterSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sekreter sekreter = new Sekreter();
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = sekreter.Ad_ile_arama(tbarama.Text.Trim());

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
                    var sonuc = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Sekreter Silme Mesajı",
                    MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        string TCNo = dataGridView1.Rows[e.RowIndex].Cells["SekreterTcNo"].Value.ToString();

                        Sekreter sekreter = new Sekreter();

                        int s = sekreter.SekreterSil(TCNo);

                        if (s > 0)
                        {
                            lbMessage.Text = "Sekreter Silindi";
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
