using Ninject.Modules;
using SmartPhoneShop.Business.Abstract;
using SmartPhoneShop.Business.Concrete;
using SmartPhoneShop.DataAcsessLayer.Abstract;
using SmartPhoneShop.DataAcsessLayer.Concrete.ADONET;
using SmartPhoneShop.DataAcsessLayer.Concrete.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneShop.Business.CrossCuttingConcerns.DependecyResolvers.Ninject
{
    public class BusinessModule : NinjectModule
    {
        public override void Load()
        {
            Bind<ISmartPhoneService>().To<SmartPhoneManager>().InSingletonScope();
            Bind<ISmartPhoneDal>().To<AdoSmartPhoneDal>().InSingletonScope();
        }
    }
}
