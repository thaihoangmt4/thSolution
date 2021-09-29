using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thSolution.Core.Repository.Interface;

namespace thSolution.Core.Repository
{
    public class BaseRepository<T> : IBaseRepository<T> where T : class
    {
        private readonly DbContext _dbContext;

        protected readonly IHttpContextAccessor _httpContextAccessor;

        public BaseRepository(DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public virtual T GetById(int id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public virtual T GetById(string id)
        {
            return _dbContext.Set<T>().Find(id);
        }

        public IReadOnlyList<T> ListAll()
        {
            return _dbContext.Set<T>().ToList();
        }

        public T Add(T entity, bool saveChange = true)
        {
            _dbContext.Set<T>().Add(entity);
            if (saveChange)
                _dbContext.SaveChanges();

            return entity;
        }

        public void Update(T entity, bool saveChange = true)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            if (saveChange)
                _dbContext.SaveChanges();
        }

        public void Delete(T entity, bool saveChange = true)
        {
            _dbContext.Set<T>().Remove(entity);
            if (saveChange)
                _dbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            _dbContext.SaveChanges();
        }

        public IDbContextTransaction BeginTransaction()
        {
            return _dbContext.Database.BeginTransaction();
        }

        public virtual async Task<T> GetByIdAsync(params object[] keyValues)
        {
            return await _dbContext.Set<T>().FindAsync(keyValues);
        }

        public async Task<IReadOnlyList<T>> ListAllAsync()
        {
            return await _dbContext.Set<T>().ToListAsync();
        }

        public async Task<T> AddAsync(T entity, bool saveChange = true)
        {
            await _dbContext.Set<T>().AddAsync(entity);

            if (saveChange)
            {
                await _dbContext.SaveChangesAsync();
            }

            return entity;
        }

        public async Task AddRangeAsync(IEnumerable<T> entities, bool saveChange = true)
        {
            await _dbContext.Set<T>().AddRangeAsync(entities);

            if (saveChange)
            {
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task UpdateAsync(T entity, bool saveChange = true)
        {
            _dbContext.Entry(entity).State = EntityState.Modified;
            if (saveChange)
            {
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task DeleteAsync(T entity, bool saveChange = true)
        {
            _dbContext.Set<T>().Remove(entity);
            if (saveChange)
            {
                await _dbContext.SaveChangesAsync();
            }
        }

        public async Task SaveChangesAsync()
        {
            await _dbContext.SaveChangesAsync();
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync()
        {
            return await _dbContext.Database.BeginTransactionAsync();
        }
    }
}
