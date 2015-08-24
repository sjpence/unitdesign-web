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

        // GET: Abc2500
        public ActionResult Abc2500()
        {
            var vm = new Models.AbcViewModel();
            vm.SliderImages.Add(new Models.ImageMetaData("~/content/img/abc2500-scaled.jpg", "ABC-2500 Aqueous Batch Cleaner"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/abc_chamber-scaled.jpg", "ABC-2500 Cleaning Chamber"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/abc_chemical-scaled.jpg", "Chemical Injection Pumps"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/abc_dryer-scaled.jpg", "High Performance Drying System"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/abc_inlet_heat-scaled.jpg", "On-Demand Rinse Water heating"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/abc_plumbing-scaled.jpg", "Stainless Steel Plumbing"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/abc_valve-scaled.jpg", "Full Port Stainless Steel Ball Valves"));
            vm.SliderImages.Add(new Models.ImageMetaData("~/Content/img/abc_wwr-scaled.jpg", "Heated and Mixed Cleaning Solution Storage"));

            return View(vm);
        }
    }
}