using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace unitdesign_web.Controllers
{
    public class RedirectController : Controller
    {        
        public ActionResult Cleaning(string path)
        {
            return RedirectPermanent("/Products/Abc2500");
        }
    }
}