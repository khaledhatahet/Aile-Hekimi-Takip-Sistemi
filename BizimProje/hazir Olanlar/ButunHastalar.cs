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
    public partial class ButunHastalar : Form
    {
        public Doktor calisan { get; set; }

        public ButunHastalar(Doktor k)
        {
            InitializeComponent();
            calisan = k;

        }

        public ButunHastalar()
        {
        }

        private void ButunHastalar_Load(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();
            dataGridView1.DataSource = hasta.DoktorTCNo_ile_arama(calisan.DoktorTcNo1);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            GirisEkrani girisEkrani = new GirisEkrani();
            girisEkrani.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Hasta hasta = new Hasta();

            dataGridView1.Columns.Clear();
            if (tbarama.Text == "")
            {
                dataGridView1.DataSource = hasta.DoktorTCNo_ile_arama(calisan.DoktorTcNo1);

            }
            dataGridView1.DataSource = hasta.HastaninDoktorunuBulma(tbarama.Text, calisan.DoktorTcNo1);
        }
    }
}
