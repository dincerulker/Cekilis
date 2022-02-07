
namespace KosuMesafe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.txtAdimCm = new System.Windows.Forms.TextBox();
            this.txtAdimSayi = new System.Windows.Forms.TextBox();
            this.txtKosuSaat = new System.Windows.Forms.TextBox();
            this.txtKosuDakika = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMesafe = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtAdimCm
            // 
            this.txtAdimCm.Location = new System.Drawing.Point(206, 35);
            this.txtAdimCm.Name = "txtAdimCm";
            this.txtAdimCm.Size = new System.Drawing.Size(100, 20);
            this.txtAdimCm.TabIndex = 0;
            this.txtAdimCm.TextChanged += new System.EventHandler(this.txtAdimCm_TextChanged);
            // 
            // txtAdimSayi
            // 
            this.txtAdimSayi.Location = new System.Drawing.Point(206, 61);
            this.txtAdimSayi.Name = "txtAdimSayi";
            this.txtAdimSayi.Size = new System.Drawing.Size(100, 20);
            this.txtAdimSayi.TabIndex = 1;
            this.txtAdimSayi.TextChanged += new System.EventHandler(this.txtAdimSayi_TextChanged);
            // 
            // txtKosuSaat
            // 
            this.txtKosuSaat.Location = new System.Drawing.Point(206, 87);
            this.txtKosuSaat.Name = "txtKosuSaat";
            this.txtKosuSaat.Size = new System.Drawing.Size(100, 20);
            this.txtKosuSaat.TabIndex = 2;
            this.txtKosuSaat.TextChanged += new System.EventHandler(this.txtKosuSaat_TextChanged);
            // 
            // txtKosuDakika
            // 
            this.txtKosuDakika.Location = new System.Drawing.Point(206, 113);
            this.txtKosuDakika.Name = "txtKosuDakika";
            this.txtKosuDakika.Size = new System.Drawing.Size(100, 20);
            this.txtKosuDakika.TabIndex = 3;
            this.txtKosuDakika.TextChanged += new System.EventHandler(this.txtKosuDakika_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bir adımınızı cm cinsinden giriniz";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(175, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "1 dakikada kaç adım attığınızı giriniz";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Kaç saat koşu yaptığınızı giriniz";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(164, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Kaç dakika koşu yaptığınızı giriniz";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(57, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "ADIM KOŞU MESAFESİ HESAPLAMA";
            // 
            // txtMesafe
            // 
            this.txtMesafe.Location = new System.Drawing.Point(206, 184);
            this.txtMesafe.Name = "txtMesafe";
            this.txtMesafe.Size = new System.Drawing.Size(100, 20);
            this.txtMesafe.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(151, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Toplam koşu yaptığınız mesafe";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(122, 147);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(75, 23);
            this.btnHesapla.TabIndex = 11;
            this.btnHesapla.Text = "HESAPLA";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 236);
            this.label7.MaximumSize = new System.Drawing.Size(300, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(294, 52);
            this.label7.TabIndex = 12;
            this.label7.Text = resources.GetString("label7.Text");
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::KosuMesafe.Properties.Resources.runner;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(313, 320);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMesafe);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKosuDakika);
            this.Controls.Add(this.txtKosuSaat);
            this.Controls.Add(this.txtAdimSayi);
            this.Controls.Add(this.txtAdimCm);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Koşu-Mesafe Hesaplama";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtAdimCm;
        private System.Windows.Forms.TextBox txtAdimSayi;
        private System.Windows.Forms.TextBox txtKosuSaat;
        private System.Windows.Forms.TextBox txtKosuDakika;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMesafe;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Label label7;
    }
}

