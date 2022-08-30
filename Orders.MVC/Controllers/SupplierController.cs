using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Orders.Application.Interfaces;
using Orders.Application.ViewModels;

namespace Orders.MVC.Controllers
{
    [Authorize]
    public class SupplierController : Controller
    {
        private readonly ISupplierService supplierService;

        public SupplierController(ISupplierService supplierService)
        {
            this.supplierService = supplierService;
        }
    
        // GET: /<controller>/
        public IActionResult Index()
        {
            SupplierViewModel model = supplierService.GetSuppliers();
            return View(model);
        }
    }
}
