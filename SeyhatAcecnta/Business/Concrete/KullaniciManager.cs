using Business.Abstract;
using DataAccess.Abstact;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class KullaniciManager : IKullaniciService
    {
        IKullaniciDal _kullaniciDal;
        public KullaniciManager(IKullaniciDal kullaniciDal)
        {
            _kullaniciDal = kullaniciDal;
        }
        public void add(Kullanici kullanici)
        {
            _kullaniciDal.Add(kullanici);
        }

        public void delete(Kullanici kullanici)
        {
            _kullaniciDal.Delete(kullanici);
        }

        

        public List<Kullanici> GetAll()
        {
            return _kullaniciDal.GetAll();
        }

        public Kullanici GetId(int id)
        {
            return _kullaniciDal.Get(p => p.Id == id);
        }

        public Kullanici KullaniciAdiVeSifresiIleIdGetir(string KullaniciAdi, string Sifre)
        {
            return _kullaniciDal.Get(p => p.KullaniciAdi == KullaniciAdi && p.Sifre == Sifre);
        }

        public void update(Kullanici kullanici)
        {
            _kullaniciDal.UpDate(kullanici);
        }

        public bool Valitadion(string userName, string password)
        {
            int result = _kullaniciDal.GetAll(p => p.KullaniciAdi == userName && p.Sifre == password).Count;
            if (result != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
