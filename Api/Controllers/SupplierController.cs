using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Orders.Application.Interfaces;
using Orders.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SupplierController : ControllerBase
    {
        private readonly ISupplierService supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }

        [HttpPost]
        public IActionResult Post([FromBody] SupplierViewModel supplierViewModel)
        {
            supplierService.Crete(supplierViewModel);
            return Ok(supplierViewModel);
        }

    }
}
