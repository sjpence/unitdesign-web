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
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds/mds-overall.jpg", "MDS-200 Soldering Machine"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds/mds-carriage.jpg", "MDS Transport Carriage"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds/mds-carrier1.jpg", "MDS Carrier with Single Row of Boards"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds/mds-carrier3.jpg", "MDS Carrier with Multiple Rows of Boards"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds/mds-controls.jpg", "MDS Electrical Panel"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds/mds-hood.jpg", "MDS-200 Fume Hood"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/mds/mds-operator.jpg", "MDS-200 Operator Station"));

            return View(vm);
        }

        // GET: Alt
        public ActionResult Alt()
        {
            var vm = new Models.AltViewModel();
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt/alt-overall.jpg", "ALT-100 Tinning Machine"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt/alt-solderpot.jpg", "ALT Solderpot"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt/alt-fluxtank.jpg", "ALT Lower Flux Tank"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt/alt-controls.jpg", "ALT Electrical Panel"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt/alt-hood.jpg", "ALT-100 Fume Hood"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/alt/alt-operator.jpg", "ALT-100 Operator Station"));

            return View(vm);
        }

        // GET: Abc2500
        public ActionResult Abc2500()
        {
            var vm = new Models.AbcViewModel();
            vm.SliderImages.Add(new Models.ImageMetaData("~/content/img/2500/2500-Overall.jpg", "ABC-2500 Aqueous Batch Cleaner"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/2500/2500-Chamber.jpg", "ABC-2500 Cleaning Chamber"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/2500/2500-Spray.jpg", "Spray Pump Plumbing"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/2500/2500-Dryer.jpg", "High Performance Drying System"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/2500/2500-InletHeater.jpg", "On-Demand Rinse Water heating"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/2500/2500-Drain.jpg", "Stainless Steel Drain Plumbing"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/2500/2500-WWR.jpg", "Heated and Mixed Cleaning Solution Storage"));

            return View(vm);
        }

        // GET: Abc3500
        public ActionResult Abc3500()
        {
            var vm = new Models.AbcViewModel();
            vm.SliderImages.Add(new Models.ImageMetaData("~/content/img/3500/3500web-7.JPG", "ABC-3500 Aqueous Batch Cleaner"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/3500/3500web-1.JPG", "Spray Pump and Plumbing"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/3500/3500web-3.JPG", "Wash Water Recycling Tank"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/3500/3500web-5.JPG", "Electrical Panel"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/3500/3500web-2.JPG", "Drain Piping"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/3500/3500web-4.JPG", "Dryer and Inlet Heater"));

            return View(vm);
        }
    }
}