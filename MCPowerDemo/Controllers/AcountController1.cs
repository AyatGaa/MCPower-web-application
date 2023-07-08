using Microsoft.AspNetCore.Mvc;

namespace MCPowerDemo.Controllers
{
    public class AcountController1 : Controller
    {
        //get: Admin/AcountController1/Login
        public IActionResult Login()
        {
            return View();
        }
    }
}
