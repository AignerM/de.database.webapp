using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using de.database.webapp.Models;
using System.Web.Mvc;
using System.Data.Entity;
using NorthwindContext;

namespace de.database.webapp.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext.NorthwindContext db = new NorthwindContext.NorthwindContext();
        static private Search search = new Search();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Kunde()
        {
            return View();
        }

        public ActionResult GetKunde()
        {
            var dd = Request.Form["customer"];
            
            
                var searchResult = db.Customers
                    .Where(x => x.CompanyName.Contains(dd) || x.CustomerID.Contains(dd) || x.ContactName.Contains(dd));
                var liSearchResult=searchResult.ToList<Customer>();
                search.SearchResultCustomer = liSearchResult;
                
                return View("Kunde", search);
        }

        public ActionResult Bestellungen()
        {
            return View();
        }

        public ActionResult GetOrders()
        {
            var id = Request.QueryString["id"];

            var searchResult = db.Orders
                .Where(x => x.CustomerID == id);
            var liSearchResult = searchResult.ToList<Order>();
            search.SearchResultOrders = liSearchResult;
            return View("Bestellungen",search);
        }

        public ActionResult Bestellungs_Details()
        {
            return View();
        }

        public ActionResult GetDetail_Order()
        {
            var id = Convert.ToInt32(Request.QueryString["id"]);

            var searchResult = db.Order_Details
                .Where(x => x.OrderID == id);
            var liSearchResult = searchResult.ToList<Order_Detail>();
            search.SearchResultDetailOrder = liSearchResult;
            return View("Bestellungs_Details", search);
        }
    }
}