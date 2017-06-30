using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using NorthwindContext;

namespace Database.Models
{
    public class Edit
    {
        public string ContactName { get; set; }
        public string ContactTitle { get; set; }
        public string Adress { get; set; }
        public string City { get; set; }
        public string PLZ { get; set; }
        public string Country { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string CompanyName { get; set; }
        public string CustomerID { get; set; }
    }
}