using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TestRecaptcha;
using Recaptcha;

namespace TestRecaptcha.Controllers
{
    public class HomeController : Controller
    {

        
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to ASP.NET MVC!";

            return View();
        }


        [HttpPost]
        [RecaptchaControlMvc.CaptchaValidator]
        public ActionResult Index(String name, bool captchaValid, String captchaErrorMessage)
        {




            return View();
        }

        public ActionResult About()
        {
            return View();
        }
    }
}
