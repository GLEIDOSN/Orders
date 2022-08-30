using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Application.ViewModels
{
    public class SupplierViewModel
    {
        public IEnumerable<Supplier> Suppliers { get; set; }
    }
}
