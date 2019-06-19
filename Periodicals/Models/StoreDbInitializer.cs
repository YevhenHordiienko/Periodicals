using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Periodicals.Web.Models
{
    public class StoreDbInitializer : DropCreateDatabaseAlways<MobileContext>
    {
        protected override void Seed(MobileContext context)
        {
            context.Phones.Add(new Phone { Name = "Nokia Lumia 630", Company = "Nokia", Price = 220 });
            context.Phones.Add(new Phone { Name = "iPhone 6", Company = "Apple", Price = 320 });
            context.Phones.Add(new Phone { Name = "LG G4", Company = "lG", Price = 260 });
            context.Phones.Add(new Phone { Name = "Samsung Galaxy S 6", Company = "Samsung", Price = 300 });

            //See the Global.asax.cs
            base.Seed(context);
            context.SaveChanges();
        }
    }
}