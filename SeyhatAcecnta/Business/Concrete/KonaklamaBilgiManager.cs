using Business.Abstract;
using DataAccess.Abstact;
using Entities.DTO;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KonaklamaBilgiManager : IKonaklamaBİlgiService
    {
        IKonaklamaBilgiDal _konaklamaBilgiDal;
        public KonaklamaBilgiManager(IKonaklamaBilgiDal konaklamaBilgiDal)
        {
            _konaklamaBilgiDal = konaklamaBilgiDal;
        }

        public KonaklamaDetailDto GetId(int id)
        {
            return _konaklamaBilgiDal.GetID(p => p.KonaklamaID == id);
        }

        public List<KonaklamaDetailDto> konaklamaDetailDtos(string konaklamaYeri, string konaklamaTipi)
        {
            return _konaklamaBilgiDal.konaklamaDetailDtos(p => p.TatilYeri == konaklamaYeri && p.KonaklamaTipi == konaklamaTipi);
        }
    }
}
