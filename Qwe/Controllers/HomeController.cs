using System;
using System.Web.Mvc;
using Qwe.Models;
using System.Data.Entity;

namespace Qwe.Controllers
{
    public class HomeController : Controller
    {
        ShopShortContext db = new ShopShortContext();

        [OutputCache(Duration = 360)]
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
        public ActionResult Buy(Purchase purchase)
        {
            purchase.Date = DateTime.Now;
            db.Purchases.Add(purchase);
            db.SaveChanges();
            ViewBag.Operation = "Покупка";
            return View("Result");
        }

        [HttpGet]
        public ActionResult Add()
        {
            return View(db.Shorts);
        }

        [HttpPost]
        public ActionResult Add(Short info)
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
            finally
            {
                ViewBag.Operation = "Добавление";
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
        public ActionResult Edit(Short edit)
        {
            string str = edit.Size.SizeConventer();
            edit.Size = str;
            db.Entry(edit).State = EntityState.Modified;
            db.SaveChanges();
            ViewBag.Operation = "Редактирование";
            return View("Result");
        }

        [MyResult]
        public ActionResult Delete(int id)
        {
            Short ShortId = db.Shorts.Find(id);
            db.Shorts.Remove(ShortId);
            db.SaveChanges();
            ViewBag.Operation = "Удаление";
            return View(ShortId);
        }

        public ActionResult Result()
        {
            ViewBag.Operation = "Удаление";
            return View();
        }
    }
}