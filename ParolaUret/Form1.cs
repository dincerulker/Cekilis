using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParolaUret
{
    public partial class Form1 : Form
    {
       
        bool kucukHarfVarmi, buyukHarfVarmi, rakamVarmi, ozelKarakterVarMi;
        int sifreUzunlugu, sifreSayisi;
        
        private void txtSifreler_TextChanged(object sender, EventArgs e)
        {

        }

        Random rnd = new Random();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void btnUret_Click(object sender, EventArgs e)
        {
            string seciliKarakterler = "";
            txtSifreler.Text = ""; // her ürettiğinde textbox ı temizlemesi için
            kucukHarfVarmi = chkKucukHarf.Checked;
            buyukHarfVarmi = chkBuyukHarf.Checked;
            rakamVarmi = chkRakam.Checked;
            ozelKarakterVarMi = chkOzelKarakter.Checked;

            sifreSayisi = (int)nudSifreSayisi.Value;
            sifreUzunlugu = (int)nudSifreUzunlugu.Value;

            if (!(ozelKarakterVarMi || rakamVarmi || buyukHarfVarmi || kucukHarfVarmi))
            {
                MessageBox.Show("En az bir parametre seçiniz!");
                return;
            }

            KucukHarfEkle(ref seciliKarakterler);
            BuyukHarfEkle(ref seciliKarakterler);
            RakamEkle(ref seciliKarakterler);
            OzelKarakterEkle(ref seciliKarakterler);

            SifreUret(seciliKarakterler);
        }

        private void SifreUret(string seciliKarakterler)
        {
            for (int i = 0; i < sifreSayisi; i++)
            {
                string sifre = "";
                for (int j = 0; j < sifreUzunlugu; j++)
                {
                    sifre += seciliKarakterler[rnd.Next(seciliKarakterler.Length)];
                }
                txtSifreler.Text += (i + 1) +") " +sifre;
                txtSifreler.Text += "\r\n";
                txtSifreler.Text += "\r\n";
            }
        }

        private void OzelKarakterEkle(ref string seciliKarakterler)
        {
            if (ozelKarakterVarMi) // 33,47 58,64 91,96 123,126
            {
                for (int i = 33; i <= 47; i++) // 
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 58; i <= 64; i++) // 
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 91; i <= 96; i++) // 
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
                for (int i = 123; i <= 126; i++) // 
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }

           
        }

        private void RakamEkle(ref string seciliKarakterler)
        {
            if (rakamVarmi)
            {
                for (int i = 48; i <= 57; i++) // ASCII tablosunda 0=> 48, 9=>57
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }

         
        }

        private void BuyukHarfEkle(ref string seciliKarakterler)
        {
            if (buyukHarfVarmi)
            {
                for (int i = 65; i <= 90; i++) // ASCII tablosunda A=> 65, Z=>90
                {
                    seciliKarakterler += Convert.ToChar(i);
                }

            }

            
        }

        private void KucukHarfEkle(ref string seciliKarakterler)
        {
            if (kucukHarfVarmi)
            {
                for (int i = 97; i <= 122; i++) // ASCII tablosunda a=> 97, z=>122
                {
                    seciliKarakterler += Convert.ToChar(i);
                }
            }

            
        }
    }
}
