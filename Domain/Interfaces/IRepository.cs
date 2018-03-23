
using System;
using System.Linq;
using System.Linq.Expressions;

namespace Domain.Interfaces
{
    public interface IRepository<TEntity, in TID> 
    {
        void Add(TEntity entity);

        TEntity GetById(TID id);

        IQueryable<TEntity> GetAll();

        IQueryable<TEntity> GetPagination(Expression<Func<TEntity, bool>> filter, int page = 1, int quantity = 10);

        IQueryable<TEntity> GetAutocomplete(Expression<Func<TEntity, bool>> filter,
            Expression<Func<TEntity, object>> orderBy, int quantity = 10);

        void Update(TEntity entity);

        void Remove(TID id);

        int SaveChanges();
    }
}
