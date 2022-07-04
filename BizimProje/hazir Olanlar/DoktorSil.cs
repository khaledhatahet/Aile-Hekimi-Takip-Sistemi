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
    public partial class DoktorSil : Form
    {
        public DoktorSil()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Doktor doktor = new Doktor();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = doktor.Ad_ile_arama(tbarama.Text.Trim());

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
                    var sonuc = MessageBox.Show("Silmek istediğinizden emin misiniz?", "Doktor Silme Mesajı",
                    MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        string TCNo =dataGridView1.Rows[e.RowIndex].Cells["DoktorTcNo"].Value.ToString();

                        Doktor doktor = new Doktor();

                        int s = doktor.DoktorSil(TCNo);

                        if (s > 0)
                        {
                            lbMessage.Text = "Doktor Silindi";
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
