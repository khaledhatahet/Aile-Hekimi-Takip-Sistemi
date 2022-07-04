using System;

namespace BizimProje
{
    partial class GirisEkrani
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
            this.lblsifre = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.lblkullanici = new System.Windows.Forms.Label();
            this.tbEmail = new System.Windows.Forms.TextBox();
            this.btGiris = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblsifre
            // 
            this.lblsifre.AutoSize = true;
            this.lblsifre.BackColor = System.Drawing.Color.Transparent;
            this.lblsifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblsifre.ForeColor = System.Drawing.Color.White;
            this.lblsifre.Location = new System.Drawing.Point(216, 214);
            this.lblsifre.Name = "lblsifre";
            this.lblsifre.Size = new System.Drawing.Size(54, 20);
            this.lblsifre.TabIndex = 12;
            this.lblsifre.Text = "Şifre :";
            // 
            // tbPassword
            // 
            this.tbPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbPassword.Location = new System.Drawing.Point(309, 211);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(333, 27);
            this.tbPassword.TabIndex = 1;
            this.tbPassword.Text = "halit";
            this.tbPassword.UseSystemPasswordChar = true;
            // 
            // lblkullanici
            // 
            this.lblkullanici.AutoSize = true;
            this.lblkullanici.BackColor = System.Drawing.Color.Transparent;
            this.lblkullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblkullanici.ForeColor = System.Drawing.Color.White;
            this.lblkullanici.Location = new System.Drawing.Point(163, 170);
            this.lblkullanici.Name = "lblkullanici";
            this.lblkullanici.Size = new System.Drawing.Size(111, 20);
            this.lblkullanici.TabIndex = 10;
            this.lblkullanici.Text = "Kullanıcı Adı :";
            // 
            // tbEmail
            // 
            this.tbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tbEmail.Location = new System.Drawing.Point(309, 167);
            this.tbEmail.Name = "tbEmail";
            this.tbEmail.Size = new System.Drawing.Size(333, 27);
            this.tbEmail.TabIndex = 0;
            this.tbEmail.Text = "halit.hatahet@sekreter.com";
            this.tbEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btGiris
            // 
            this.btGiris.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btGiris.Location = new System.Drawing.Point(540, 261);
            this.btGiris.Name = "btGiris";
            this.btGiris.Size = new System.Drawing.Size(104, 37);
            this.btGiris.TabIndex = 2;
            this.btGiris.Text = "Giriş";
            this.btGiris.UseVisualStyleBackColor = false;
            this.btGiris.Click += new System.EventHandler(this.btGiris_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImage = global::BizimProje.Properties.Resources.sa55;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(134, 127);
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // lblMessage
            // 
            this.lblMessage.AutoSize = true;
            this.lblMessage.Location = new System.Drawing.Point(295, 119);
            this.lblMessage.Name = "lblMessage";
            this.lblMessage.Size = new System.Drawing.Size(0, 17);
            this.lblMessage.TabIndex = 15;
            // 
            // GirisEkrani
            // 
            this.AcceptButton = this.btGiris;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = global::BizimProje.Properties.Resources.giris;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(874, 506);
            this.Controls.Add(this.lblMessage);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btGiris);
            this.Controls.Add(this.lblsifre);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lblkullanici);
            this.Controls.Add(this.tbEmail);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(892, 553);
            this.MinimumSize = new System.Drawing.Size(892, 553);
            this.Name = "GirisEkrani";
            this.Text = "Giriş Ekranı";
            this.Load += new System.EventHandler(this.GirisEkrani_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        #endregion

        private System.Windows.Forms.Button btGiris;
        private System.Windows.Forms.Label lblsifre;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label lblkullanici;
        private System.Windows.Forms.TextBox tbEmail;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblMessage;
    }
}