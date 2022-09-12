using MediatR;
using Microsoft.Extensions.DependencyInjection;
using Orders.Application.Interfaces;
using Orders.Application.Services;
using Orders.Domain.CommandHandlers;
using Orders.Domain.Commands;
using Orders.Domain.Core.Bus;
using Orders.Domain.Interfaces;
using Orders.Infra.Bus;
using Orders.Infra.Data.Context;
using Orders.Infra.Data.Repository;

namespace Orders.Infra.IoC
{
    public class DependencyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            //Domain InMemoryBus MediatR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //Domain Handlers
            services.AddScoped<IRequestHandler<CreateSupplierCommand, bool>, SupplierCommandHandler>();

            //Application Layer
            services.AddScoped<ISupplierService, SupplierService>();

            //Infra.Data Layer
            services.AddScoped<ISupplierRepository, SupplierRepository>();
            services.AddScoped<OrdersDBContext>();

        }
    }
}
