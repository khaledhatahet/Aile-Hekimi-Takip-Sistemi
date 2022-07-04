namespace BizimProje
{
    partial class PoliklinikBilgileriDuzelt
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
            this.tbPoliklinikAdi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbKat = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPoliklinikNO = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMesaage = new System.Windows.Forms.Label();
            this.btAra = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tbPoliklinikAdi
            // 
            this.tbPoliklinikAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPoliklinikAdi.Location = new System.Drawing.Point(147, 172);
            this.tbPoliklinikAdi.Name = "tbPoliklinikAdi";
            this.tbPoliklinikAdi.Size = new System.Drawing.Size(170, 27);
            this.tbPoliklinikAdi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(24, 172);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 20);
            this.label3.TabIndex = 132;
            this.label3.Text = "Poliklinik Adı :";
            // 
            // tbKat
            // 
            this.tbKat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbKat.Location = new System.Drawing.Point(147, 121);
            this.tbKat.Name = "tbKat";
            this.tbKat.Size = new System.Drawing.Size(170, 27);
            this.tbKat.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(9, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 130;
            this.label2.Text = "Bulunduğu Kat :";
            // 
            // tbPoliklinikNO
            // 
            this.tbPoliklinikNO.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPoliklinikNO.Location = new System.Drawing.Point(147, 67);
            this.tbPoliklinikNO.Name = "tbPoliklinikNO";
            this.tbPoliklinikNO.ReadOnly = true;
            this.tbPoliklinikNO.Size = new System.Drawing.Size(170, 27);
            this.tbPoliklinikNO.TabIndex = 127;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(27, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 20);
            this.label1.TabIndex = 129;
            this.label1.Text = "Poliklinik No :";
            // 
            // lbMesaage
            // 
            this.lbMesaage.AutoSize = true;
            this.lbMesaage.Location = new System.Drawing.Point(160, 27);
            this.lbMesaage.Name = "lbMesaage";
            this.lbMesaage.Size = new System.Drawing.Size(0, 17);
            this.lbMesaage.TabIndex = 155;
            // 
            // btAra
            // 
            this.btAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAra.Location = new System.Drawing.Point(233, 218);
            this.btAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAra.Name = "btAra";
            this.btAra.Size = new System.Drawing.Size(84, 35);
            this.btAra.TabIndex = 2;
            this.btAra.Text = "Güncelle";
            this.btAra.UseVisualStyleBackColor = false;
            this.btAra.Click += new System.EventHandler(this.btAra_Click);
            // 
            // PoliklinikBilgileriDuzelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::BizimProje.Properties.Resources.wall_wallpaper_concrete_colored_painted_textured_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.btAra);
            this.Controls.Add(this.lbMesaage);
            this.Controls.Add(this.tbPoliklinikAdi);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbKat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbPoliklinikNO);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(347, 305);
            this.MinimumSize = new System.Drawing.Size(347, 305);
            this.Name = "PoliklinikBilgileriDuzelt";
            this.Size = new System.Drawing.Size(347, 305);
            this.Load += new System.EventHandler(this.PoliklinikBilgileriDuzelt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPoliklinikAdi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbKat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPoliklinikNO;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMesaage;
        private System.Windows.Forms.Button btAra;
    }
}
