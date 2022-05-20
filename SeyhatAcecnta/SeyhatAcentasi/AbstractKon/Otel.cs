using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractKonakla
{
    public class Otel : AbstractKonaklama
    {
        public override int KonaklamaFiyat(int fiyat)
        {

            return fiyat;

        }

        public override List<KonaklamaDetailDto> konaklamaListele(string konaklamaYeri, string konaklamaTipi)
        {
            throw new NotImplementedException();
        }
    }
}
