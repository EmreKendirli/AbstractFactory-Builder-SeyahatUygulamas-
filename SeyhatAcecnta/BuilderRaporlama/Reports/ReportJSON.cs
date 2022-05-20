using BuilderRaporlama.ReportBuilderBas;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;
using Entities.Entity;
using Business.Concrete;
using DataAccess.Concrete;

namespace BuilderRaporlama.Reports
{
   public class ReportJSON : ReportBuilderBase
    {
        UlasimBilgi ulasimBilgi = new UlasimBilgi();
        SeyhatBilgileri seyhatBilgi = new SeyhatBilgileri();
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        SeyhatBilgiManager seyhatBilgiManager = new SeyhatBilgiManager(new EFSeyhatBilgiDal());
        UlasimAracManager ulasim = new UlasimAracManager(new EFUlasimAracDal());
        KonaklamaBilgiManager konaklama = new KonaklamaBilgiManager(new EFKonaklamaDal());

        public override void RaporKaydet()
        {
            int a = 2;

            System.IO.File.WriteAllText(@"C:\Users\EMRE\Desktop\" + a+"json.json", sb.ToString());

        }

        public override void SeyehatBilgileriniGetir(int id)
        {
            var kaldigiGünSayisi = seyhatBilgiManager.GetId(id).RezervasyonBitis.Day - seyhatBilgiManager.GetId(id).RezervasyonBaslangic.Day;
            var konaklamaId = seyhatBilgiManager.GetId(id).KonaklamaID;
            //var konaklamaID = seyhatBilgi.GetId(id).KonaklamaID;
            //var adi = kullaniciManager.GetId(id).Adi;
            //var soyadi = kullaniciManager.GetId(id).Soyadi;
            //var SirketAdi = konaklama.GetId(konaklamaID).SirketAdi;
            //var KonaklamaTipi = konaklama.GetId(konaklamaID).KonaklamaTipi;
            //var ucret = konaklama.GetId(konaklamaID).ucret;
            //var tatilYeri = konaklama.GetId(konaklamaID).TatilYeri;
            seyhatBilgi.SeyhatAdi = "Konaklama Bilgileri";
            seyhatBilgi.Adi= kullaniciManager.GetId(id).Adi;
            seyhatBilgi.Soyadi= kullaniciManager.GetId(id).Soyadi;
            seyhatBilgi.Sirket_Adi = konaklama.GetId(konaklamaId).SirketAdi;
            seyhatBilgi.Konaklama_Tipi = konaklama.GetId(konaklamaId).KonaklamaTipi;
            seyhatBilgi.Tatil_Yeri = konaklama.GetId(konaklamaId).TatilYeri;
            seyhatBilgi.BaslangicTarihi = seyhatBilgiManager.GetId(id).RezervasyonBaslangic;
            seyhatBilgi.BitisTarihi = seyhatBilgiManager.GetId(id).RezervasyonBitis;
            seyhatBilgi.ucret = konaklama.GetId(konaklamaId).ucret*kaldigiGünSayisi;

            sb.Append(JsonConvert.SerializeObject(seyhatBilgi));
        }

        public override void UlasimBilgileriniGetir(int id)
        {
            var kalkisYeriID = seyhatBilgiManager.GetId(id).UlasimID;
            ulasimBilgi.UlasimAdi = "Ulasim Bilgileri";
            ulasimBilgi.Adi = kullaniciManager.GetId(id).Adi;
            ulasimBilgi.Soyadi = kullaniciManager.GetId(id).Soyadi;
            ulasimBilgi.KalkisYeri = ulasim.GetId(kalkisYeriID).KalkisYeri;
            ulasimBilgi.VarisYeri = ulasim.GetId(kalkisYeriID).VarisYeri;
            ulasimBilgi.KalkisSaati = ulasim.GetId(kalkisYeriID).KalkisSaati;
            ulasimBilgi.VarisSaati = ulasim.GetId(kalkisYeriID).VarisSaati;
            ulasimBilgi.ucret = ulasim.GetId(kalkisYeriID).Ucret * 2;

            sb.Append(JsonConvert.SerializeObject(ulasimBilgi));
        }
    }
    class UlasimBilgi
    {
        public string UlasimAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        public string KalkisSaati { get; set; }
        public string VarisSaati { get; set; }
        public int ucret { get; set; }

    }
    class SeyhatBilgileri
    {
        public string SeyhatAdi { get; set; }
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string Sirket_Adi { get; set; }
        public string Konaklama_Tipi { get; set; }
        public string Tatil_Yeri { get; set; }
        public DateTime BaslangicTarihi { get; set; }
        public DateTime BitisTarihi { get; set; }
        public int ucret { get; set; }

    }
}
