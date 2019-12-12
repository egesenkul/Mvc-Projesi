using Mvc_Uygulaması.Models.EFEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Uygulaması.Controllers
{
    public class ProductController : Controller
    {
        // GET: Product
        NorthwindModel dbModel = new NorthwindModel();
        public ActionResult Index()
        {
            List<Products> urunler = dbModel.Products.ToList();
            return View(urunler);
        }
    }
}