using Core.EntityFrameworkBase;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework;
using Entities.DTO;
using Entities.Entity;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Text;
using Core.Entities;

namespace DataAccess.Concrete
{
    public class EFUlasimAracDal:EFEntityFrameworkBase<UlasimArac,EFSeyhatAcentaContex>,IUlasimAracDal
    {
        public UlasimDetailDto GetId(Expression<Func<UlasimDetailDto, bool>> filter = null)
        {
            using (EFSeyhatAcentaContex contex = new EFSeyhatAcentaContex())
            {
                var result = from u in contex.UlasimAraclari
                             join v in contex.VarisYerleri
                             on u.VarisYeriID equals v.VarisYeriID
                             join k in contex.KalkisYerleri
                             on u.KalkisYeriID equals k.KalkisYeriID
                             join a in contex.AracTipleri
                             on u.AracTipi equals a.AracTipiID
                             select new UlasimDetailDto
                             {
                                 UlasimId = u.UlasimId,
                                 KalkisSaati = u.KalkisSaati,
                                 VarisSaati = u.VarisSaati,
                                 AracTipi = a.UlasimAdi,
                                 KalkisYeri = k.KalkisYerAdi,
                                 VarisYeri = v.VarisYeriAdi,
                                 SirketAdi = u.SirketAdi,
                                 Ucret = u.Ucret

                             };
          

                return result.SingleOrDefault(filter);
            }
            
        }

        public List<UlasimDetailDto> GetUlasimDetails(Expression<Func<UlasimDetailDto, bool>> filter = null)
        {
            using (EFSeyhatAcentaContex  contex=new EFSeyhatAcentaContex() )
            {
                var result = from u in contex.UlasimAraclari
                             join v in contex.VarisYerleri
                             on u.VarisYeriID equals v.VarisYeriID
                             join k in contex.KalkisYerleri
                             on u.KalkisYeriID equals k.KalkisYeriID
                             join a in contex.AracTipleri
                             on u.AracTipi equals a.AracTipiID
                             select new UlasimDetailDto { 
                                 UlasimId=u.UlasimId,
                                 KalkisSaati=u.KalkisSaati,
                                 VarisSaati=u.VarisSaati,
                                 AracTipi=a.UlasimAdi,
                                 KalkisYeri=k.KalkisYerAdi,
                                 VarisYeri=v.VarisYeriAdi,
                                 SirketAdi=u.SirketAdi,
                                 Ucret=u.Ucret
                             
                             };
                return filter == null ? result.ToList() : result.Where(filter).ToList();
            }
           
        }

    }
}
