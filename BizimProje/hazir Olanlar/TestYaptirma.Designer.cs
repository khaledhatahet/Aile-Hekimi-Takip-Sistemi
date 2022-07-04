namespace BizimProje
{
    partial class TestYaptirma
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
            this.label4 = new System.Windows.Forms.Label();
            this.tbTCNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.lbMesaage = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(31, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(196, 20);
            this.label4.TabIndex = 115;
            this.label4.Text = "Randevu Tarihi ve Saati :";
            // 
            // tbTCNo
            // 
            this.tbTCNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbTCNo.Location = new System.Drawing.Point(240, 178);
            this.tbTCNo.MaxLength = 11;
            this.tbTCNo.Name = "tbTCNo";
            this.tbTCNo.Size = new System.Drawing.Size(425, 27);
            this.tbTCNo.TabIndex = 0;
            this.tbTCNo.TextChanged += new System.EventHandler(this.tbTCNo_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(160, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 113;
            this.label1.Text = "TC No :";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Transparent;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(214, 71);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(396, 32);
            this.label13.TabIndex = 117;
            this.label13.Text = "Korona Testi Randevu Oluştur";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(403, 279);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(119, 44);
            this.button5.TabIndex = 2;
            this.button5.Text = "Oluştur";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(528, 279);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(119, 44);
            this.button6.TabIndex = 3;
            this.button6.Text = "İptal";
            this.button6.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd.MM.yyyy  / HH:mm";
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(240, 226);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(425, 27);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // lbMesaage
            // 
            this.lbMesaage.AutoSize = true;
            this.lbMesaage.Location = new System.Drawing.Point(398, 134);
            this.lbMesaage.Name = "lbMesaage";
            this.lbMesaage.Size = new System.Drawing.Size(0, 17);
            this.lbMesaage.TabIndex = 149;
            // 
            // TestYaptirma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::BizimProje.Properties.Resources.wall_wallpaper_concrete_colored_painted_textured_concept;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(795, 422);
            this.Controls.Add(this.lbMesaage);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tbTCNo);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(813, 469);
            this.MinimumSize = new System.Drawing.Size(813, 469);
            this.Name = "TestYaptirma";
            this.Text = "Test Yaptırma";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbTCNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label lbMesaage;
    }
}