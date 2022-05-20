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

        public List<KonaklamaBilgi> a(int a)
        {
            return _konaklamaBilgiDal.GetAll(p => p.YerTipiID == a);
        }

       

        public List<KonaklamaDetailDto> konaklamaDetailDtos(string konaklamaYeri, string konaklamaTipi)
        {
            return _konaklamaBilgiDal.konaklamaDetailDtos(p => p.TatilYeri == konaklamaYeri && p.KonaklamaTipi == konaklamaTipi);
        }
    }
}
