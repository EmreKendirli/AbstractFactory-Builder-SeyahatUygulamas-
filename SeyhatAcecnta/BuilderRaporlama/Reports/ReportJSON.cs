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
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        SeyhatBilgiManager seyhatBilgi = new SeyhatBilgiManager(new EFSeyhatBilgiDal());
        UlasimAracManager ulasim = new UlasimAracManager(new EFUlasimAracDal());

        public override void RaporKaydet()
        {
            int a = 2;

            System.IO.File.WriteAllText(@"C:\Users\EMRE\Desktop\" + a+"json.json", sb.ToString());

        }

        public override void SeyehatBilgileriniGetir(int id)
        {
            var kalkisYeriID = seyhatBilgi.GetId(id).UlasimID;

            ulasimBilgi.Adi = kullaniciManager.GetId(id).Adi;
            ulasimBilgi.Soyadi = kullaniciManager.GetId(id).Soyadi;
            ulasimBilgi.KalkisYeri= ulasim.GetId(kalkisYeriID).KalkisYeri;
            ulasimBilgi.VarisYeri = ulasim.GetId(kalkisYeriID).VarisYeri;
            ulasimBilgi.KalkisSaati= ulasim.GetId(kalkisYeriID).KalkisSaati;
            ulasimBilgi.VarisSaati = ulasim.GetId(kalkisYeriID).VarisSaati;
            ulasimBilgi.ucret= ulasim.GetId(kalkisYeriID).Ucret*2;

            sb.Append(JsonConvert.SerializeObject(ulasimBilgi));
        }

        public override void UlasimBilgileriniGetir(int id)
        {
            var kalkisYeriID = seyhatBilgi.GetId(id).UlasimID;

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
        public string Adi { get; set; }
        public string Soyadi { get; set; }
        public string KalkisYeri { get; set; }
        public string VarisYeri { get; set; }
        public string KalkisSaati { get; set; }
        public string VarisSaati { get; set; }
        public int ucret { get; set; }

    }
}
