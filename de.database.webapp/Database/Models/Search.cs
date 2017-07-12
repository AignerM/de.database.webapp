using System.Collections.Generic;
using NorthwindContext;

namespace Database.Models
{
    public class Search
    {
        public List<Customer> SearchResultCustomer { get; set; }
        public List<Order> SearchResultOrders { get; set; }
        public List<Order_Detail> SearchResultDetailOrder { get; set; }
    }
}