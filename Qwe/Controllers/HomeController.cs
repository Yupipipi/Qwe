using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qwe.Models;

namespace Qwe.Controllers
{
    public class HomeController : Controller
    {
        // создаем контекст данных
        ShortContext db = new ShortContext();
        PensContext dbp = new PensContext();

        public ActionResult Index()
            {
                // получаем из бд все объекты 
                IEnumerable<Short> shorts = db.Shorts;
                // передаем все объекты в ViewBag
                ViewBag.Shorts = shorts;
                // возвращаем представление
                return View();
            }
        public ActionResult Pen()
        {
            // получаем из бд все объекты 
            IEnumerable<Pens> penses = dbp.Penses;
            // передаем все объекты в ViewBag
            ViewBag.Penses = penses;
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
        public ActionResult Buyp(int id)
        {
            ViewBag.PensId = id;
            return View();
        }
        [HttpPost]
        public string Buyp(Purchasep purchasep)
        {
            purchasep.Date = DateTime.Now;
            // добавляем информацию о покупке в базу данных
            dbp.Purchasesp.Add(purchasep);
            // сохраняем в бд все изменения
            dbp.SaveChanges();
            return purchasep.GetFullname();
        }
        public ActionResult Primer()
        {
            return View();
        }
        public string Alex()
        {
            Dopoln alex = new Dopoln();
            alex.Name = "Alex";
            alex.Age = 20;
            return "<h2>Имя: " + alex.Name + " Возраст: " + alex.Age;
        }
    }
}