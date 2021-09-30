using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using thSolution.Core.Configuration;
using thSolution.Repository.Interface;
using thSolution.Service.Interface;

namespace thSolution.API.Configuration
{
    public static class ConfigurationServices
    {
        public static void AddCoreServices(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddGenericType(typeof(IProductRepository), "Repository");
            services.AddGenericType(typeof(IProductService), "Service");
        }
    }
}
