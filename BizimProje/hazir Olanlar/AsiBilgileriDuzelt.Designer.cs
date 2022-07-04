namespace BizimProje
{
    partial class AsiBilgileriDuzelt
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
            this.tbAsiAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAra = new System.Windows.Forms.Button();
            this.tbAsiNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbMesaage
            // 
            this.lbMesaage.AutoSize = true;
            this.lbMesaage.Location = new System.Drawing.Point(135, 42);
            this.lbMesaage.Name = "lbMesaage";
            this.lbMesaage.Size = new System.Drawing.Size(0, 17);
            this.lbMesaage.TabIndex = 154;
            // 
            // tbAsiAdi
            // 
            this.tbAsiAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAsiAdi.Location = new System.Drawing.Point(109, 129);
            this.tbAsiAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAsiAdi.Name = "tbAsiAdi";
            this.tbAsiAdi.Size = new System.Drawing.Size(159, 27);
            this.tbAsiAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 132);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 153;
            this.label1.Text = "Aşı Adı :";
            // 
            // btAra
            // 
            this.btAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAra.Location = new System.Drawing.Point(192, 174);
            this.btAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAra.Name = "btAra";
            this.btAra.Size = new System.Drawing.Size(76, 30);
            this.btAra.TabIndex = 1;
            this.btAra.Text = "Güncelle";
            this.btAra.UseVisualStyleBackColor = false;
            this.btAra.Click += new System.EventHandler(this.btAra_Click);
            // 
            // tbAsiNo
            // 
            this.tbAsiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAsiNo.Location = new System.Drawing.Point(109, 79);
            this.tbAsiNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAsiNo.Name = "tbAsiNo";
            this.tbAsiNo.ReadOnly = true;
            this.tbAsiNo.Size = new System.Drawing.Size(123, 27);
            this.tbAsiNo.TabIndex = 148;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(17, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 152;
            this.label2.Text = "Aşı No :";
            // 
            // AsiBilgileriDuzelt
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackgroundImage = global::BizimProje.Properties.Resources.wall_wallpaper_concrete_colored_painted_textured_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbMesaage);
            this.Controls.Add(this.tbAsiAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAra);
            this.Controls.Add(this.tbAsiNo);
            this.Controls.Add(this.label2);
            this.MaximumSize = new System.Drawing.Size(347, 262);
            this.MinimumSize = new System.Drawing.Size(347, 262);
            this.Name = "AsiBilgileriDuzelt";
            this.Size = new System.Drawing.Size(347, 262);
            this.Load += new System.EventHandler(this.AsiBilgileriDuzelt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMesaage;
        private System.Windows.Forms.TextBox tbAsiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAra;
        private System.Windows.Forms.TextBox tbAsiNo;
        private System.Windows.Forms.Label label2;
    }
}
