using SmartPhoneShop.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneShop.Entites.Concrete
{
    public class SmartPhone : IEntity
    {
        public int SmartPhoneId { get; set; }
        public string Model { get; set; }
        public double ScreenSize { get; set; }
        public decimal Price { get; set; }


        public override string ToString() => $"{SmartPhoneId,-5}{Model,-40}{ScreenSize,-7}{Price,-10}";





    }

}
