using Entities;
using Logic;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            var logic = new CustomersLogic();
            List<Customers> customers = logic.GetAll();
            return View(customers);
        }
    }
}