using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qwe.Models;
using System.Data.Entity;

namespace Qwe.Controllers
{
    public class HomeController : Controller
    {
        ShopShortContext db = new ShopShortContext();
        
        public ActionResult Index()
            {
                IEnumerable<Short> shorts = db.Shorts;
                ViewBag.Shorts = shorts;
                return View();
            }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            ViewBag.ShortId = id;
            return View();
        }
        [HttpPost]
        public string Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return purchase.GetFullname();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View();
        }
        [HttpPost]
        public object Add(Short add)
        {
            db.Shorts.Add(add);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            ViewBag.ShortId = id;
            return View();
        }
        [HttpPost]
        public object Edit(Short edit)
        {
            db.Entry(edit).State = EntityState.Modified;
            db.SaveChanges();
            return View();
        }

        public ActionResult Delete(int id)
        {
            ViewBag.ShortId = id;

            Short ShortId = db.Shorts.Find(id);
            db.Shorts.Remove(ShortId);
            db.SaveChanges();
            return View();
        }
    }
}