using OFour.Core.Infrastructure.EntityAbstraction;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace OFour.Core.Infrastructure.RepositoryAbstraction
{
    public interface IRepositoryBase<TEntity> where TEntity : EntityBase, new()
    {
        TEntity Add(TEntity entity);
        void Update(TEntity entity);
        Task<List<TEntity>> GetAllAsync();
        Task<TEntity> GetSingleAsync(Expression<Func<TEntity, bool>> predicate);
        Task<bool> IfAnyAsync(Expression<Func<TEntity, bool>> predicate);
        void DeleteWhere(Expression<Func<TEntity, bool>> predicate);
    }
}
