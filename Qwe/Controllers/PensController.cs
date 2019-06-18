using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Qwe.Models;
using System.Data.Entity;

namespace Qwe.Controllers
{
    public class PensController : Controller
    {
        // GET: Pens
        PensContext dbp = new PensContext();

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
        public ActionResult Addp()
        {
            return View();
        }
        [HttpPost]
        public object Addp(Pens add)
        {
            // добавляем информацию о покупке в базу данных
            dbp.Penses.Add(add);
            // сохраняем в бд все изменения
            dbp.SaveChanges();
            return Pen();
        }

        [HttpGet]
        public ActionResult Editp(int id)
        {
            ViewBag.PensId = id;
            return View();
        }
        [HttpPost]
        public object Editp(Pens edit)
        {
            dbp.Entry(edit).State = EntityState.Modified;
            // сохраняем в бд все изменения
            dbp.SaveChanges();
            return View();
        }
    }
}