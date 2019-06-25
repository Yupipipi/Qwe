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
        public object ResultBuyp(Purchasep purchasep)
        {
            purchasep.Date = DateTime.Now;
            dbp.Purchasesp.Add(purchasep);
            dbp.SaveChanges();
            return View();
        }
        public ActionResult Addp()
        {
            return View(dbp.Penses);
        }
        [HttpPost]
        public object ResultAddp(Pens add)
        {
            dbp.Penses.Add(add);
            dbp.SaveChanges();
            return View();
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
            return View(dbp.Penses);
        }

        [HttpGet]
        public ActionResult Deletep(int id)
        {
            Pens PensId = dbp.Penses.Find(id);
            dbp.Penses.Remove(PensId);
            dbp.SaveChanges();
            return View(PensId);
        }
        [HttpPost]
        public object ResultDeletep()
        {
            return View();
        }
    }
}