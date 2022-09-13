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
        public int Id { get; set; }
        public string SocialReason { get; set; }
        public string CNPJ { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public string Contact { get; set; }
        public string NameContact { get; set; }
    }
}
