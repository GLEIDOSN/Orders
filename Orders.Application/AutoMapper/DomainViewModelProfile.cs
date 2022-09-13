using AutoMapper;
using Orders.Application.ViewModels;
using Orders.Domain.Models;

namespace Orders.Application.AutoMapper
{
    public class DomainViewModelProfile : Profile
    {
        public DomainViewModelProfile()
        {
            CreateMap<Supplier, SupplierViewModel>();
        }
    }
}
