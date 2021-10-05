using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using thSolution.API.Identity;
using thSolution.Core.Configuration;
using thSolution.Entities;
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

        public static void AddIdentityServices(this IServiceCollection services)
        {
            services.AddIdentity<Users, Roles>().AddDefaultTokenProviders();
            services.AddTransient<IUserStore<Users>, UserStore>();
            services.AddTransient<IRoleStore<Roles>, RoleStore>();
            services.ConfigIdentityOptions();
        }
    }
}
