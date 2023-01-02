using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment1.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index(string Input)
        {
            if(Input == "Sample")
            {
                return File("~/Sample.pdf", "application/pdf");
            }
            else if (Input == "gotoabout")
            {
                return RedirectToAction("About", "Home");
            }
            else if (Input == "Login")
            {
                return View("Login");
            }
            else
            {
                string content = "You entered:" + Input;
                return Content(content, "text/plain");
            }
           
        }
        public ActionResult About()
        {
            return View();
        }
    }
}