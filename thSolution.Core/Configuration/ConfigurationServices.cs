using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Linq;

namespace thSolution.Core.Configuration
{
    public static class ConfigurationServices
    {
        public static void ConfigIdentityOptions(this IServiceCollection services)
        {
            services.Configure<IdentityOptions>(options =>
            {
                options.Password.RequireDigit = true;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = true;
                options.Password.RequireUppercase = true;
                options.Password.RequiredUniqueChars = 0;
                options.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(30);
                options.Lockout.MaxFailedAccessAttempts = 4;
                options.Lockout.AllowedForNewUsers = true;
                options.User.AllowedUserNameCharacters = string.Empty;
                options.User.RequireUniqueEmail = false;
            });
            services.Configure<DataProtectionTokenProviderOptions>(opt =>
                opt.TokenLifespan = TimeSpan.FromHours(Constants.Constants.TOKEN_LIFE_SPAN));
        }

        public static void AddGenericType(this IServiceCollection services, Type baseType, string endName)
        {
            var types = baseType.Assembly.DefinedTypes
                .Select(type => type.AsType())
                .Where(type => type.Name.EndsWith(endName))
                .ToArray();
            var implementTypes = types.Where(type => type.IsClass).ToArray();
            var interfaceTypes = types.Where(type => type.IsInterface).ToArray();
            foreach (var implementType in implementTypes)
            {
                var interfaceType = interfaceTypes.FirstOrDefault(type => type.IsAssignableFrom(implementType));
                if (interfaceType != null)
                {
                    services.AddScoped(interfaceType, implementType);
                }
            }
        }
    }
}
