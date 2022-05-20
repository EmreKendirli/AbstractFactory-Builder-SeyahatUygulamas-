using Entities.DTO;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractUlas
{
    public abstract class AbstractUlasim
    {
        public abstract int UlasimFiyat(int fiyat);
        public abstract List<UlasimDetailDto> listele(string kalkis, string varis, string aracTipi);
    }
}
