using SmartPhoneShop.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneShop.DataAcsessLayer.Concrete.EntityFramework
{
    public class SmartPhoneShopContext : DbContext
    {
        public DbSet<SmartPhone> SmartPhones { get; set; }

    }
}
