using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
namespace MVCDemo.Models
{
    public class Context :DbContext
    {
        public Context() : base("cs") { }

        public DbSet<Cab> Cabs { get; set; }

        public DbSet<Passenger> Passengers { get; set; }

        public DbSet<AccountType> AccountType { get; set; }

        public DbSet<Driver> Driver { get; set; }
    }
}