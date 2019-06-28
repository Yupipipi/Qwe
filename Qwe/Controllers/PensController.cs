using System;
using System.Web.Mvc;
using Qwe.Models;
using System.Data.Entity;

namespace Qwe.Controllers
{
    public class PensController : Controller
    {
        ShopPensContext dbp = new ShopPensContext();

        [OutputCache(Duration = 360)]
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
            ViewBag.Operation = "Покупка";
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
            ViewBag.Operation = "Добавление";
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
            string str = edit.Size.SizeConventer();
            edit.Size = str;
            dbp.Entry(edit).State = EntityState.Modified;
            dbp.SaveChanges();
            ViewBag.Operation = "Редактирование";
            return View("Result");
        }

        [HttpGet]
        public ActionResult Deletep(int id)
        {
            Pens PensId = dbp.Penses.Find(id);
            dbp.Penses.Remove(PensId);
            dbp.SaveChanges();
            ViewBag.Operation = "Удаление";
            return View(PensId);
        }

        public object Result()
        {
            ViewBag.Operation = "Удаление";
            return View();
        }
    }
}