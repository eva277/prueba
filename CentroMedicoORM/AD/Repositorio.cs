using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace CentroMedicoORM.AD
{
    class Repositorio<TEntity> where TEntity : class 
    {
        protected CentroMedicoEntities context = new CentroMedicoEntities();
        DbSet<TEntity> dbSet;

        public void update(TEntity entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public void delete(TEntity entity)
        {
            dbSet = context.Set<TEntity>();
            if (context.Entry(entity).State==EntityState.Detached)
            {
                dbSet.Attach(entity);
            }
            dbSet.Remove(entity);

            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }
        public void create(TEntity entity)
        {
            try
            {
                dbSet = context.Set<TEntity>();
                dbSet.Add(entity);
                context.SaveChanges();
            }
            catch (Exception ex)
            {
                string message = ex.Message;
            }
        }
        public List<TEntity> getAll()
        {
            return (List < TEntity >) context.Set<TEntity>().ToList();
        }
        public TEntity single(Expression<Func<TEntity, bool>> predicate)
        {
            dbSet = context.Set<TEntity>();
            return dbSet.FirstOrDefault(predicate);
        }


    }
}
