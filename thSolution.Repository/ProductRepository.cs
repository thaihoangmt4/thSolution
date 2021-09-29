using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using thSolution.Core.Repository;
using thSolution.Entities;
using thSolution.Repository.Context;
using thSolution.Repository.Interface;

namespace thSolution.Repository
{
    public class ProductRepository : BaseRepository<Product>, IProductRepository
    {
        private readonly ThSolutionDbContext _dbContext;

        public ProductRepository(ThSolutionDbContext dbContext) : base(dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<Product>> GetListByViewCountAsync(int viewCount)
        {
            return await _dbContext.Products
                .Where(x => x.ViewCount > viewCount)
                .ToListAsync();
        }
    }
}
