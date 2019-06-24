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
        ShopPensContext dbp = new ShopPensContext();

        public ActionResult Pen()
        {
            return View(dbp.Penses);
        }
        [HttpGet]
        public ActionResult Buyp()
        {
            return View(dbp.Penses);
        }
        [HttpPost]
        public string Buyp(Purchasep purchasep)
        {
            purchasep.Date = DateTime.Now;
            dbp.Purchasesp.Add(purchasep);
            dbp.SaveChanges();
            return purchasep.GetFullname();
        }
        public ActionResult Addp()
        {
            return View(dbp.Penses);
        }
        [HttpPost]
        public object Addp(Pens add)
        {
            dbp.Penses.Add(add);
            dbp.SaveChanges();
            return View(dbp.Penses);
        }

        [HttpGet]
        public ActionResult Editp()
        {
            return View(dbp.Penses);
        }
        [HttpPost]
        public object Editp(Pens edit)
        {
            dbp.Entry(edit).State = EntityState.Modified;
            dbp.SaveChanges();
            return View(dbp.Penses);
        }

        public ActionResult Deletep(int id)
        {
            Pens PensId = dbp.Penses.Find(id);
            dbp.Penses.Remove(PensId);
            dbp.SaveChanges();
            return View(dbp.Penses);
        }
    }
}