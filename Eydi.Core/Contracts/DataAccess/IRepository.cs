using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using ES.Core.Contracts.Entities;

namespace ES.Core.DataAccess
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetByPK(params object[] keyValues);
        IQueryable<T> GetByPKQueryable(params object[] keyValues);
        void Insert(T newEntity);
        void Update(T entity);
        void Delete(T entity);
        void HardDeleteByPK(params object[] keyValues);
        T InsertAndReturn(T entity);
        void DeleteByPK(params object[] keyValues);
        void DeleteRange(Expression<Func<T, bool>> filter);
        void HardDeleteByPk(params object[] keyValues);
        List<T> GetAll();
        //List<T> GetAllByAccess();
        IQueryable<T> Get(Expression<Func<T, bool>> filter = null, bool includeDeleted = false);
        //IQueryable<T> GetByAccess(Expression<Func<T, bool>> filter = null);
        PaginatedResult<T> QueryPaginated(PaginatedRequest request, IQueryable<T> query = null);

        /// <summary>
        /// Gets a table
        /// </summary>
        IQueryable<T> Table { get; }

        /// <summary>
        /// Gets a table with "no tracking" enabled (EF feature) Use it only when you load record(s) only for read-only operations
        /// </summary>
        IQueryable<T> TableNoTracking { get; }
    }
}
