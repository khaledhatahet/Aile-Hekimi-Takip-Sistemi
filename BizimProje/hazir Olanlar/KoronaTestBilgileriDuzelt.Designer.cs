namespace BizimProje
{
    partial class KoronaTestBilgileriDuzelt
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMesaage = new System.Windows.Forms.Label();
            this.btAra = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SonucTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.KarantinaBitis = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.KarantinaBaslangic = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.TestSonucu = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMesaage
            // 
            this.lbMesaage.AutoSize = true;
            this.lbMesaage.Location = new System.Drawing.Point(179, 35);
            this.lbMesaage.Name = "lbMesaage";
            this.lbMesaage.Size = new System.Drawing.Size(0, 17);
            this.lbMesaage.TabIndex = 162;
            // 
            // btAra
            // 
            this.btAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAra.Location = new System.Drawing.Point(388, 353);
            this.btAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAra.Name = "btAra";
            this.btAra.Size = new System.Drawing.Size(84, 35);
            this.btAra.TabIndex = 161;
            this.btAra.Text = "Güncelle";
            this.btAra.UseVisualStyleBackColor = false;
            this.btAra.Click += new System.EventHandler(this.btAra_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(68, 134);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 20);
            this.label4.TabIndex = 159;
            this.label4.Text = "Test Tarihi :";
            // 
            // tbTCNo
            // 
            this.tbTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTCNo.Location = new System.Drawing.Point(193, 77);
            this.tbTCNo.MaxLength = 11;
            this.tbTCNo.Name = "tbTCNo";
            this.tbTCNo.ReadOnly = true;
            this.tbTCNo.Size = new System.Drawing.Size(199, 27);
            this.tbTCNo.TabIndex = 157;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(50, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 158;
            this.label1.Text = "Hasta TC No :";
            // 
            // SonucTarihi
            // 
            this.SonucTarihi.CustomFormat = "dd.MM.yyyy  / HH:mm";
            this.SonucTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.SonucTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.SonucTarihi.Location = new System.Drawing.Point(193, 175);
            this.SonucTarihi.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.SonucTarihi.Name = "SonucTarihi";
            this.SonucTarihi.Size = new System.Drawing.Size(279, 27);
            this.SonucTarihi.TabIndex = 0;
            this.SonucTarihi.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(55, 180);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 20);
            this.label2.TabIndex = 163;
            this.label2.Text = "Sonuc Tarihi :";
            // 
            // KarantinaBitis
            // 
            this.KarantinaBitis.CustomFormat = "dd.MM.yyyy  / HH:mm";
            this.KarantinaBitis.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KarantinaBitis.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.KarantinaBitis.Location = new System.Drawing.Point(193, 312);
            this.KarantinaBitis.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.KarantinaBitis.Name = "KarantinaBitis";
            this.KarantinaBitis.ShowCheckBox = true;
            this.KarantinaBitis.Size = new System.Drawing.Size(279, 27);
            this.KarantinaBitis.TabIndex = 3;
            this.KarantinaBitis.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(38, 312);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 20);
            this.label3.TabIndex = 165;
            this.label3.Text = "Karantina Bitiş :";
            // 
            // KarantinaBaslangic
            // 
            this.KarantinaBaslangic.CustomFormat = "dd.MM.yyyy  / HH:mm";
            this.KarantinaBaslangic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.KarantinaBaslangic.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.KarantinaBaslangic.Location = new System.Drawing.Point(193, 270);
            this.KarantinaBaslangic.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.KarantinaBaslangic.Name = "KarantinaBaslangic";
            this.KarantinaBaslangic.ShowCheckBox = true;
            this.KarantinaBaslangic.Size = new System.Drawing.Size(279, 27);
            this.KarantinaBaslangic.TabIndex = 2;
            this.KarantinaBaslangic.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(2, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 20);
            this.label5.TabIndex = 167;
            this.label5.Text = "Karantina Başlangıç :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(50, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 20);
            this.label6.TabIndex = 170;
            this.label6.Text = "Test Sonucu  :";
            // 
            // TestSonucu
            // 
            this.TestSonucu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TestSonucu.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TestSonucu.FormattingEnabled = true;
            this.TestSonucu.Items.AddRange(new object[] {
            "Pozitif",
            "Negatif"});
            this.TestSonucu.Location = new System.Drawing.Point(193, 220);
            this.TestSonucu.Name = "TestSonucu";
            this.TestSonucu.Size = new System.Drawing.Size(199, 28);
            this.TestSonucu.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(193, 131);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(199, 27);
            this.textBox1.TabIndex = 172;
            // 
            // KoronaTestBilgileriDuzelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BizimProje.Properties.Resources.wall_wallpaper_concrete_colored_painted_textured_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.TestSonucu);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.KarantinaBaslangic);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.KarantinaBitis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.SonucTarihi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbMesaage);
            this.Controls.Add(this.btAra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTCNo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(544, 443);
            this.MinimumSize = new System.Drawing.Size(544, 443);
            this.Name = "KoronaTestBilgileriDuzelt";
            this.Size = new System.Drawing.Size(544, 443);
            this.Load += new System.EventHandler(this.KoronaTestBilgileriDuzelt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMesaage;
        private System.Windows.Forms.Button btAra;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker SonucTarihi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker KarantinaBitis;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker KarantinaBaslangic;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox TestSonucu;
        private System.Windows.Forms.TextBox textBox1;
    }
}
