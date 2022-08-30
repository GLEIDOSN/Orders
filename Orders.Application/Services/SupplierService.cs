using Orders.Application.Interfaces;
using Orders.Application.ViewModels;
using Orders.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;

        public SupplierService(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        public SupplierViewModel GetSuppliers()
        {
            return new SupplierViewModel()
            {
                Suppliers = this.supplierRepository.GetSuppliers()
            };
        }
    }
}
