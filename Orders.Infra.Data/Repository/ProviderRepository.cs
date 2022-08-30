using Orders.Domain.Interfaces;
using Orders.Domain.Models;
using Orders.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Infra.Data.Repository
{
    public class ProviderRepository : IProviderRepository
    {
        private readonly OrdersDBContext ordersDBContext;

        public ProviderRepository(OrdersDBContext ordersDBContext)
        {
            this.ordersDBContext = ordersDBContext;
        }

        public IEnumerable<Provider> GetProviders()
        {
            return ordersDBContext.Providers;
        }
    }
}
