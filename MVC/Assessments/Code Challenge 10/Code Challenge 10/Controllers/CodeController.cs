using System.Linq;
using System.Web.Mvc;
using Code_Challenge_10.Models;

namespace Code_Challenge_10.Controllers
{
    public class CodeController : Controller
    {
        northwindEntities db = new northwindEntities();

        public ActionResult Index()
        {
            return View();
        }
        public ActionResult GermanyCustomers()
        {
            var customers = db.Customers
                              .Where(c => c.Country == "Germany")
                              .ToList();

            return View(customers);
        }
        public ActionResult OrderCustomer()
        {
            var customer = db.Orders
                             .Where(o => o.OrderID == 10248)
                             .Select(o => o.Customer)
                             .FirstOrDefault();

            return View(customer);
        }
    }
}