using Entities.DTO;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IUlasimAracService
    {
        List<UlasimArac> GetAll();
        List<UlasimDetailDto> GetUlasimDetailDtos(string Kalkis,string varis,string aracTipi);
        UlasimDetailDto GetId(int ulasimId);
        
        void add(UlasimArac ulasimArac);
    }
}
