using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class AccountType
    {
        public byte Id { get; set; }

        public string Name { get; set; }

        public double PrePaidAmount { get; set; }

        public byte DurationInMonths { get; set; }

        public byte OfferRate { get; set; }
    }
}