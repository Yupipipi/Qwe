using System;
using System.Web.Mvc;
using Qwe.Models;
using System.Data.Entity;
using System.Collections.Generic;
using System.Linq;

namespace Qwe.Controllers
{
    public class HomeController : Controller
    {
        ShopShortContext db = new ShopShortContext();

        public ActionResult Index()
            {
                return View(db.Shorts);
            }
        [HttpGet]
        public ActionResult Buy(int id)
        {
            var info = db.Shorts.Find(id);
            return View(info);
        }
        [HttpPost]
        public object ResultBuy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(db.Shorts);
        }
        [HttpPost]
        public object ResultAdd(Short info)
        {
            db.Shorts.Add(info);
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var info = db.Shorts.Find(id);
            return View(info);
        }
        [HttpPost]
        public object Edit(Short edit)
        {
            db.Entry(edit).State = EntityState.Modified;
            db.SaveChanges();
            return View();
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            Short ShortId = db.Shorts.Find(id);
            db.Shorts.Remove(ShortId);
            db.SaveChanges();
            return View(ShortId);
        }
        [HttpPost]
        public object ResultDelete()
        {
            return View();
        }
    }
}