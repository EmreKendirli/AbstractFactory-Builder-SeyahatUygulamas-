using Core.DataAccess;
using Entities.DTO;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Abstact
{
    public interface IKonaklamaBilgiDal:IRepostory<KonaklamaBilgi>
    {
        public List<KonaklamaDetailDto> konaklamaDetailDtos(Expression<Func<KonaklamaDetailDto, bool>> fiter = null);
    }
}
