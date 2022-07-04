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
    public partial class AsiSilme : Form
    {
        public AsiSilme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Asi asi = new Asi();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = asi.Ad_ile_arama(tbarama.Text.Trim());

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

                if (e.ColumnIndex==0)
                {
                    var sonuc = MessageBox.Show("Silmek istediğinizden emin misiniz?","Aşı Silme Mesajı",
                    MessageBoxButtons.YesNo);
                    if (sonuc == DialogResult.Yes)
                    {
                        int AsiNo = int.Parse(dataGridView1.Rows[e.RowIndex].Cells["AsiNo"].Value.ToString());

                        Asi asi = new Asi();

                        int s = asi.AsiSilme(AsiNo);

                        if (s > 0)
                        {
                            lbMessage.Text = "Aşı Silindi";
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

        private void a(object sender, EventArgs e)
        {

        }
    }
}
