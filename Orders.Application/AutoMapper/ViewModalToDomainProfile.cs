using AutoMapper;
using Orders.Application.ViewModels;
using Orders.Domain.Commands;

namespace Orders.Application.AutoMapper
{
    public class ViewModalToDomainProfile : Profile
    {
        public ViewModalToDomainProfile()
        {
            CreateMap<SupplierViewModel, CreateSupplierCommand>()
                .ConstructUsing(c => new CreateSupplierCommand(c.SocialReason, c.CNPJ, c.State, c.Email, c.Contact, c.NameContact));

        }
    }
}
