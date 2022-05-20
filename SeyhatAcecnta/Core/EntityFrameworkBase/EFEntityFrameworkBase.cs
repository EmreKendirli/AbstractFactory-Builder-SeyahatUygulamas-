using Core.DataAccess;
using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace Core.EntityFrameworkBase
{
    public class EFEntityFrameworkBase<TEntity, TContex> : IRepostory<TEntity>
                        where TEntity : class, IEntity, new()
                        where TContex : DbContext, new()
    {
        public void Add(TEntity entity)
        {
            using (TContex contex=new TContex())
            {
                var addedEntity = contex.Entry(entity);//referansı yakalar
                addedEntity.State = EntityState.Added;//ekler
                contex.SaveChanges();//kaydeder
            }
        }

        public void Delete(TEntity entity)
        {
            using (TContex contex=new TContex())
            {
                var deleteEntity = contex.Entry(entity);
                deleteEntity.State = EntityState.Deleted;
                contex.SaveChanges();
            }
        }

        public List<TEntity> GetAll(Expression<Func<TEntity, bool>> filter = null)
        {
            using (TContex contex=new TContex())
            {
                return filter == null ? contex.Set<TEntity>().ToList() : contex.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void UpDate(TEntity entity)
        {
            using (TContex contex=new TContex())
            {
                var updateEntity = contex.Entry(entity);
                updateEntity.State = EntityState.Modified;
                contex.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (TContex contex=new TContex())
            {
                return contex.Set<TEntity>().SingleOrDefault(filter);

            }
        }
    }
}
