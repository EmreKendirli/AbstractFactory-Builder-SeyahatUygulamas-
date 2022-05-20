using Business.Abstract;
using DataAccess.Abstact;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class SeyhatBilgiManager:ISeyhatBilgiService
    {
        ISeyhatBilgiDal _seyhatBilgiDal;
        public SeyhatBilgiManager(ISeyhatBilgiDal seyhatBilgiDal)
        {
            _seyhatBilgiDal = seyhatBilgiDal;
        }

        public void add(SeyhatBilgi seyhatBilgi)
        {
            _seyhatBilgiDal.Add(seyhatBilgi);
        }

        public void delete(SeyhatBilgi seyhatBilgi)
        {
            _seyhatBilgiDal.Delete(seyhatBilgi);
        }

        public SeyhatBilgi GetId(int kullaniciId)
        {
            return _seyhatBilgiDal.Get(p => p.KullaniciId == kullaniciId);
        }

        public void update(SeyhatBilgi seyhatBilgi)
        {
            _seyhatBilgiDal.UpDate(seyhatBilgi);
        }
    }
}
