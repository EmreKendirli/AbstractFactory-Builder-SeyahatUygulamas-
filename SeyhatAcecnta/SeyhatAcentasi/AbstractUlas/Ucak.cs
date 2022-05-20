using Business.Concrete;
using DataAccess.Concrete;
using Entities.DTO;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractUlas
{
    public class Ucak : AbstractUlasim
    {
        UlasimAracManager ulasim = new UlasimAracManager(new EFUlasimAracDal());

        public override List<UlasimDetailDto> listele(string kalkis, string varis, string aracTipi)
        {
            return ulasim.GetUlasimDetailDtos(kalkis, varis, aracTipi);
        }

        public override int UlasimFiyat(int fiyat)
        {
            return fiyat;

        }
    }
}
