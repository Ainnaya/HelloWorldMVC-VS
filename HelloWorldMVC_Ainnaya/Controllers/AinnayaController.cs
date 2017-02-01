using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelloWorldMVC_Ainnaya.Controllers
{
    public class AinnayaController : Controller
    {
        // GET: Ainnaya
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Anything()
        {
            return Content("Hello Ainnaya Nur Akasah Welcome to MVC");
        }
        public ActionResult Something()
        {
            return Content("Something...");
        }
        public ActionResult ShowSomething()
        {
            return View();
        }
    }
}