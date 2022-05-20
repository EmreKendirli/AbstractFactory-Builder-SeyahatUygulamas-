using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderRaporlama.ReportBuilderBas
{
    public abstract class ReportBuilderBase
    {
        protected StringBuilder sb = new StringBuilder();
        public abstract void SeyehatBilgileriniGetir(int id);
        public abstract void UlasimBilgileriniGetir(int id);
        public abstract void RaporKaydet(); //Raporu kaydetmek için gerekli işlemleri yapar
    }
}
