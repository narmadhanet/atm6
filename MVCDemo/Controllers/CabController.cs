using MVCDemo.Models;
using MVCDemo.ViewModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class CabController : Controller
    {

        private Context context;

        public CabController()
        {
            context = new Context();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        // GET: Cab
        public ActionResult Index()
        {
            return View();
        }
        [Route("Cab/ByType/{Type}")]
         public ActionResult ByType(int type)
        {
            return Content("type " + type);
        }
        public ActionResult BasicDetails()
        {

             var cab = new Cab() { Id = 101, Name = "Tesla" };

            var pass = new Passenger() { Id = 1 };
            return View(cab);

            //return Content("hello");

            //  return HttpNotFound();

            //  return new EmptyResult();

         //   return RedirectToAction("PassengerDetails", "Passenger");
        }

        public List<Passenger> GetPassengers()
        {
            return new List<Passenger>
            {
                new Passenger{Id=1,Name="aditya",Balance=3000},
                new Passenger{Id=2,Name="joshiba",Balance=5000},
                new Passenger{Id=3,Name="saumya",Balance=500},
                new Passenger{Id=4,Name="seema",Balance=400},

            };
        }

       
        public ActionResult CabHistory()
        {
            var cab = new Cab() { Id = 3, Name = "alto", ManufacturedDate = new DateTime(2010, 01, 04) };

            var passlist = GetPassengers();

            var cabpassvm = new CabPassengerViewModel
            {
                Cab = cab,
                Passengers = passlist
            };
            return View(cabpassvm);
        }

        public List<Cab> GetCabs()
        {
            return  new List<Cab>()
            {
                new Cab{Id=1,Name="nissan",ManufacturedDate=new DateTime(2000,01,03)},
                new Cab{Id=2,Name="verna"},
                new Cab{Id=3,Name="lambo"},
                new Cab{Id=4,Name="Audi"},
                new Cab{Id=5,Name="BMW"},

            };
        }



        public ActionResult Details(int id)
        {
            var cabl = context.Cabs;

            var cab = cabl.Include(x=>x.CabType).SingleOrDefault(x => x.Id == id);

            if (cab == null)
                return HttpNotFound();

            return View(cab);
        }
        public ActionResult PrintCabDetails()
        {
            //var cabs = new List<Cab>()
            //{
            //    new Cab{Id=1,Name="nissan",ManufacturedDate=new DateTime(2000,01,03)},
            //    new Cab{Id=2,Name="verna"},
            //    new Cab{Id=3,Name="lambo"},
            //    new Cab{Id=4,Name="Audi"},
            //    new Cab{Id=5,Name="BMW"},

            //};

            var cabs = context.Cabs;

            return View(cabs);
        }

        public ActionResult Sample()
        {

            //ViewBag.CabName = "i20";
            //ViewBag.Driver = "shaswat";

            //ViewData["Title"] = "cab details";

            //TempData["sample"] = "sample data";

            return View();
        }
    }
}