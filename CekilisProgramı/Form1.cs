using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CekilisProgramı
{
    public partial class Form1 : Form
    {
        List<string> adlar;
        Random rnd = new Random();
        public Form1()
        {
            InitializeComponent();
            VerileriOku();
            Listele();

        }

        private void VerileriOku()
        {
            try
            {
                adlar = File.ReadAllLines("adlar.txt").ToList(); // adlar.txt yi oku
            }
            catch (Exception)
            {

                adlar = new List<string>(); // eğer liste boşsa boş listeyle başla
            }
        }

        void Karistir(List<string> liste)
        {
            int talihliIndeks;
            string gecici;
            for (int i = 0; i < liste.Count - 1; i++)
            {
                talihliIndeks = rnd.Next(i, liste.Count);
                gecici = liste[i];
                liste[i] = liste[talihliIndeks];
                liste[talihliIndeks] = gecici;
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Hata kontrolü
            string ad = txtAd.Text.Trim();
            if (ad == "")
            {
                MessageBox.Show("Eklemek için bir ad girmelisiniz".ToUpper());
                return; // programı burda kesmek için return ekledik
            }
            //mevcut seçili indeksi not al

            int sid = lstAdlar.SelectedIndex;
            // Verinin eklenmesi
            adlar.Add(ad);

            //formun temizlenmesi
            txtAd.Clear();
            txtAd.Focus();
            // listbox güncelleme
            Listele();
            lstAdlar.SelectedIndex = sid; // yeni eleman eklendiğinde önceden seçili olan kişi seçili kalır.

        }

        private void Listele()
        {
            lstAdlar.Items.Clear();
            foreach (string ad in adlar)
            {
                lstAdlar.Items.Add(ad.ToUpper());
            }
        }

        private void txtAd_KeyDown(object sender, KeyEventArgs e) // txtBox + events + keydown + doubleclick
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // enter a basılmamış gibi davran, olmasa tuşa basınca "dın" sesi gelir.
                btnEkle.PerformClick(); // Enter a basınca butona click yapar
            }
        }

        private void btnCekilis_Click(object sender, EventArgs e)
        {
            if (adlar.Count == 0) return;
            Karistir(adlar);
            lblSonuc.Text = adlar[0];
            if (chkKaldir.Checked)
                adlar.RemoveAt(0);
            Listele();


        }

        private void lstAdlar_KeyDown(object sender, KeyEventArgs e)
        {
            int sid = lstAdlar.SelectedIndex;
            if (e.KeyCode == Keys.Delete && sid > -1)
            {
                adlar.RemoveAt(sid);
                Listele();

                if (sid < 0 || sid >= adlar.Count - 1) // sildiğimizde mavi çizgi aynı yerde kalması için
                {
                    lstAdlar.SelectedIndex = sid - 1;
                }
                else
                {
                    lstAdlar.SelectedIndex = sid;
                }
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult dr = MessageBox.Show(
                text:"Program Kapatılacaktır. Değişiklikleri kaydetmek istiyor musunuz?",
                caption: "Çekiliş",
                buttons: MessageBoxButtons.YesNoCancel,
                icon: MessageBoxIcon.Question, 
                defaultButton: MessageBoxDefaultButton.Button3);
            switch (dr)
            {

                case DialogResult.Cancel:
                    e.Cancel = true;
                    break;
                case DialogResult.Yes:
                    File.WriteAllLines("adlar.txt", adlar);
                    break;
                case DialogResult.No:
                    break;
                default:
                    break;
            }


        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int sid = lstAdlar.SelectedIndex;
            if (sid < 1)
            {
                return;
            }
            string gecici = adlar[sid - 1];
            adlar[sid - 1] = adlar[sid];
            adlar[sid] = gecici;
            Listele();
            lstAdlar.SelectedIndex = sid - 1;


        }

        private void btnDown_Click(object sender, EventArgs e)
        {
            int sid = lstAdlar.SelectedIndex;
            if (sid < 0 || sid >= adlar.Count - 1)
            {
                return;
            }
            string gecici = adlar[sid + 1];
            adlar[sid + 1] = adlar[sid];
            adlar[sid] = gecici;
            Listele();
            lstAdlar.SelectedIndex = sid + 1;
        }

        private void lstAdlar_SelectedIndexChanged(object sender, EventArgs e)
        {
            btnUp.Enabled = lstAdlar.SelectedIndex > 0;
            btnDown.Enabled = lstAdlar.SelectedIndex != lstAdlar.Items.Count - 1;
        }
    }
}
