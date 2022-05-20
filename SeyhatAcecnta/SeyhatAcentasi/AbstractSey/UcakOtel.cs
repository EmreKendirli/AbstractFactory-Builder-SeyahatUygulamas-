using SeyhatAcecntasi.AbstractKonakla;
using SeyhatAcecntasi.AbstractKSey;
using SeyhatAcecntasi.AbstractUlas;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractSey
{
    public class UcakOtel : AbstractSeyhat
    {
        public override AbstractKonaklama Konaklama()
        {
            return new Otel();
        }

        public override AbstractUlasim Ulasim()
        {
            return new Ucak();
        }
    }
}
