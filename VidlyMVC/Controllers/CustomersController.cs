using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using VidlyMVC.Models;

namespace VidlyMVC.Controllers
{
    public class CustomersController : Controller
    {
        public ViewResult Index()
        {
            var customers = GetCustomers();
            return View(customers);
        }

        public ActionResult Details(int id)
        {

            var customer = GetCustomers().SingleOrDefault(c => c.Id == id);

            if (customer == null)
                return Content("Customer does not exist");

            return View(customer);
        }

        private IEnumerable<Customer> GetCustomers()
        {
            return new List<Customer>
            {
                new Customer { Id = 1 , Name = "Tamara"},
                new Customer { Id = 2 , Name = "Aisana"},
                new Customer { Id = 3 , Name = "Lisi"},
                new Customer { Id = 4 , Name = "Yuri"}
            };
        }

    }
}
