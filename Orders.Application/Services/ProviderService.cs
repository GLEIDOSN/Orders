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
    public class ProviderService : IProviderService
    {
        private readonly IProviderRepository providerRepository;

        public ProviderService(IProviderRepository providerRepository)
        {
            this.providerRepository = providerRepository;
        }

        public ProviderViewModel GetProviders()
        {
            return new ProviderViewModel()
            {
                Providers = this.providerRepository.GetProviders()
            };
        }
    }
}
