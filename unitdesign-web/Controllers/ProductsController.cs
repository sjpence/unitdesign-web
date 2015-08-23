using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace unitdesign_web.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Mds
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

        // GET: Alt
        public ActionResult Alt()
        {
            var vm = new Models.AltViewModel();
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt100-scaled.jpg", "ALT-100 Tinning Machine"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt_solderpot-scaled.jpg", "ALT Solderpot"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt_fluxtank-scaled.jpg", "ALT Lower Flux Tank"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt_controls-scaled.jpg", "ALT Electrical Panel"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt_hood-scaled.jpg", "ALT-100 Fume Hood"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt_operator-scaled.jpg", "ALT-100 Operator Station"));

            return View(vm);
        }
    }
}