using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace unitdesign_web.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {            
            return View();
        }

        public ActionResult Contact()
        {
            var vm = new Models.ContactViewModel();
            vm.TimeSent = DateTime.UtcNow;

            return View(vm);
        }
    }
}