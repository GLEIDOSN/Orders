using MediatR;
using Orders.Domain.Commands;
using Orders.Domain.Interfaces;
using System.Threading;
using System.Threading.Tasks;
using Orders.Domain.Models;

namespace Orders.Domain.CommandHandlers
{
    public class SupplierCommandHandler : IRequestHandler<CreateSupplierCommand, bool>
    {
        private readonly ISupplierRepository _supplierRepository;

        public SupplierCommandHandler(ISupplierRepository supplierRepository)
        {
            _supplierRepository = supplierRepository;
        }

        public Task<bool> Handle(CreateSupplierCommand request, CancellationToken cancellationToken)
        {
            var supplier = new Supplier()
            {
                Id = request.Id,
                SocialReason = request.SocialReason,
                CNPJ = request.CNPJ,
                State = request.State,
                Email = request.Email,
                Contact = request.Contact,
                NameContact = request.NameContact
            };
            _supplierRepository.Add(supplier);

            return Task.FromResult(true);
        }
    }
}
