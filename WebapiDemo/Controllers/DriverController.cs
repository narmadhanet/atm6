using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace WebapiDemo.Controllers
{[EnableCors(origins:"*",headers:"*",methods:"*")]
    public class DriverController : ApiController
    {
        CabDBEntities _context = new CabDBEntities();


        public IEnumerable<Driver> GetDrivers()
        {
            return _context.Drivers.ToList();
        }

        public Driver GetDriver(int id)
        {
            return _context.Drivers.Find(id);
        }

        [HttpDelete]
        public bool DeleteDriver(int id)
        {
            bool successFlag = false;
            var driver = _context.Drivers.Find(id);
            if (driver != null)
            {
                _context.Drivers.Remove(driver);
                _context.SaveChanges();
                successFlag = true;
                return successFlag;
            }
            return successFlag;
        }

        [HttpPost]
        public bool AddDriver(Driver d)
        {
            bool successFlag = false;
            _context.Drivers.Add(d);
            _context.SaveChanges();
            successFlag = true;
            return successFlag;
        }

        [HttpPut]
        public bool UpdateDriver(Driver d)
        {
            bool successflag = false;
            var driver = _context.Drivers.Find(d.Id);
            if (driver != null)
            {
                driver.Name = d.Name;
                driver.LicenseID = d.LicenseID;
                _context.SaveChanges();
                successflag = true;
                return successflag;
            }
            return successflag;
        }
    }
}
