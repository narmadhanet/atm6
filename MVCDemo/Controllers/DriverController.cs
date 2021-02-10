using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class DriverController : Controller
    {
        private Context context;

        public DriverController()
        {
            context = new Context();
        }

        protected override void Dispose(bool disposing)
        {
            context.Dispose();
        }
        // GET: Driver
        public ActionResult Index()
        {

            return View(context.Driver.ToList());
        }

        [HttpPost,ActionName("Create")]
        public ActionResult CreateData(Driver dobj)
        {
            if (ModelState.IsValid)
            {
                context.Driver.Add(dobj);
                context.SaveChanges();

                return RedirectToAction("Index");
            }return View(dobj);



        }

        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Driver driver = context.Driver.Find(id);
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);

        }

        [HttpPost]
        public ActionResult Edit(Driver dobj)
        {
            if (ModelState.IsValid)
            {
                //Driver d = context.Driver.Find(dobj.Id);
                //d.Age = dobj.Age;

                context.Entry(dobj).State = EntityState.Modified;
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(dobj);

        }
        public ActionResult Create()
        {
            return View();
        }
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);

            }
            Driver driver = context.Driver.Find(id);
            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);
        }
        [HttpPost]
        public ActionResult Delete(Driver dobj)
        {

            Driver driver = context.Driver.Find(dobj.Id);

            context.Driver.Remove(driver);
            context.SaveChanges();
            return RedirectToAction("Index");

        }
        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Driver driver = context.Driver.Find(id);

            if (driver == null)
            {
                return HttpNotFound();
            }
            return View(driver);

        }
    }
}