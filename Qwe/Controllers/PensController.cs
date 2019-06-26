using System;
using System.Web.Mvc;
using Qwe.Models;
using System.Data.Entity;

namespace Qwe.Controllers
{
    public class PensController : Controller
    {
        ShopPensContext dbp = new ShopPensContext();

        public ActionResult Pen()
        {
            return View(dbp.Penses);
        }
        [HttpGet]
        public ActionResult Buyp(int id)
        {
            var info = dbp.Penses.Find(id);
            return View(info);
        }
        [HttpPost]
        public object Buyp(Purchasep purchasep)
        {
            purchasep.Date = DateTime.Now;
            dbp.Purchasesp.Add(purchasep);
            dbp.SaveChanges();
            ViewBag.Buy = "Покупка";
            return View("Result");
        }
        public ActionResult Addp()
        {
            return View(dbp.Penses);
        }
        [HttpPost]
        public object Addp(Pens info)
        {
            string str = info.Size.SizeConventer();
            info.Size = str;
            dbp.Penses.Add(info);
            dbp.SaveChanges();
            ViewBag.Add = "Добавление";
            return View("Result");
        }

        [HttpGet]
        public ActionResult Editp(int id)
        {
            var info = dbp.Penses.Find(id);
            return View(info);
        }

        [HttpPost]
        public object Editp(Pens edit)
        {
            dbp.Entry(edit).State = EntityState.Modified;
            dbp.SaveChanges();
            ViewBag.Edit = "Редактирование";
            return View("Result");
        }

        [HttpGet]
        public ActionResult Deletep(int id)
        {
            Pens PensId = dbp.Penses.Find(id);
            dbp.Penses.Remove(PensId);
            dbp.SaveChanges();
            ViewBag.Delete = "Удаление";
            return View(PensId);
        }

        public object Result()
        {
            ViewBag.Delete = "Удаление";
            return View();
        }
    }
}