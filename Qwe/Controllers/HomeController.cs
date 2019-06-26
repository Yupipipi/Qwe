using System;
using System.Web.Mvc;
using Qwe.Models;
using System.Data.Entity;

namespace Qwe.Controllers
{
    public class HomeController : Controller
    {
        ShopShortContext db = new ShopShortContext();

        //[MyResult]
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
        public object Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            return View("Result");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(db.Shorts);
        }

        [HttpPost]
        public object Add(Short info)
        {
            string str = info.Size.SizeConventer();
            info.Size = str;
            try
            {
                if (info.Price > 500)
                {
                    throw new Exception("Цена выше допустимых 500 единиц");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ошибка: {ex.Message}");
                return RedirectPermanent("/Home/Add");  //переадресация
            }
            db.Shorts.Add(info);
            db.SaveChanges();
            return View("Result");
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
            return View("Result");
        }

        [MyResult]
        public ActionResult Delete(int id)
        {
            Short ShortId = db.Shorts.Find(id);
            db.Shorts.Remove(ShortId);
            db.SaveChanges();
            return View(ShortId);
        }

        public object Result(Uri info)
        {
            info = Request.UrlReferrer;
            return View(info);
        }
    }
}