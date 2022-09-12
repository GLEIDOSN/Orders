using Orders.Application.Interfaces;
using Orders.Application.ViewModels;
using Orders.Domain.Commands;
using Orders.Domain.Core.Bus;
using Orders.Domain.Interfaces;

namespace Orders.Application.Services
{
    public class SupplierService : ISupplierService
    {
        private readonly ISupplierRepository supplierRepository;
        private readonly IMediatorHandler _bus;

        public SupplierService(ISupplierRepository supplierRepository, IMediatorHandler bus)
        {
            this.supplierRepository = supplierRepository;
            this._bus = bus;
        }

        public void Crete(SupplierViewModel supplierViewModel)
        {
            var createSupplierCommand = new CreateSupplierCommand(
                supplierViewModel.SocialReason,
                supplierViewModel.CNPJ,
                supplierViewModel.State,
                supplierViewModel.Email,
                supplierViewModel.Contact,
                supplierViewModel.NameContact
                );
            _bus.SendCommand(createSupplierCommand);

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
