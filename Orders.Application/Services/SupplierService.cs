using AutoMapper;
using AutoMapper.QueryableExtensions;
using Orders.Application.Interfaces;
using Orders.Application.ViewModels;
using Orders.Domain.Commands;
using Orders.Domain.Core.Bus;
using Orders.Domain.Interfaces;
using System.Collections.Generic;

namespace Orders.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;
        private readonly IMediatorHandler bus;
        private readonly IMapper autoMapper;

        public SupplierService(ISupplierRepository supplierRepository, IMediatorHandler bus, IMapper autoMapper)
        {
            this.supplierRepository = supplierRepository;
            this.bus = bus;
            this.autoMapper = autoMapper;
        }

        public void Create(SupplierViewModel supplierViewModel)
        {
            bus.SendCommand(autoMapper.Map<CreateSupplierCommand>(supplierViewModel));
        }

        public IEnumerable<SupplierViewModel> GetSuppliers()
        {
            return supplierRepository.GetSuppliers().ProjectTo<SupplierViewModel>(autoMapper.ConfigurationProvider);
        }
    }
}
