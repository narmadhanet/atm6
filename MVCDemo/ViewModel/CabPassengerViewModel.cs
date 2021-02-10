using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCDemo.Models;
namespace MVCDemo.ViewModel
{
    public class CabPassengerViewModel
    {
        public Cab Cab { get; set; }

        public List<Passenger> Passengers { get; set; }
    }
}