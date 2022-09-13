using Orders.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Application.Interfaces
{
    public interface ISupplierService
    {
        IEnumerable<SupplierViewModel> GetSuppliers();
        void Create(SupplierViewModel supplierViewModel);
    }
}
