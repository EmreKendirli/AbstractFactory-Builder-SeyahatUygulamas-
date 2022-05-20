using Core.EntityFrameworkBase;
using DataAccess.Abstact;
using DataAccess.Concrete.EntityFramework;
using Entities.Entity;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Concrete
{
    public class EFKullaniciDal:EFEntityFrameworkBase<Kullanici,EFSeyhatAcentaContex>,IKullaniciDal
    {
    }
}
