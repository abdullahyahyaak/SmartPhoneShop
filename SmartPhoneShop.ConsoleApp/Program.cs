using SmartPhoneShop.Business.Abstract;
using SmartPhoneShop.Business.Concrete;
using SmartPhoneShop.Business.CrossCuttingConcerns.DependecyResolvers.Ninject;
using SmartPhoneShop.DataAcsessLayer.Concrete.ADONET;
using SmartPhoneShop.DataAcsessLayer.Concrete.EntityFramework;
using SmartPhoneShop.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneShop.ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var smartphonemanager = new SmartPhoneManager(new AdoSmartPhoneDal());

            var smartphone = new SmartPhone() { SmartPhoneId = 6, Model = "Samsung Galaxy S20", ScreenSize = 6.78, Price = 5630 };

            smartphonemanager.Add(smartphone);
            smartphonemanager.GetAll().ForEach(o => Console.WriteLine(o));

            smartphonemanager.Delete(smartphone);
            smartphonemanager.GetAll().ForEach(o => Console.WriteLine(o));

            smartphonemanager.Delete(smartphone);
            var bookService = InstanceFactory.GetInstance<ISmartPhoneService>();
            bookService.GetAll().ForEach(o => Console.WriteLine(o));






            Console.ReadLine();

        }
    }
}
