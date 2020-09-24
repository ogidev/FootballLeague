using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace FootballLeague.Data.Models.Contracts
{
    public interface IRepository<TEntity>
    where TEntity : class
    {
        IQueryable<TEntity> All();
        Task AddAsync(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);
        Task<int> SaveChangesAsync();
    }
}

