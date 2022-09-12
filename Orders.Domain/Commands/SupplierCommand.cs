using Orders.Domain.Core.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Domain.Commands
{
    public abstract class SupplierCommand : Command
    {
        public string SocialReason { get; protected set; }
        public string CNPJ { get; protected set; }
        public string State { get; protected set; }
        public string Email { get; protected set; }
        public string Contact { get; protected set; }
        public string NameContact { get; protected set; }
    }
}
