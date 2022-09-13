using Microsoft.AspNetCore.Mvc;
using Orders.Application.Interfaces;
using Orders.Application.ViewModels;

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
            supplierService.Create(supplierViewModel);
            return Ok(supplierViewModel);
        }

    }
}
