using BuilderRaporlama.ReportBuilderBas;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderRaporlama
{
    public class ReportManager
    {
        private ReportBuilderBase _reportBuilder;
        public ReportManager(ReportBuilderBase report) //Kurucu metodu ReportBuilderBase tipinde bir parametre alır
        {
            _reportBuilder = report;
        }
        public void HTMLRaporGetir(int id)
        {
           _reportBuilder.SeyehatBilgileriniGetir(id);
            _reportBuilder.UlasimBilgileriniGetir(id);
        }
        public void JSONRaporGetir(int id)
        {
            _reportBuilder.SeyehatBilgileriniGetir(id);
            _reportBuilder.UlasimBilgileriniGetir(id);
        }
        public void XMLRaporGetir(int id)
        {
            _reportBuilder.SeyehatBilgileriniGetir(id);
        }

        public void RaporAl()
        {
            //Soyut sınıfta bulunan (ReporrKaytBuilderBase) Raporkaydet() metoduna erişilir ve uygun formatta Rapor alınır
            _reportBuilder.RaporKaydet();
        }
    }
}
