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

        public ActionResult AddNew()
        {
            return RedirectToAction("Detail", new { userID = -1, isUpdate = false });
        }

        public ActionResult Detail(string userID,bool isUpdate)
        {
            Customers customer = dbModel.Customers.FirstOrDefault(p => p.CustomerID.Equals(userID));
            if (customer != null)
            {
                if(isUpdate)
                    ViewBag.Message = "Kayıt Güncellendi";
                return View(customer);
            }
            else
                return View();
        }

        public ActionResult Update(Customers willUpdated, bool isUpdate)
        {
            if (!string.IsNullOrEmpty(willUpdated.CustomerID))
            {
                var updatedEntity = dbModel.Entry(willUpdated);
                updatedEntity.State = System.Data.Entity.EntityState.Modified;
                dbModel.SaveChanges();
                return RedirectToAction("Detail", new { userID = willUpdated.CustomerID, isUpdate = true });
            }
            else
            {
                var added = dbModel.Entry(willUpdated);
                added.State = System.Data.Entity.EntityState.Added;
                dbModel.SaveChanges();
                return RedirectToAction("Detail", new { userID = added.Entity.CustomerID, isUpdate = false });
            }
        }
    }
}