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
    public partial class PoliklinikGuncelleme : Form
    {
        public PoliklinikGuncelleme()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Poliklinik poliklinik = new Poliklinik();
            dataGridView1.Columns.Clear();

            dataGridView1.DataSource = poliklinik.Ad_ile_arama(tbarama.Text.Trim());

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
                    string PoliklinikNo = dataGridView1.Rows[e.RowIndex].Cells["PoliklinikNO"].Value.ToString();
                    string PoliklinikAdi = dataGridView1.Rows[e.RowIndex].Cells["PoliklinikAdi"].Value.ToString();
                    string bulunduguKat = dataGridView1.Rows[e.RowIndex].Cells["BulunduguKat"].Value.ToString();

                    Poliklinik poliklinik = new Poliklinik();
                    poliklinik.PoliklinikNO1 = PoliklinikNo;
                    poliklinik.PoliklinikAdi1 = PoliklinikAdi;
                    poliklinik.BulunduguKat1 = bulunduguKat;

                    PoliklinikBilgileriDuzelt duzelt = new PoliklinikBilgileriDuzelt();
                    duzelt.poliklinik = poliklinik;
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
    }
}
