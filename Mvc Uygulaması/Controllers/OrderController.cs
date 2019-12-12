using Mvc_Uygulaması.Models.EFEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Uygulaması.Controllers
{
    public class OrderController : Controller
    {
        // GET: Order
        NorthwindModel NorthwindModel = new NorthwindModel();
        public ActionResult Index()
        {
            List<Orders> orders = NorthwindModel.Orders.ToList();
            return View(orders);
        }
    }
}