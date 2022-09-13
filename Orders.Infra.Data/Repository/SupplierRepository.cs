using Orders.Domain.Interfaces;
using Orders.Domain.Models;
using Orders.Infra.Data.Context;
using System.Linq;

namespace Orders.Infra.Data.Repository
{
    public class SupplierRepository : ISupplierRepository
    {
        private readonly OrdersDBContext ordersDBContext;

        public SupplierRepository(OrdersDBContext ordersDBContext)
        {
            this.ordersDBContext = ordersDBContext;
        }

        public void Add(Supplier supplier)
        {
            ordersDBContext.Suppliers.Add(supplier);
            ordersDBContext.SaveChanges();
        }

        public IQueryable<Supplier> GetSuppliers()
        {
            return ordersDBContext.Suppliers;
        }
    }
}
