using Mvc_Uygulaması.Models.EFEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc_Uygulaması.Controllers
{
    public class CategoryController : Controller
    {
        // GET: Category
        NorthwindModel dbModel = new NorthwindModel();
        
        public ActionResult Index()
        {
            List<Categories> categories = dbModel.Categories.ToList();
            return View(categories);
        }
    }
}