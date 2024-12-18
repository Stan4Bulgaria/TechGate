using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using TechGate.Core.Inferfaces;
using TechGate.Core.Services;
using TechGate.Data;
using TechGate.Infrastructure.Data.Models;

namespace TechGate.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services)
        {
            services.AddScoped<IProductServices, ProductServices>();
            services.AddScoped<ICategoryServices, CategoryServices>();
            return services;
        }

        public static IServiceCollection AddApplicationDbContext(this IServiceCollection services, IConfiguration config)
        {
            var connectionString = config.GetConnectionString("DefaultConnection");
            services.AddDbContext<TechGateDbContext>(options =>
                  options.UseSqlServer(connectionString));

            services.AddDatabaseDeveloperPageExceptionFilter();

            return services;
        }

        public static IServiceCollection AddApplicationIdentity(this IServiceCollection services, IConfiguration config)
        {
            services
                    .AddDefaultIdentity<User>(options =>
                    {
                        options.SignIn.RequireConfirmedAccount = false;
                        options.Password.RequireDigit = false;
                        options.Password.RequireLowercase = false;
                        options.Password.RequireUppercase = false;
                        options.Password.RequireNonAlphanumeric = false;
                    })
                    .AddEntityFrameworkStores<TechGateDbContext>();

            return services;
        }
       
    }
}
