using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Vidly.Models;

namespace Vidly.Controllers
{
    public class CustomersController : Controller
    {
        readonly List<Customer> _customers = new List<Customer>
            {
                new Customer {Id = 1, Name = "Daniel Vieira Vega" },
                new Customer {Id = 2, Name = "Paloma Santos" }
            };


        public ActionResult Details(int? id)
        {
            if (id != null)
            {
                var customer = _customers.Find(custom => custom.Id == id);

                if (customer != null)
                {
                    return View(new List<Customer> {customer});
                }
                else
                {
                    return Content("Not Found");
                }
            }
            else
            {
                return View(_customers);
            }
        }


    }
}