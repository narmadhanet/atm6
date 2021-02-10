using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Cab
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime ManufacturedDate { get; set; }

        //has a
        public CabType CabType { get; set; }

        public int? CabTypeId { get; set; }
    }
}