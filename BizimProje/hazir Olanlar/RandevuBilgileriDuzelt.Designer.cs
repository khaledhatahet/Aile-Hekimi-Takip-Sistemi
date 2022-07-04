namespace BizimProje
{
    partial class RandevuBilgileriDuzelt
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.tbTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btAra = new System.Windows.Forms.Button();
            this.lbMesaage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy  / HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(145, 119);
            this.dateTimePicker1.MinDate = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(199, 27);
            this.dateTimePicker1.TabIndex = 0;
            this.dateTimePicker1.Value = new System.DateTime(2021, 1, 1, 0, 0, 0, 0);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(8, 121);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 119;
            this.label4.Text = "Randevu Tarihi :";
            // 
            // tbTCNo
            // 
            this.tbTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTCNo.Location = new System.Drawing.Point(145, 70);
            this.tbTCNo.MaxLength = 11;
            this.tbTCNo.Name = "tbTCNo";
            this.tbTCNo.ReadOnly = true;
            this.tbTCNo.Size = new System.Drawing.Size(199, 27);
            this.tbTCNo.TabIndex = 117;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 20);
            this.label1.TabIndex = 118;
            this.label1.Text = "Hasta TC No :";
            // 
            // btAra
            // 
            this.btAra.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btAra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btAra.Location = new System.Drawing.Point(260, 173);
            this.btAra.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btAra.Name = "btAra";
            this.btAra.Size = new System.Drawing.Size(84, 35);
            this.btAra.TabIndex = 1;
            this.btAra.Text = "Güncelle";
            this.btAra.UseVisualStyleBackColor = false;
            this.btAra.Click += new System.EventHandler(this.btAra_Click);
            // 
            // lbMesaage
            // 
            this.lbMesaage.AutoSize = true;
            this.lbMesaage.Location = new System.Drawing.Point(174, 28);
            this.lbMesaage.Name = "lbMesaage";
            this.lbMesaage.Size = new System.Drawing.Size(0, 17);
            this.lbMesaage.TabIndex = 156;
            // 
            // RandevuBilgileriDuzelt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::BizimProje.Properties.Resources.wall_wallpaper_concrete_colored_painted_textured_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Controls.Add(this.lbMesaage);
            this.Controls.Add(this.btAra);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTCNo);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(362, 251);
            this.MinimumSize = new System.Drawing.Size(362, 251);
            this.Name = "RandevuBilgileriDuzelt";
            this.Size = new System.Drawing.Size(362, 251);
            this.Load += new System.EventHandler(this.RandevuBilgileriDuzelt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btAra;
        private System.Windows.Forms.Label lbMesaage;
    }
}
