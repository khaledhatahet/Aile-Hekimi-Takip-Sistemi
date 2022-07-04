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
    public partial class AsiDuzeltme : Form
    {
        public AsiDuzeltme()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
           
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Asi asi = new Asi();

            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = asi.Ad_ile_arama(tbarama.Text.Trim());

            DataGridViewImageColumn data = new DataGridViewImageColumn();
            data.HeaderText = "Düzelt";
            data.Name = "btDuzelt";
            data.Image = Properties.Resources.icons8_edit_16;
            dataGridView1.Columns.Insert(0, data);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbMessage.Text = "";

                if (e.ColumnIndex == 0)
                {
                    string AsiNo = dataGridView1.Rows[e.RowIndex].Cells["AsiNo"].Value.ToString();
                    string AsiAdi = dataGridView1.Rows[e.RowIndex].Cells["AsiAdi"].Value.ToString();

                    Asi a = new Asi();
                    a.AsiNo1 = AsiNo;
                    a.AsiAdi1 = AsiAdi;

                    AsiBilgileriDuzelt duzelt = new AsiBilgileriDuzelt();
                    duzelt.asi = a;
                    duzelt.Dock = DockStyle.Fill;
                    splitContainer1.Panel2.Controls.Clear();
                    splitContainer1.Panel2.Controls.Add(duzelt);
                }
            }
            catch (Exception)
            {

                lbMessage.Text = "Bir Sıkıntı İle Karşılaştık.";
                lbMessage.ForeColor = Color.Red;
            }
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AsiDuzeltme_Load(object sender, EventArgs e)
        {

        }
    }
}
