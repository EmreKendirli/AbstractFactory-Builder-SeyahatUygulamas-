using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractKonakla
{
    public abstract class AbstractKonaklama
    {
        public abstract List<KonaklamaDetailDto> konaklamaListele(string konaklamaYeri,string konaklamaTipi);
        public abstract int KonaklamaFiyat(int fiyat);
    }
}
