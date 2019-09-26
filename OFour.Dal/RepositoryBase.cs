using Microsoft.EntityFrameworkCore;
using OFour.Core.Infrastructure.EntityAbstraction;
using OFour.Core.Infrastructure.RepositoryAbstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Dal
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity>
       where TEntity : EntityBase, new()
    {
        protected readonly WebFacultyContext Context;

        public RepositoryBase(WebFacultyContext _context)
        {
            Context = _context;
        }

        public TEntity Add(TEntity entity)
        {
            Context.Set<TEntity>().Add(entity);
            return entity;
        }

       


        public void DeleteWhere(Expression<Func<TEntity, bool>> predicate)
        {
            var entities = Context.Set<TEntity>().Where(predicate);

            foreach (var entity in entities)
            {
                Context.Entry(entity).State = EntityState.Deleted;
            }
        }

       

        public Task<List<TEntity>> GetAllAsync()
        {
            return Context.Set<TEntity>().ToListAsync();
        }

       

        public Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate)
        {
            return Context.Set<TEntity>().FirstOrDefaultAsync(predicate);
        }

        public Task<bool> IfAnyAsync(Expression<Func<TEntity, bool>> predicate)
        {
            if (predicate != null)
                return Context.Set<TEntity>().AnyAsync(predicate);
            else
                return Context.Set<TEntity>().AnyAsync();
        }

        public void Update(TEntity entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }

       
       



    }
}
