﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Consumewebapp.Models
{
    public class Driver { 
         public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string ReTypeEmail { get; set; }
    public string Phone { get; set; }
    public string LicenseID { get; set; }
    public string Age { get; set; }
    public string Address { get; set; }
    public System.DateTime DateOfExpiry { get; set; }

}
}