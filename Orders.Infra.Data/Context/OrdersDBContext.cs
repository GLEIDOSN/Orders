using Microsoft.EntityFrameworkCore;
using Orders.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Orders.Infra.Data.Context
{
    public class OrdersDBContext : DbContext
    {
        public OrdersDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<Provider> Providers { get; set; }
    }
}
