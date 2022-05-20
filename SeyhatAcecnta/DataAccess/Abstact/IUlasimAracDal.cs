using Core.DataAccess;
using Core.Entities;
using Entities.DTO;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstact
{
    public interface IUlasimAracDal:IRepostory<UlasimArac>
    {
        public List<UlasimDetailDto> GetUlasimDetails(Expression<Func<UlasimDetailDto, bool>> filter = null);
        public UlasimDetailDto GetId(Expression<Func<UlasimDetailDto, bool>> filter = null);
    }
}
