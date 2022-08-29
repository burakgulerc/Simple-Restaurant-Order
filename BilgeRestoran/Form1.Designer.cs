namespace BilgeRestoran
{
    partial class Form1
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
            this.txtSiparisIsmi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCiro = new System.Windows.Forms.Button();
            this.lstSiparis = new System.Windows.Forms.ListBox();
            this.grbAraSicak = new System.Windows.Forms.GroupBox();
            this.grbAnaYemek = new System.Windows.Forms.GroupBox();
            this.grbIcecek = new System.Windows.Forms.GroupBox();
            this.grbTatli = new System.Windows.Forms.GroupBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.checkBox8 = new System.Windows.Forms.CheckBox();
            this.checkBox9 = new System.Windows.Forms.CheckBox();
            this.checkBox10 = new System.Windows.Forms.CheckBox();
            this.checkBox11 = new System.Windows.Forms.CheckBox();
            this.checkBox13 = new System.Windows.Forms.CheckBox();
            this.checkBox14 = new System.Windows.Forms.CheckBox();
            this.checkBox15 = new System.Windows.Forms.CheckBox();
            this.checkBox16 = new System.Windows.Forms.CheckBox();
            this.grbAraSicak.SuspendLayout();
            this.grbAnaYemek.SuspendLayout();
            this.grbIcecek.SuspendLayout();
            this.grbTatli.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSiparisIsmi
            // 
            this.txtSiparisIsmi.Location = new System.Drawing.Point(81, 91);
            this.txtSiparisIsmi.Name = "txtSiparisIsmi";
            this.txtSiparisIsmi.Size = new System.Drawing.Size(117, 31);
            this.txtSiparisIsmi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(37, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Lütfen Masa No Giriniz:";
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(501, 572);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(175, 55);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "Sipariş Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCiro
            // 
            this.btnCiro.Location = new System.Drawing.Point(1011, 572);
            this.btnCiro.Name = "btnCiro";
            this.btnCiro.Size = new System.Drawing.Size(190, 55);
            this.btnCiro.TabIndex = 6;
            this.btnCiro.Text = "Ciro Hesapla";
            this.btnCiro.UseVisualStyleBackColor = true;
            this.btnCiro.Click += new System.EventHandler(this.btnCiro_Click);
            // 
            // lstSiparis
            // 
            this.lstSiparis.FormattingEnabled = true;
            this.lstSiparis.ItemHeight = 25;
            this.lstSiparis.Location = new System.Drawing.Point(12, 669);
            this.lstSiparis.Name = "lstSiparis";
            this.lstSiparis.Size = new System.Drawing.Size(1795, 229);
            this.lstSiparis.TabIndex = 7;
            // 
            // grbAraSicak
            // 
            this.grbAraSicak.Controls.Add(this.checkBox4);
            this.grbAraSicak.Controls.Add(this.checkBox2);
            this.grbAraSicak.Controls.Add(this.checkBox3);
            this.grbAraSicak.Controls.Add(this.checkBox1);
            this.grbAraSicak.Location = new System.Drawing.Point(335, 28);
            this.grbAraSicak.Name = "grbAraSicak";
            this.grbAraSicak.Size = new System.Drawing.Size(609, 231);
            this.grbAraSicak.TabIndex = 8;
            this.grbAraSicak.TabStop = false;
            this.grbAraSicak.Text = "Ara Sıcaklar";
            // 
            // grbAnaYemek
            // 
            this.grbAnaYemek.Controls.Add(this.checkBox8);
            this.grbAnaYemek.Controls.Add(this.checkBox7);
            this.grbAnaYemek.Controls.Add(this.checkBox5);
            this.grbAnaYemek.Controls.Add(this.checkBox6);
            this.grbAnaYemek.Location = new System.Drawing.Point(981, 28);
            this.grbAnaYemek.Name = "grbAnaYemek";
            this.grbAnaYemek.Size = new System.Drawing.Size(609, 231);
            this.grbAnaYemek.TabIndex = 9;
            this.grbAnaYemek.TabStop = false;
            this.grbAnaYemek.Text = "Ana Yemekler";
            // 
            // grbIcecek
            // 
            this.grbIcecek.Controls.Add(this.checkBox16);
            this.grbIcecek.Controls.Add(this.checkBox13);
            this.grbIcecek.Controls.Add(this.checkBox15);
            this.grbIcecek.Controls.Add(this.checkBox14);
            this.grbIcecek.Location = new System.Drawing.Point(335, 285);
            this.grbIcecek.Name = "grbIcecek";
            this.grbIcecek.Size = new System.Drawing.Size(609, 251);
            this.grbIcecek.TabIndex = 9;
            this.grbIcecek.TabStop = false;
            this.grbIcecek.Text = "İçecekler";
            // 
            // grbTatli
            // 
            this.grbTatli.Controls.Add(this.checkBox11);
            this.grbTatli.Controls.Add(this.checkBox9);
            this.grbTatli.Controls.Add(this.checkBox10);
            this.grbTatli.Location = new System.Drawing.Point(981, 285);
            this.grbTatli.Name = "grbTatli";
            this.grbTatli.Size = new System.Drawing.Size(609, 251);
            this.grbTatli.TabIndex = 9;
            this.grbTatli.TabStop = false;
            this.grbTatli.Text = "Tatlılar";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(47, 63);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(126, 29);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.Tag = "20";
            this.checkBox1.Text = "İçli Köfte";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(332, 63);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(123, 29);
            this.checkBox2.TabIndex = 0;
            this.checkBox2.Tag = "18";
            this.checkBox2.Text = "Çiğköfte";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(47, 145);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(144, 29);
            this.checkBox3.TabIndex = 0;
            this.checkBox3.Tag = "25";
            this.checkBox3.Text = "Lahmacun";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Location = new System.Drawing.Point(332, 145);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(223, 29);
            this.checkBox4.TabIndex = 0;
            this.checkBox4.Tag = "22";
            this.checkBox4.Text = "Patates Kızartması";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Location = new System.Drawing.Point(82, 52);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(106, 29);
            this.checkBox5.TabIndex = 0;
            this.checkBox5.Tag = "70";
            this.checkBox5.Text = "Adana";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Location = new System.Drawing.Point(82, 134);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(84, 29);
            this.checkBox6.TabIndex = 0;
            this.checkBox6.Tag = "65";
            this.checkBox6.Text = "Urfa";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Location = new System.Drawing.Point(367, 52);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(145, 29);
            this.checkBox7.TabIndex = 0;
            this.checkBox7.Tag = "60";
            this.checkBox7.Text = "Tavuk  Şiş";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // checkBox8
            // 
            this.checkBox8.AutoSize = true;
            this.checkBox8.Location = new System.Drawing.Point(367, 134);
            this.checkBox8.Name = "checkBox8";
            this.checkBox8.Size = new System.Drawing.Size(94, 29);
            this.checkBox8.TabIndex = 0;
            this.checkBox8.Tag = "65";
            this.checkBox8.Text = "Köfte";
            this.checkBox8.UseVisualStyleBackColor = true;
            // 
            // checkBox9
            // 
            this.checkBox9.AutoSize = true;
            this.checkBox9.Location = new System.Drawing.Point(82, 139);
            this.checkBox9.Name = "checkBox9";
            this.checkBox9.Size = new System.Drawing.Size(143, 29);
            this.checkBox9.TabIndex = 0;
            this.checkBox9.Tag = "20";
            this.checkBox9.Text = "Dondurma";
            this.checkBox9.UseVisualStyleBackColor = true;
            // 
            // checkBox10
            // 
            this.checkBox10.AutoSize = true;
            this.checkBox10.Location = new System.Drawing.Point(82, 57);
            this.checkBox10.Name = "checkBox10";
            this.checkBox10.Size = new System.Drawing.Size(121, 29);
            this.checkBox10.TabIndex = 0;
            this.checkBox10.Tag = "30";
            this.checkBox10.Text = "Baklava";
            this.checkBox10.UseVisualStyleBackColor = true;
            // 
            // checkBox11
            // 
            this.checkBox11.AutoSize = true;
            this.checkBox11.Location = new System.Drawing.Point(367, 57);
            this.checkBox11.Name = "checkBox11";
            this.checkBox11.Size = new System.Drawing.Size(116, 29);
            this.checkBox11.TabIndex = 0;
            this.checkBox11.Tag = "30";
            this.checkBox11.Text = "Şöbiyet";
            this.checkBox11.UseVisualStyleBackColor = true;
            // 
            // checkBox13
            // 
            this.checkBox13.AutoSize = true;
            this.checkBox13.Location = new System.Drawing.Point(47, 72);
            this.checkBox13.Name = "checkBox13";
            this.checkBox13.Size = new System.Drawing.Size(144, 29);
            this.checkBox13.TabIndex = 0;
            this.checkBox13.Tag = "15";
            this.checkBox13.Text = "Coca Cola";
            this.checkBox13.UseVisualStyleBackColor = true;
            // 
            // checkBox14
            // 
            this.checkBox14.AutoSize = true;
            this.checkBox14.Location = new System.Drawing.Point(47, 154);
            this.checkBox14.Name = "checkBox14";
            this.checkBox14.Size = new System.Drawing.Size(197, 29);
            this.checkBox14.TabIndex = 0;
            this.checkBox14.Tag = "15";
            this.checkBox14.Text = "Coca Cola Light";
            this.checkBox14.UseVisualStyleBackColor = true;
            // 
            // checkBox15
            // 
            this.checkBox15.AutoSize = true;
            this.checkBox15.Location = new System.Drawing.Point(332, 72);
            this.checkBox15.Name = "checkBox15";
            this.checkBox15.Size = new System.Drawing.Size(100, 29);
            this.checkBox15.TabIndex = 0;
            this.checkBox15.Tag = "17";
            this.checkBox15.Text = "Sprite";
            this.checkBox15.UseVisualStyleBackColor = true;
            // 
            // checkBox16
            // 
            this.checkBox16.AutoSize = true;
            this.checkBox16.Location = new System.Drawing.Point(332, 154);
            this.checkBox16.Name = "checkBox16";
            this.checkBox16.Size = new System.Drawing.Size(100, 29);
            this.checkBox16.TabIndex = 0;
            this.checkBox16.Tag = "13";
            this.checkBox16.Text = "Ayran";
            this.checkBox16.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Chocolate;
            this.ClientSize = new System.Drawing.Size(1819, 955);
            this.Controls.Add(this.grbTatli);
            this.Controls.Add(this.grbIcecek);
            this.Controls.Add(this.grbAnaYemek);
            this.Controls.Add(this.grbAraSicak);
            this.Controls.Add(this.lstSiparis);
            this.Controls.Add(this.btnCiro);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtSiparisIsmi);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.grbAraSicak.ResumeLayout(false);
            this.grbAraSicak.PerformLayout();
            this.grbAnaYemek.ResumeLayout(false);
            this.grbAnaYemek.PerformLayout();
            this.grbIcecek.ResumeLayout(false);
            this.grbIcecek.PerformLayout();
            this.grbTatli.ResumeLayout(false);
            this.grbTatli.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSiparisIsmi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCiro;
        private System.Windows.Forms.ListBox lstSiparis;
        private System.Windows.Forms.GroupBox grbAraSicak;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.GroupBox grbAnaYemek;
        private System.Windows.Forms.CheckBox checkBox8;
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.GroupBox grbIcecek;
        private System.Windows.Forms.CheckBox checkBox16;
        private System.Windows.Forms.CheckBox checkBox13;
        private System.Windows.Forms.CheckBox checkBox15;
        private System.Windows.Forms.CheckBox checkBox14;
        private System.Windows.Forms.GroupBox grbTatli;
        private System.Windows.Forms.CheckBox checkBox11;
        private System.Windows.Forms.CheckBox checkBox9;
        private System.Windows.Forms.CheckBox checkBox10;
    }
}

