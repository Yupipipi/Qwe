using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Qwe.Models
{
    public class PensDbInitializer : DropCreateDatabaseAlways<PensContext>
    {
        protected override void Seed(PensContext db)
        {
            db.Penses.Add(new Pens { Sex = "Жен", Name = "Nike", Size = "M", Price = 150 });
            db.Penses.Add(new Pens { Sex = "Муж", Name = "Adidas", Size = "XXL", Price = 250 });
            db.Penses.Add(new Pens { Sex = "Жен", Name = "Upf", Size = "XL", Price = 200 });

            base.Seed(db);
        }
    }
}