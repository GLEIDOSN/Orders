using Microsoft.Extensions.DependencyInjection;
using Orders.Application.Interfaces;
using Orders.Application.Services;
using Orders.Domain.Interfaces;
using Orders.Infra.Data.Repository;

namespace Orders.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Application Layer
            services.AddScoped<ISupplierService, ProviderService>();

            //Infra.Data Layer
            services.AddScoped<ISupplierRepository, SupplierRepository>();
        }
    }
}
