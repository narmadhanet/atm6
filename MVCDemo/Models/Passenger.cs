using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class Passenger
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Balance { get; set; }

     

        public AccountType AccountType { get; set; }

        public byte? AccountTypeId { get; set; }
    }
}