using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace unitdesign_web.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Soldering
        public ActionResult Mds()
        {
            var vm = new Models.MdsViewModel();
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds200-scaled.jpg", "MDS-200 Soldering Machine"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds_carriage-scaled.jpg", "MDS Transport Carriage"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds_carrier-scaled.jpg", "MDS Carrier with Single Row of Boards"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds_carrier3-scaled.jpg", "MDS Carrier with Multiple Rows of Boards"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds_controls-scaled.jpg", "MDS Electrical Panel"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds_hood-scaled.jpg", "MDS-200 Fume Hood"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds_operator-scaled.jpg", "MDS-200 Operator Station"));

            return View(vm);
        }
    }
}