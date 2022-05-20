using Business.Abstract;
using DataAccess.Abstact;
using Entities.DTO;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UlasimAracManager : IUlasimAracService
    {
        IUlasimAracDal _ulasimAracDal;
        public UlasimAracManager(IUlasimAracDal ulasimAracDal)
        {
            _ulasimAracDal = ulasimAracDal;

        }

        public void add(UlasimArac ulasimArac)
        {
             _ulasimAracDal.Add(ulasimArac);
        }

        public List<UlasimArac> GetAll()
        {
            return _ulasimAracDal.GetAll();
        }

        public UlasimDetailDto GetId(int ulasimId)
        {
            return _ulasimAracDal.GetId(p => p.UlasimId == ulasimId);
        }

        public List<UlasimDetailDto> GetUlasimDetailDtos(string kalkis,string varis,string aracTipi)
        {
            return _ulasimAracDal.GetUlasimDetails(p=>p.KalkisYeri==kalkis &&p.VarisYeri==varis&& p.AracTipi==aracTipi);
        }
    }
}
