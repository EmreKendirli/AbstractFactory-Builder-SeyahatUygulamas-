using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class RezervasyonEkrani : Form
    {
        public RezervasyonEkrani()
        {
            InitializeComponent();
        }

        public string KullaniciAdi { get; set; }
        public string Sifre { get; set; }
        private void button1_Click(object sender, EventArgs e)
        {
          
            KonaklamaEkrani konaklamaEkrani = new KonaklamaEkrani()
            {
                Konaklama = comboBox3.Text,
                Ulasim = comboBox4.Text,
                Varis = comboBox1.Text,
                Kalkis = comboBox2.Text,
                KullaniciAdi=KullaniciAdi,
                Sifre=Sifre
            };
            konaklamaEkrani.Show();
            this.Hide();
            
            /*ulasimEkrani.Show();
            this.Hide();*/
        }

        private void RezervasyonEkrani_Load(object sender, EventArgs e)
        {

        }
    }
}
