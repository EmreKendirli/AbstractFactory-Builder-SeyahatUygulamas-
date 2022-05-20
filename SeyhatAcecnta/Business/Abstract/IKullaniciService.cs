using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface IKullaniciService
    {
        List<Kullanici> GetAll();
        Kullanici KullaniciAdiVeSifresiIleIdGetir(string KullaniciAdi, string Sifre);
        Kullanici GetId(int id);
        bool Valitadion(string userName, string password);
        void add(Kullanici kullanici);
        void delete(Kullanici kullanici);
        void update(Kullanici kullanici);
    }
}
