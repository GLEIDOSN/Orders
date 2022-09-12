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

        public IEnumerable<Supplier> GetSuppliers()
        {
            return ordersDBContext.Suppliers;
        }
    }
}
