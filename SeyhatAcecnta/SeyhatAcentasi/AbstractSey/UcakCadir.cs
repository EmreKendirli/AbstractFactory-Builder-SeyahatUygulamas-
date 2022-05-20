using SeyhatAcecntasi.AbstractKonakla;
using SeyhatAcecntasi.AbstractKSey;
using SeyhatAcecntasi.AbstractUlas;
using System;
using System.Collections.Generic;
using System.Text;

namespace SeyhatAcecntasi.AbstractSey
{
    public class UcakCadir : AbstractSeyhat
    {
        public override AbstractKonaklama Konaklama()
        {
            return new Cadir();
        }

        public override AbstractUlasim Ulasim()
        {
            return new Ucak();
        }
    }
}
