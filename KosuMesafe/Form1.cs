using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KosuMesafe
{
    public partial class Form1 : Form
    {
        double adimCm, adimSayi, kosuDakika, kosuSaat, toplamMesafe;

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            toplamMesafe = ((adimCm / 100) * adimSayi) * ((kosuSaat * 60) + kosuDakika);
            txtMesafe.Text = toplamMesafe.ToString();
        }

        public void txtKosuDakika_TextChanged(object sender, EventArgs e)
        {
        
            try
            {
                kosuDakika = Convert.ToInt32(txtKosuDakika.Text);
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Hatalı giriş yaptınız");
                return;
            }
            

        }

        public void txtKosuSaat_TextChanged(object sender, EventArgs e)
        {
       
            try
            {
                kosuSaat = Convert.ToInt32(txtKosuSaat.Text);
            }

            catch (FormatException ex)
            {
                MessageBox.Show("Hatalı giriş yaptınız");
                return;
            }
            
        }

        public void txtAdimSayi_TextChanged(object sender, EventArgs e)
        {
        
            try
            { adimSayi = Convert.ToInt32(txtAdimCm.Text); }
            catch (FormatException ex)
            {
                MessageBox.Show("Hatalı giriş yaptınız");
                return;
            }
            
        }

        public Form1()
        {
            InitializeComponent();
        }

        public void txtAdimCm_TextChanged(object sender, EventArgs e)
        {
       
            try
            {
                adimCm = Convert.ToInt32(txtAdimCm.Text);
            }
            catch (FormatException ex)
            {
                 MessageBox.Show("Hatalı giriş yaptınız");
                return;
            }
           
          

        }
    }
}
