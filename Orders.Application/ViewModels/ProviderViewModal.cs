﻿using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Application.ViewModels
{
    public class ProviderViewModal
    {
        public IEnumerable<Provider> Providers { get; set; }
    }
}
