using BuilderRaporlama;
using BuilderRaporlama.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace WindowsUI
{
    public partial class Raporlama : Form
    {
        public Raporlama()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "HTML | *.html| XML |*xml |JSON | *.json";
            int id = 1;
            if (comboBox1.Text =="HTML")
            {
                ReportManager reportManager = new ReportManager(new ReportHTML());
                reportManager.HTMLRaporGetir(id);
                reportManager.RaporAl();
                /*reportManager.HTMLRaporGetir(a);
                reportManager.RaporAl();
                StreamWriter streamWriter = new StreamWriter(@"C:\Users\EMRE\Desktop");
                streamWriter.Write(reportManager.HTMLRaporGetir(a));*/
            }
            else if (comboBox1.Text == "JSON")
            {
                ReportManager reportManager = new ReportManager(new ReportJSON());
                reportManager.JSONRaporGetir(id);
                reportManager.RaporAl();
            }
            else if (comboBox1.Text == "XML")
            {

            }
            else
            {
                MessageBox.Show("Boş Geçmeyin");
            }
        }
    }
}
