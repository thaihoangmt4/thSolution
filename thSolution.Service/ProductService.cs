using System.Collections.Generic;
using System.Threading.Tasks;
using thSolution.Entities;
using thSolution.Repository.Interface;
using thSolution.Service.Interface;

namespace thSolution.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<IEnumerable<Product>> GetListAsync()
        {
            return await _productRepository.ListAllAsync();
        }

        public async Task<IEnumerable<Product>> GetListByViewCountAsync(int viewCount)
        {
            return await _productRepository.GetListByViewCountAsync(viewCount);
        }
    }
}
