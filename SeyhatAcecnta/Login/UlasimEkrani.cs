using Business.Concrete;
using DataAccess.Concrete;
using Entities.DTO;
using Entities.Entity;
using SeyhatAcecntasi;
using SeyhatAcecntasi.AbstractSey;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class UlasimEkrani : Form
    {

        public int SeyhatId { get; set; }
        public int UlasimID { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        public string AracTipi { get; set; }
        public string KonaklamaTipi { get; set; }
        public string kullanici { get; set; }
        public string Sifree { get; set; }
        public int KonaklamaFiyat { get; set; }
        int UlasimFiyat = 0;

        public UlasimEkrani()
        {
            InitializeComponent();
        }
       // UlasimAracManager ulasimAracManager = new UlasimAracManager(new EFUlasimAracDal());
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        SeyhatBilgiManager seyhatBilgiManager = new SeyhatBilgiManager(new EFSeyhatBilgiDal());
        private void button1_Click(object sender, EventArgs e)
        {

            // MessageBox.Show("" + kullanici+"  "+Sifree);
            /*  if (KonaklamaTipi == "Otel" && AracTipi == "Otobus")
              {
                  SeyhatManager seyhatManager = new SeyhatManager(new OtobusOtel());
                  MessageBox.Show("Otel ucreti: " + seyhatManager.KonaklamaFiyatGetir(KonaklamaFiyat));
                  MessageBox.Show("Otobus ucreti: " + seyhatManager.UlasimFiyatGetir(UlasimFiyat));

              }
              else if (KonaklamaTipi == "Otel" && AracTipi == "Ucak")
              {
                  SeyhatManager seyhatManager = new SeyhatManager(new UcakOtel());
                  MessageBox.Show("Ucak ucreti: " + seyhatManager.UlasimFiyatGetir(UlasimFiyat));
                  MessageBox.Show("Otel ucreti: " + seyhatManager.KonaklamaFiyatGetir(KonaklamaFiyat));

              }
              else if (KonaklamaTipi == "Cadir" && AracTipi == "Otobus")
              {
                  SeyhatManager seyhatManager = new SeyhatManager(new OtobusCadir());
                  MessageBox.Show("Otobus ucreti: " + seyhatManager.UlasimFiyatGetir(UlasimFiyat));
                  MessageBox.Show("Cadir ucreti: " + seyhatManager.KonaklamaFiyatGetir(KonaklamaFiyat));

              }
              else if (KonaklamaTipi == "Cadir" && AracTipi == "Ucak")
              {
                  SeyhatManager seyhatManager = new SeyhatManager(new UcakCadir());
                  MessageBox.Show("Otobus ucreti: " + seyhatManager.UlasimFiyatGetir(UlasimFiyat));
                  MessageBox.Show("Ucak ucreti: " + seyhatManager.KonaklamaFiyatGetir(KonaklamaFiyat));

              }
              else { MessageBox.Show("Girmedi"); }

              int kullaniciID=kullaniciManager.KullaniciAdiVeSifresiIleIdGetir(kullanici, Sifree).Id;
              SeyhatBilgi seyhatBilgi = new SeyhatBilgi();
              seyhatBilgi.KullaniciId = kullaniciID;
              seyhatBilgi.KonaklamaID = SeyhatId;
              seyhatBilgi.UlasimID = UlasimID;
              seyhatBilgi.ToplamUcret = UlasimFiyat + KonaklamaFiyat;
              seyhatBilgiManager.add(seyhatBilgi);*/
            Raporlama raporlama = new Raporlama();
            raporlama.Show();
            this.Hide();



        }

        

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            UlasimFiyat =Convert.ToInt32( dataGridView1.Rows[secilen].Cells[6].Value);
            UlasimID= Convert.ToInt32(dataGridView1.Rows[secilen].Cells[0].Value);

        }

        private void RezervasyonEkrani_Load(object sender, EventArgs e)
        {
            if (KonaklamaTipi == "Otel" && AracTipi == "Otobus")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new OtobusOtel());
                dataGridView1.DataSource = seyhatManager.UlasimListele(KalkisYeri, VarisYeri, AracTipi);
                MessageBox.Show("1");
            }
            else if (KonaklamaTipi == "Otel" && AracTipi == "Ucak")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new UcakOtel());
                dataGridView1.DataSource = seyhatManager.UlasimListele(KalkisYeri, VarisYeri, AracTipi);
                MessageBox.Show("2");

            }
            else if (KonaklamaTipi == "Cadir" && AracTipi == "Otobus")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new OtobusCadir());
                dataGridView1.DataSource = seyhatManager.UlasimListele(KalkisYeri, VarisYeri, AracTipi);
                MessageBox.Show("3");

            }
            else if (KonaklamaTipi == "Cadir" && AracTipi == "Ucak")
            {
                SeyhatManager seyhatManager = new SeyhatManager(new UcakCadir());
                dataGridView1.DataSource = seyhatManager.UlasimListele(KalkisYeri, VarisYeri, AracTipi);

                MessageBox.Show("4");
            }
            else { MessageBox.Show("Girmedi"); }


           
        }
    }
}
