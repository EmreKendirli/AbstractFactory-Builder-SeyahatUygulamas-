using Entities.DTO;
using SeyhatAcecntasi.AbstractKonakla;
using SeyhatAcecntasi.AbstractKSey;
using SeyhatAcecntasi.AbstractUlas;
using System;
using System.Collections.Generic;
using System.Text;


namespace SeyhatAcecntasi
{
    public class SeyhatManager
    {
        private AbstractKonaklama _abstractKonaklama;
        private AbstractSeyhat _abstractSeyhat;
        private AbstractUlasim _abstractUlasim;
        public SeyhatManager(AbstractSeyhat abstractSeyhat)
        {
            _abstractSeyhat = abstractSeyhat;
            _abstractKonaklama = abstractSeyhat.Konaklama();
            _abstractUlasim = abstractSeyhat.Ulasim();
        }
        
        public int KonaklamaFiyatGetir(int konaklama)
        {
            return _abstractKonaklama.KonaklamaFiyat(konaklama);
        }
        public int UlasimFiyatGetir(int ulasim)
        {
            return _abstractUlasim.UlasimFiyat(ulasim);
        }
        public List<UlasimDetailDto> UlasimListele(string kalkis, string varis, string aracTipi)
        {
            return _abstractUlasim.listele(kalkis, varis, aracTipi);
        }
        public List<KonaklamaDetailDto> UlasimListele(string konaklamaYeri, string konaklamaTipi)
        {
            return _abstractKonaklama.konaklamaListele(konaklamaYeri, konaklamaTipi);
        }
    }
}
