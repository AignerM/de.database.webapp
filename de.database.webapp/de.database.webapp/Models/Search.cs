﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace de.database.webapp.Models
{
    public class Search
    {
        public List<Customer> SearchResultCustomer { get; set; }
        public List<Order> SearchResultOrders { get; set; }
        public List<Order_Detail> SearchResultDetailOrder { get; set; }
    }
}