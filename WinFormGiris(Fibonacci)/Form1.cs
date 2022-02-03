using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormGiris_Fibonacci_
{
    public partial class Form1 : Form
    {
        int olcek = 40;
        public Form1()
        {
            InitializeComponent();
            lstSayilar.DataSource = Fibonacci(); // DataSource yalnızca dizi ve list te çalışır.
        }
        public List<long> Fibonacci()
        {
            List<long> fibo = new List<long>() { 0, 1 };
            while (fibo.Count < 40)
                fibo.Add(fibo[fibo.Count - 1] + fibo[fibo.Count - 2]);

            return fibo;
        }

        // panel boyanırken çalışan metod
        private void pnlCizim_Paint(object sender, PaintEventArgs e)
        {
            List<long> sayilar = Fibonacci();
            Graphics g = e.Graphics;
            Pen kalem = new Pen(Color.Lime, 3f);
            // g.DrawLine(kalem, 50, 100, 300, 300); // (kalem,x1,y1,x2,y2)

            g.FillEllipse(Brushes.Red, -5, -5, 10, 10); // Başlangıç noktası
            for (int i = 1; i < sayilar.Count; i++)
            {
                int x1 = (i - 1) * olcek;
                long y1 = sayilar[i - 1];
                int x2 = i * olcek;
                long y2 = sayilar[i];
                                
                g.DrawLine(kalem, x1, y1, x2, y2);
                // grafikteki kesişme noktaları kırmızı nokta
                g.FillEllipse(Brushes.Red, x2-5, y2-5, 10, 10);
            }
        }
    }
}
