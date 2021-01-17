using SmartPhoneShop.Business.Abstract;
using SmartPhoneShop.DataAcsessLayer.Abstract;
using SmartPhoneShop.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneShop.Business.Concrete
{
    public class SmartPhoneManager : ISmartPhoneService
    {
        ISmartPhoneDal _smartphoneDal;

        public SmartPhoneManager(ISmartPhoneDal smartphoneDal)
        {
            _smartphoneDal = smartphoneDal;
        }

        public void Add(SmartPhone smartphone)
        {
            _smartphoneDal.Add(smartphone);
        }

        public void Delete(SmartPhone smartphone)
        {
            _smartphoneDal.Delete(smartphone);
        }

        public void Update(SmartPhone smartphone)
        {
            _smartphoneDal.Update(smartphone);
        }

        public SmartPhone Get(Expression<Func<SmartPhone, bool>> filter)
        {
            return _smartphoneDal.Get(filter);
        }

        public List<SmartPhone> GetAll(Expression<Func<SmartPhone, bool>> filter = null)
        {
            return _smartphoneDal.GetAll(filter);
        }

        
    }
}
