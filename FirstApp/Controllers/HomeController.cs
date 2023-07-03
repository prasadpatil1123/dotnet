using FirstApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

       

        private IConfiguration settings;

        public HomeController (IConfiguration configuration)
        {
            settings = configuration;
        }
        public string MyIndex()
        {
            string con = settings.GetConnectionString("DefaultConnection");
                //Convert.ToString(settings["ConnectionStrings:DefaultConnection"]);
            return "Jai shree Ram !!!  bharat mata ki Jai  "+con;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult RedirectExample()
        {
            return Redirect("/Home/Index");
        }

        public IActionResult GetJsonData()
        {
            var data = new { Name="Kashi",Age= 27};
            return Json(data);
        }

        public IActionResult GetHtmlText()
        {
            return Content("<h1>Hello World !</h1>","text/HTML");
        }

        public IActionResult BadRequestExample()
        {
            return BadRequest();
        }

        public IActionResult NotFoundExample()
        {
            return NotFound();
        }

        public IActionResult GetPartialView()
        {
            return PartialView("_PartialView");
        }

       // public IActionResult DownloadFile()
        //{
          //  var fileBytes = GetFileBytes();
           // return File(FileBytes,"Application/pdf","myfile.pdf");
       // }
    }
}