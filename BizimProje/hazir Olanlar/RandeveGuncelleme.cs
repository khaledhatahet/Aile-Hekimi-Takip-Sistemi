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
    public partial class RandeveGuncelleme : Form
    {
        public RandeveGuncelleme()
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
            try
            {
                Randevu randevu = new Randevu();

                dataGridView1.Columns.Clear();
                long i;
                if (tbarama.Text == "")
                {
                    dataGridView1.DataSource = randevu.ButunRandevulariGoruntule();
                    DataGridViewImageColumn d = new DataGridViewImageColumn();
                    d.HeaderText = "Düzelt";
                    d.Name = "btDuzelt";
                    d.Image = Properties.Resources.icons8_edit_16;
                    dataGridView1.Columns.Insert(0, d);

                }
                if (long.TryParse(tbarama.Text.Trim(), out i) == true)
                {
                    tbarama.Text = i.ToString();
                }
                else
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Yazınız.");
                }

                if (tbarama.Text.Length != 11)
                {
                    throw new Exception("Lütfen Geçerli TC Numarası Giriniz.");
                }
               


                dataGridView1.DataSource = randevu.TC_ile_arama(tbarama.Text.Trim());
               

                DataGridViewImageColumn data = new DataGridViewImageColumn();
                data.HeaderText = "Düzelt";
                data.Name = "btDuzelt";
                data.Image = Properties.Resources.icons8_edit_16;
                dataGridView1.Columns.Insert(0, data);
            }
            catch (Exception ex)
            {
                lbMessage.Text = ex.Message;
                lbMessage.ForeColor = Color.Red;
               
            }
            
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                lbMessage.Text = "";

                if (e.ColumnIndex == 0)
                {
                    string HastaTC = dataGridView1.Rows[e.RowIndex].Cells["HastaTcNo"].Value.ToString();
                    string RandevuTarihi = dataGridView1.Rows[e.RowIndex].Cells["RandevuTarihi"].Value.ToString();

                    Randevu randevu = new Randevu();
                    randevu.HastaTcNo1 = HastaTC;
                    randevu.RandevuTarihi1 = RandevuTarihi;

                    RandevuBilgileriDuzelt duzelt = new RandevuBilgileriDuzelt();
                    duzelt.randevu = randevu;
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

        private void RandeveGuncelleme_Load(object sender, EventArgs e)
        {
            Randevu randevu = new Randevu();
            dataGridView1.DataSource = randevu.ButunRandevulariGoruntule();
            DataGridViewImageColumn data = new DataGridViewImageColumn();
            data.HeaderText = "Düzelt";
            data.Name = "btDuzelt";
            data.Image = Properties.Resources.icons8_edit_16;
            dataGridView1.Columns.Insert(0, data);

        }
    }
}
