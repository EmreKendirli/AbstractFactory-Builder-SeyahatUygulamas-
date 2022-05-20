using BuilderRaporlama.ReportBuilderBas;
using Business.Concrete;
using DataAccess.Concrete;
using Microsoft.Extensions.Primitives;
using System;
using System.Collections.Generic;
using System.Text;


namespace BuilderRaporlama.Reports
{
    public class ReportHTML : ReportBuilderBase
    {
        KullaniciManager kullaniciManager = new KullaniciManager(new EFKullaniciDal());
        SeyhatBilgiManager seyhatBilgi = new SeyhatBilgiManager(new EFSeyhatBilgiDal());
        UlasimAracManager ulasim = new UlasimAracManager(new EFUlasimAracDal());
        KonaklamaBilgiManager konaklama = new KonaklamaBilgiManager(new EFKonaklamaDal());
        public override void RaporKaydet()
        {
            System.IO.File.WriteAllText(@"C:\Users\EMRE\Desktop\html.html", sb.ToString());
        }

        public override void SeyehatBilgileriniGetir(int id)
        {
            var konaklamaID = seyhatBilgi.GetId(id).KonaklamaID;
            var adi = kullaniciManager.GetId(id).Adi;
            var soyadi = kullaniciManager.GetId(id).Soyadi;
            var SirketAdi = konaklama.GetId(konaklamaID).SirketAdi;
            var KonaklamaTipi = konaklama.GetId(konaklamaID).KonaklamaTipi;
            var ucret = konaklama.GetId(konaklamaID).ucret;
            var tatilYeri = konaklama.GetId(konaklamaID).TatilYeri;
            var baslangiçTarihi = seyhatBilgi.GetId(id).RezervasyonBaslangic;
            var BitisTarihi = seyhatBilgi.GetId(id).RezervasyonBitis;
            int kaldigiGünSayisi = BitisTarihi.Day - baslangiçTarihi.Day;

            sb.Append("<h3>SEYHAT BİLGİLERİ </h3>"); //Tablonun başlığı yazıldı
            sb.Append("<table class=\"display\" id=\"dt\" style=\"align: left; width: 99%;\" ");
            sb.Append("rules=\"all\" border=\"1px\" ");
            sb.Append("cellspacing=\"0px\" cellpadding=\"4px\">");

            sb.Append("<thead>");
            sb.Append("<tr></tr>");
            sb.Append("<tr style=\"background-color: Silver; color: #212121; ");
            sb.Append("font-weight: bold\">");


            sb.Append("<tr> <th>Adı</th> <th> Soyadı</th> <th>Şirket Adi</th><th>Konaklama Tipi</th><th>Tatil Yeri</th><th>Rezervasyon Başlangıç Tarihi</th><th>Rezervasyon Bitiş Tarihi</th><th>Ucret</th></tr>"); //Tablonun sütun isimleri yazıldı
            sb.Append("<tr> <td>" + adi + "</td> <td> " + soyadi + "</td> <td>" + SirketAdi + "</td><td>" + KonaklamaTipi + "</td><td>" + tatilYeri + "</td><td>" + baslangiçTarihi + "</td><td>" + BitisTarihi + "</td><td>" + ucret*kaldigiGünSayisi + "</td></tr>"); //Tablonun sütun isimleri yazıldı
            sb.Append("</table>");

        }

        public override void UlasimBilgileriniGetir(int id)
        {
            var kalkisYeriID = seyhatBilgi.GetId(id).UlasimID;

            var adi = kullaniciManager.GetId(id).Adi;
            var soyadi = kullaniciManager.GetId(id).Soyadi;
            var kalkisYeri = ulasim.GetId(kalkisYeriID).KalkisYeri;
            var VarisYeri = ulasim.GetId(kalkisYeriID).VarisYeri;
            var KalkisSaati = ulasim.GetId(kalkisYeriID).KalkisSaati;
            var VarisSaati = ulasim.GetId(kalkisYeriID).VarisSaati;
            var ucret = ulasim.GetId(kalkisYeriID).Ucret;
            sb.Append("<h3>Ulaşım BİLGİLERİ </h3>"); //Tablonun başlığı yazıldı
            sb.Append("<table class=\"display\" id=\"dt\" style=\"align: left; width: 99%;\" ");
            sb.Append("rules=\"all\" border=\"1px\" ");
            sb.Append("cellspacing=\"0px\" cellpadding=\"4px\">");

            sb.Append("<thead>");
            sb.Append("<tr></tr>");
            sb.Append("<tr style=\"background-color: Silver; color: #212121; ");
            sb.Append("font-weight: bold\">");


            sb.Append("<tr> <th>Adı</th> <th> Soyadı</th> <th>Kalkış yeri</th><th>Varış yeri</th><th>kalkış saati</th><th>varış saati</th><th>Ucret</th></tr>"); //Tablonun sütun isimleri yazıldı
            sb.Append("<tr> <td>" + adi + "</td> <td> " + soyadi + "</td> <td>" + kalkisYeri + "</td><td>" + VarisYeri + "</td><td>" + KalkisSaati + "</td><td>" + VarisSaati + "</td><td>" + ucret * 2 + "</td></tr>"); //Tablonun sütun isimleri yazıldı
            sb.Append("</table>");
        }
    }
}
