using System.Collections.Generic;
using System.Threading.Tasks;
using thSolution.Core.Repository.Interface;
using thSolution.Entities;

namespace thSolution.Repository.Interface
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        Task<IEnumerable<Product>> GetListByViewCountAsync(int viewCount);
    }
}
