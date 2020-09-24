using FootballLeague.Data.Models.Contracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FootballLeague.Data
{
    public class DbRepository<TEntity> : IRepository<TEntity>, IDisposable
        where TEntity:class
    {
        private readonly DbSet<TEntity> dbSet;
        private readonly FootballLeagueContext context;
        public DbRepository(FootballLeagueContext context)
        {
            this.context = context;
            this.dbSet = this.context.Set<TEntity>();
        }
        public Task AddAsync(TEntity entity)
        {
            return this.dbSet.AddAsync(entity);
        }

        public IQueryable<TEntity> All()
        {
            return this.dbSet;
        }

        public void Delete(TEntity entity)
        {
            this.dbSet.Remove(entity);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Task<int> SaveChangesAsync()
        {
            return this.context.SaveChangesAsync();
        }

        public void Update(TEntity entity)
        {
            this.context.Dispose();
        }
    }
}
