namespace BizimProje
{
    partial class AsiEkleme
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
            this.label14 = new System.Windows.Forms.Label();
            this.tbAsiNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btAra = new System.Windows.Forms.Button();
            this.btBitti = new System.Windows.Forms.Button();
            this.tbAsiAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbMesaage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(328, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(142, 29);
            this.label14.TabIndex = 135;
            this.label14.Text = "Aşı Ekleme";
            // 
            // tbAsiNo
            // 
            this.tbAsiNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAsiNo.Location = new System.Drawing.Point(215, 185);
            this.tbAsiNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAsiNo.Name = "tbAsiNo";
            this.tbAsiNo.Size = new System.Drawing.Size(425, 27);
            this.tbAsiNo.TabIndex = 0;
            this.tbAsiNo.TextChanged += new System.EventHandler(this.tbAsiAd_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(123, 188);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 20);
            this.label2.TabIndex = 140;
            this.label2.Text = "Aşı No :";
            // 
            // btAra
            // 
            this.btAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAra.Location = new System.Drawing.Point(396, 298);
            this.btAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAra.Name = "btAra";
            this.btAra.Size = new System.Drawing.Size(119, 44);
            this.btAra.TabIndex = 2;
            this.btAra.Text = "Ekle";
            this.btAra.UseVisualStyleBackColor = false;
            this.btAra.Click += new System.EventHandler(this.btAra_Click);
            // 
            // btBitti
            // 
            this.btBitti.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btBitti.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btBitti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btBitti.Location = new System.Drawing.Point(521, 298);
            this.btBitti.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btBitti.Name = "btBitti";
            this.btBitti.Size = new System.Drawing.Size(119, 44);
            this.btBitti.TabIndex = 3;
            this.btBitti.Text = "İptal";
            this.btBitti.UseVisualStyleBackColor = false;
            // 
            // tbAsiAdi
            // 
            this.tbAsiAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbAsiAdi.Location = new System.Drawing.Point(215, 235);
            this.tbAsiAdi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAsiAdi.Name = "tbAsiAdi";
            this.tbAsiAdi.Size = new System.Drawing.Size(425, 27);
            this.tbAsiAdi.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(123, 238);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 20);
            this.label1.TabIndex = 146;
            this.label1.Text = "Aşı Adı :";
            // 
            // lbMesaage
            // 
            this.lbMesaage.AutoSize = true;
            this.lbMesaage.Location = new System.Drawing.Point(353, 154);
            this.lbMesaage.Name = "lbMesaage";
            this.lbMesaage.Size = new System.Drawing.Size(0, 17);
            this.lbMesaage.TabIndex = 147;
            // 
            // AsiEkleme
            // 
            this.AcceptButton = this.btAra;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BackgroundImage = global::BizimProje.Properties.Resources.wall_wallpaper_concrete_colored_painted_textured_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.btBitti;
            this.ClientSize = new System.Drawing.Size(795, 422);
            this.Controls.Add(this.lbMesaage);
            this.Controls.Add(this.tbAsiAdi);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btAra);
            this.Controls.Add(this.btBitti);
            this.Controls.Add(this.tbAsiNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label14);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(813, 469);
            this.MinimumSize = new System.Drawing.Size(813, 469);
            this.Name = "AsiEkleme";
            this.Text = "Aşi Ekleme";
            this.Load += new System.EventHandler(this.AsiEkleme_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox tbAsiNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btAra;
        private System.Windows.Forms.Button btBitti;
        private System.Windows.Forms.TextBox tbAsiAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbMesaage;
    }
}