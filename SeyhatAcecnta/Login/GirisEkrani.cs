using Business.Concrete;
using DataAccess.Concrete;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class GirisEkrani : Form
    {
        public GirisEkrani()
        {
            InitializeComponent();
        }
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        public string kullaniciAdi { get; set; }
        public string Sifre { get; set; }
        private void Giris_Click(object sender, EventArgs e)
        {
            kullaniciAdi = txt_KullaniciAdi.Text;
            Sifre = txt_Sifre.Text;
            if (kullaniciManager.Valitadion(kullaniciAdi,Sifre))
            {
               
                RezervasyonEkrani rezervasyonEkrani = new RezervasyonEkrani() { 
                    KullaniciAdi=kullaniciAdi,
                    Sifre=Sifre
                };
                rezervasyonEkrani.Show();
                this.Hide();
            }
            else
            {
                Console.WriteLine("Şifre veya KullaniciAdi Yanlış");
            }
        }
    }
}
