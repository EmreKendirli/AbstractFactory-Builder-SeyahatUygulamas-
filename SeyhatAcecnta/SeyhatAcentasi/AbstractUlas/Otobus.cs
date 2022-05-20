using Business.Concrete;
using DataAccess.Concrete;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Linq.Expressions;
using Entities.DTO;

namespace SeyhatAcecntasi.AbstractUlas
{
    public class Otobus : AbstractUlasim
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
