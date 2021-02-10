using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using Consumewebapp.Models;
using System.IO;
//using System.Net.Http.

namespace Consumewebapp.Controllers
{
    public class DriverDisplayController : Controller
    {
        // GET: DriverDisplay
        public ActionResult Index()
        {

            IEnumerable<Driver> drivers = null;

            using(var client=new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:62104/api/");

                var responseTast = client.GetAsync("Driver");
                responseTast.Wait();

                var result = responseTast.Result;

                if (result.IsSuccessStatusCode)

                {
                    var readTask = result.Content.ReadAsAsync<IList<Driver>>();
                    readTask.Wait();
                    drivers = readTask.Result;
                }

                else
                {
                    drivers = Enumerable.Empty<Driver>();
                    ModelState.AddModelError(string.Empty, "Server error . Please check");
                }
            }
            return View(drivers);
        }

        public ActionResult AjaxGet()
        {
            return View();
        }

        public ActionResult DataTableGet()
        {
            return View();
        }
    }
}