using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Qwe.Models
{
    public class ShortDbInitializer : DropCreateDatabaseAlways<ShortContext>
    {
        protected override void Seed(ShortContext db)
        {
            db.Shorts.Add(new Short { Sex = "Муж", Name = "Puma", Size = "S", Price = 220 });
            db.Shorts.Add(new Short { Sex = "Муж", Name = "Adidas", Size = "M", Price = 180 });
            db.Shorts.Add(new Short { Sex = "Жен", Name = "MF", Size = "L", Price = 150 });

            base.Seed(db);
        }
    }
}