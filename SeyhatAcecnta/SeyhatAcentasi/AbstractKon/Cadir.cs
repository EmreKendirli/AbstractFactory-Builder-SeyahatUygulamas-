using Business.Concrete;
using DataAccess.Abstact;
using DataAccess.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractKonakla
{
    public class Cadir : AbstractKonaklama
    {
        KonaklamaBilgiManager konaklamaBilgiManager = new KonaklamaBilgiManager(new EFKonaklamaDal());
        public override int KonaklamaFiyat(int fiyat)
        {

            return fiyat;
        }

        public override List<KonaklamaDetailDto> konaklamaListele(string konaklamaYeri, string konaklamaTipi)
        {
            return konaklamaBilgiManager.konaklamaDetailDtos(konaklamaYeri, konaklamaTipi);
        }
    }
}
