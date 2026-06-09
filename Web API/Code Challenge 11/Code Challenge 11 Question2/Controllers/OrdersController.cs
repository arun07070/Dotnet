using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Code_Challenge_11_Question2;

namespace Code_Challenge_11_Question2.Controllers
{
    public class OrdersController : ApiController
    {
        northwindEntities db = new northwindEntities();

        [HttpGet]
        [Route("api/orders/buchanan")]
        public IHttpActionResult GetOrders()
        {
            var orders = db.Orders
                           .Where(o => o.EmployeeID == 5)
                           .Select(o => new
                           {
                               o.OrderID,
                               o.CustomerID,
                               o.OrderDate,
                               o.ShipCountry
                           })
                           .ToList();

            return Ok(orders);
        }
    }
}