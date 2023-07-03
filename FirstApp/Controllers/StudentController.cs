using Microsoft.AspNetCore.Mvc;

namespace FirstApp.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult GetInfo()
        {
            return View();
        }

        [HttpPost]
        public IActionResult GetInfo(string name,string sex)
        {
            return View();
        }

        public IActionResult DisplayResult()
        {
            return View();
        }

        public IActionResult Index()
        {
            return View();
           // return View("SharedView");
        }

        //[ActionName("Welcome")]
        //public string Index()
        //{
            //return "Hello Kashi";
        //}

        [NonAction]
        public string NoAction()
        {
            return "Captain America";
        }

        [HttpGet]
        public string HttpGetAction()
        {
            return "In Get";
        }

        [HttpPost]
        public string HttpPostAction()
        {
            return "In Post";
        }

        [HttpPut]
        public string HttpPutAction()
        {
            return "In Put";
        }

        [HttpDelete]
        public string HttpDeleteAction()
        {
            return "In Delete";
        }

        [HttpHead]
        public string HttpHeadAction()
        {
            return "In Head";
        }

        [HttpPatch]
        public string HttpPatchAction()
        {
            return "In Patch";
        }

        [HttpOptions]
        public string HttpOptionsAction()
        {
            return "In Options";
        }
    }
}
