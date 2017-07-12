using System;
using System.Linq;
using Database.Models;
using System.Web.Mvc;
using NorthwindContext;

namespace Database.Controllers
{
    public class HomeController : Controller
    {
        NorthwindContext.NorthwindContext db = new NorthwindContext.NorthwindContext();
        static private Search search = new Search();
        static private Edit edit = new Edit();

        public ActionResult Index()
        {
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

        public ActionResult Edit()
        {
            var id = Request.QueryString["id"];
            var searchResult = db.Customers
                .Where(x => x.CustomerID == id);
            foreach(var item in searchResult)
            {
                //edit.Adress = item.Wohnort.Adress;
                //edit.City = item.City;
                //edit.ContactName = item.ContactName;
                //edit.ContactTitle = item.ContactTitle;
                //edit.Country = item.Country;
                //edit.Fax = item.Fax;
                //edit.Phone = item.Phone;
                //edit.PLZ = item.PostalCode;
                //edit.CompanyName = item.CompanyName;
            }
            edit.CustomerID = id;
            return View(edit);
        }

        public ActionResult AcceptEdit()
        {
            //var customerTitle = Request.Form["customerTitle"];
            //var customer = Request.Form["customer"];
            //var companyName = Request.Form["companyName"];
            //var adress = Request.Form["adress"];
            //var PLZ = Request.Form["PLZ"];
            //var city = Request.Form["city"];
            //var country = Request.Form["country"];
            //var phone = Request.Form["phone"];
            //var fax = Request.Form["fax"];
            //var editCustomer = db.Customers.Where(x => x.CustomerID == edit.CustomerID).First();
            //if (customerTitle != null && customerTitle != edit.ContactTitle)
            //{
            //    editCustomer.ContactTitle = customerTitle;
            //}
            //if(customer!=null&& customer != edit.ContactName)
            //{
            //    editCustomer.ContactName = customer;
            //}
            //if (companyName != null && companyName != edit.CompanyName)
            //{
            //    editCustomer.CompanyName = companyName;
            //}
            //if (adress != null && adress != edit.Adress)
            //{
            //    editCustomer.Address = adress;
            //}
            //if (PLZ != null && PLZ != edit.PLZ)
            //{
            //    editCustomer.PostalCode = PLZ;
            //}
            //if (city != null && city != edit.City)
            //{
            //    editCustomer.City = city;
            //}
            //if (country != null && country != edit.Country)
            //{
            //    editCustomer.Country = country;
            //}
            //if (phone != null && phone != edit.Phone)
            //{
            //    editCustomer.Phone = phone;
            //}
            //if (fax != null && fax != edit.Fax)
            //{
            //    editCustomer.Fax = fax;
            //}
            //db.SaveChanges();
            //return View("Kunde");
        }
    }
}