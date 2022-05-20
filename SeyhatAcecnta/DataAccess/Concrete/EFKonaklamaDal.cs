using Core.EntityFrameworkBase;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework;
using Entities.DTO;
using Entities.Entity;
using System;
using System.Linq;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete
{
    public class EFKonaklamaDal : EFEntityFrameworkBase<KonaklamaBilgi, EFSeyhatAcentaContex>, IKonaklamaBilgiDal
    {
        public KonaklamaDetailDto GetID(Expression<Func<KonaklamaDetailDto, bool>> fiter = null)
        {

            using (EFSeyhatAcentaContex contex = new EFSeyhatAcentaContex())
            {
                var result = from k in contex.KonaklamaYerleri
                             join v in contex.VarisYerleri
                             on k.SirketYeriID equals v.VarisYeriID
                             join y in contex.YerTipleri
                             on k.YerTipiID equals y.YerTipiID
                             select new KonaklamaDetailDto
                             {
                                 KonaklamaID = k.KonaklamaID,
                                 KonaklamaTipi = y.YerAdi,
                                 SirketAdi = k.SirketAdi,
                                 TatilYeri = v.VarisYeriAdi,
                                 ucret = k.ucret
                                 
                             };
                return result.SingleOrDefault(fiter);


            }
        }

        public List<KonaklamaDetailDto> konaklamaDetailDtos(Expression<Func<KonaklamaDetailDto, bool>> fiter = null)
        {
            using (EFSeyhatAcentaContex contex = new EFSeyhatAcentaContex())
            {
                var result = from k in contex.KonaklamaYerleri
                             join v in contex.VarisYerleri
                             on k.SirketYeriID equals v.VarisYeriID
                             join y in contex.YerTipleri
                             on k.YerTipiID equals y.YerTipiID
                             select new KonaklamaDetailDto
                             {
                                 KonaklamaID = k.KonaklamaID,
                                 KonaklamaTipi = y.YerAdi,
                                 SirketAdi = k.SirketAdi,
                                 TatilYeri = v.VarisYeriAdi,
                                 ucret = k.ucret
                             };
                return fiter == null ? result.ToList() : result.Where(fiter).ToList();


            }
        }
    }
}
