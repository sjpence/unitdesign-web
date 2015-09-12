using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Postal;
using System.Threading.Tasks;

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
            vm.Address = "";
            vm.TimeSent = DateTime.UtcNow;

            return View(vm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Contact(Models.ContactViewModel contact)
        {
            if (ModelState.IsValid)
            {
                var currentTime = DateTime.UtcNow;
                var elapsedTime = currentTime - contact.TimeSent;
                bool spamFieldFull = !string.IsNullOrEmpty(contact.Check);

                dynamic email = new Email("ContactForm");
                email.From = contact.Email;
                email.CurrentTime = currentTime;
                email.Name = contact.Name;
                email.Title = contact.Title;
                email.Phone = contact.Phone;
                email.Company = contact.Company;
                email.Address = contact.Address;
                email.City = contact.City;
                email.State = contact.State;
                email.Zip = contact.Zip;
                email.Country = contact.Country;
                email.Comments = contact.Comments;
                email.Elapsed = elapsedTime;
                email.SpamFieldFull = spamFieldFull;

                await email.SendAsync();
                return RedirectToAction("ContactSuccess");                                
            }

            return View(contact);
        }

        public ActionResult ContactSuccess()
        {
            return View();
        }
    }
}