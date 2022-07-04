namespace BizimProje
{
    partial class RaporOlusturma
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RaporOlusturma));
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbTcNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.tbNot = new System.Windows.Forms.TextBox();
            this.dtpSonGecerlilikTarihi = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.RaporText = new System.Windows.Forms.RichTextBox();
            this.lbMesaage = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printPreviewDialog1 = new System.Windows.Forms.PrintPreviewDialog();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(448, 36);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(169, 29);
            this.label14.TabIndex = 127;
            this.label14.Text = "Rapor Oluştur";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(88, 178);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 20);
            this.label3.TabIndex = 124;
            this.label3.Text = "Rapor Son Geçerlilik Tarihi :";
            // 
            // tbTcNo
            // 
            this.tbTcNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTcNo.Location = new System.Drawing.Point(341, 125);
            this.tbTcNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTcNo.MaxLength = 11;
            this.tbTcNo.Name = "tbTcNo";
            this.tbTcNo.Size = new System.Drawing.Size(425, 27);
            this.tbTcNo.TabIndex = 0;
            this.tbTcNo.TextChanged += new System.EventHandler(this.tbTcNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(240, 128);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 20);
            this.label1.TabIndex = 121;
            this.label1.Text = "Tc NO :";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(646, 268);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 44);
            this.button1.TabIndex = 4;
            this.button1.Text = "İptal";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(263, 227);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 20);
            this.label5.TabIndex = 116;
            this.label5.Text = "Not :";
            // 
            // tbNot
            // 
            this.tbNot.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbNot.Location = new System.Drawing.Point(341, 224);
            this.tbNot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbNot.Name = "tbNot";
            this.tbNot.Size = new System.Drawing.Size(425, 27);
            this.tbNot.TabIndex = 2;
            // 
            // dtpSonGecerlilikTarihi
            // 
            this.dtpSonGecerlilikTarihi.CustomFormat = "dd.MM.yyyy";
            this.dtpSonGecerlilikTarihi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpSonGecerlilikTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSonGecerlilikTarihi.Location = new System.Drawing.Point(341, 175);
            this.dtpSonGecerlilikTarihi.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSonGecerlilikTarihi.Name = "dtpSonGecerlilikTarihi";
            this.dtpSonGecerlilikTarihi.Size = new System.Drawing.Size(425, 26);
            this.dtpSonGecerlilikTarihi.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(521, 268);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 44);
            this.button2.TabIndex = 3;
            this.button2.Text = "Oluştur";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // RaporText
            // 
            this.RaporText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.RaporText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.RaporText.Location = new System.Drawing.Point(199, 334);
            this.RaporText.Name = "RaporText";
            this.RaporText.ReadOnly = true;
            this.RaporText.Size = new System.Drawing.Size(566, 813);
            this.RaporText.TabIndex = 132;
            this.RaporText.Text = "";
            // 
            // lbMesaage
            // 
            this.lbMesaage.AutoSize = true;
            this.lbMesaage.Location = new System.Drawing.Point(524, 66);
            this.lbMesaage.Name = "lbMesaage";
            this.lbMesaage.Size = new System.Drawing.Size(0, 17);
            this.lbMesaage.TabIndex = 133;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.BackgroundImage = global::BizimProje.Properties.Resources.print_50px;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Location = new System.Drawing.Point(213, 288);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(44, 40);
            this.button3.TabIndex = 134;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // printDialog1
            // 
            this.printDialog1.Document = this.printDocument1;
            this.printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            this.printPreviewDialog1.AutoScrollMargin = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.AutoScrollMinSize = new System.Drawing.Size(0, 0);
            this.printPreviewDialog1.ClientSize = new System.Drawing.Size(400, 300);
            this.printPreviewDialog1.Enabled = true;
            this.printPreviewDialog1.Icon = ((System.Drawing.Icon)(resources.GetObject("printPreviewDialog1.Icon")));
            this.printPreviewDialog1.Name = "printPreviewDialog1";
            this.printPreviewDialog1.Visible = false;
            // 
            // RaporOlusturma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BizimProje.Properties.Resources.wall_wallpaper_concrete_colored_painted_textured_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 954);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.lbMesaage);
            this.Controls.Add(this.RaporText);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtpSonGecerlilikTarihi);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbTcNo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tbNot);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1085, 1001);
            this.MinimumSize = new System.Drawing.Size(1085, 1001);
            this.Name = "RaporOlusturma";
            this.Text = "Rapor Oluşturma";
            this.Load += new System.EventHandler(this.RaporOlusturma_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbTcNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tbNot;
        private System.Windows.Forms.DateTimePicker dtpSonGecerlilikTarihi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.RichTextBox RaporText;
        private System.Windows.Forms.Label lbMesaage;
        private System.Windows.Forms.Button button3;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.PrintPreviewDialog printPreviewDialog1;
    }
}