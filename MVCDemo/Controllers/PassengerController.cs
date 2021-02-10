using MVCDemo.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCDemo.Controllers
{
    public class PassengerController : Controller
    {
        public Context _context;

        public PassengerController()
        {
            _context = new Context();
        }


        protected override void Dispose(bool disposing)
        {

            _context.Dispose();
        }
        // GET: Passenger
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult PassengerPrint()
        {
            //eager loading
            var passlist = _context.Passengers.Include(x=>x.AccountType);

            //lazy loading
           // var passlist = _context.Passengers;
            return View(passlist);
        }

        public ActionResult Details(int id)
        {
            //lazy loading 
            var passengerlist = _context.Passengers;

            //eager loading
           var pass = passengerlist.Include(x=>x.AccountType).SingleOrDefault(x => x.Id == id);

           // var pass = passengerlist.SingleOrDefault(x => x.Id == id);
            if(pass == null)
            {
                return HttpNotFound();
            }
            return View(pass);


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
        public ActionResult PassengerDetails()
        {

           var passenger = new Passenger() { Id = 1, Name = "aditya", Balance = 3000 };

          //  var cab = new Cab() { Name = "nissan" };
            
            return View(passenger);


        }
    }
}