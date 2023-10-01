using System;
using Microsoft.EntityFrameworkCore;
using ES.Core.Contracts.Entities;
using ES.Core.Module;

namespace ES.Core.DataAccess
{
	public interface IUnitOfWork : IDisposable
	{

		IRepository<T> Repository<T>() where T : BaseEntity;
        string GetConnStr();
        CurrentUser GetCurrentUser();
        /// <summary>
        /// Saves all pending changes
        /// </summary>
        /// <returns>The number of objects in an Added, Modified, or Deleted state</returns>
        int Commit();

        DbContext GetContext();

    }
}
