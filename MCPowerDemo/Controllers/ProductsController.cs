using Business.Abstraction;
using Domain.Abstractions;
using Microsoft.AspNetCore.Mvc;

namespace MCPowerDemo.Controllers
{
    public class ProductsController : Controller
    {

        private IAdminService adminService;
        private IProductService productService;
        public MCpowerDbcontext _context;



        public ProductsController(IAdminService adminService, IProductService productService, MCpowerDbcontext _context)
        {
            this.adminService = adminService;
            this.productService = productService;
            this._context = _context;
        }

       // [Route("Prodcuts/ClientProduct")]
        public ActionResult ClientProduct(int id)
        {
            List<Products> prod = new List<Products>();
            var d= productService.GetProductByID(id);
             
            return View(d);
        }
        [HttpGet]
        public ActionResult list()
        {
            List<Products> products = _context.products.ToList();
            return View(products);
        }
     
        public ActionResult ShowProduct(int id)
        {
            Products p = productService.GetProductByID(id);
            return View(p);
        }
    }
}
