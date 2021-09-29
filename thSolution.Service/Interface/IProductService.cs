using System.Collections.Generic;
using System.Threading.Tasks;
using thSolution.Entities;

namespace thSolution.Service.Interface
{
    public interface IProductService
    {
        Task<IEnumerable<Product>> GetListAsync();

        Task<IEnumerable<Product>> GetListByViewCountAsync(int viewCount);
    }
}
