using Mvc_Uygulaması.Models.EFEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Uygulaması.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        NorthwindModel dbModel = new NorthwindModel();
        public ActionResult Index()
        {
            List<Customers> customers = dbModel.Customers.ToList();
            return View(customers);
        }
    }
}