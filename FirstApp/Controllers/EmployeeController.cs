using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
            // return View("SharedView");
        }

        public IActionResult GetEmp()
        {
            return View();
        }
    }
}
