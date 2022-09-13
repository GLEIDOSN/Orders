using Orders.Domain.Models;
using System.Linq;

namespace Orders.Domain.Interfaces
{
    public interface ISupplierRepository
    {
        IQueryable<Supplier> GetSuppliers();
        void Add(Supplier supplier);
    }
}
