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
    public class ProviderService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;

        public ProviderService(ISupplierRepository supplierRepository)
        {
            this.supplierRepository = supplierRepository;
        }

        public ProviderViewModel GetSuppliers()
        {
            return new ProviderViewModel()
            {
                Providers = this.supplierRepository.GetSuppliers()
            };
        }
    }
}
