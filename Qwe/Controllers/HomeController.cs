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
        // создаем контекст данных
        ShortContext db = new ShortContext();
        
        public ActionResult Index()
            {
                // получаем из бд все объекты 
                IEnumerable<Short> shorts = db.Shorts;
                // передаем все объекты в ViewBag
                ViewBag.Shorts = shorts;
                // возвращаем представление
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
            // добавляем информацию о покупке в базу данных
            db.Purchases.Add(purchase);
            // сохраняем в бд все изменения
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
            // добавляем информацию о покупке в базу данных
            db.Shorts.Add(add);
            // сохраняем в бд все изменения
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
            // сохраняем в бд все изменения
            db.SaveChanges();
            return View();
        }
        /*
        [HttpGet]
        public ActionResult Delete(int id)
        {
            ViewBag.ShortId = id;
            return View();
        }
        [HttpPost]
        public object Delete()
        {
            int id = ViewBag.ShortId;
            db.Entry(id).State = EntityState.Deleted;
            // сохраняем в бд все изменения
            db.SaveChanges();
            return View();
        }*/
    }
}