using SmartPhoneShop.Entites.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SmartPhoneShop.Business.Abstract
{
    public interface ISmartPhoneService
    {
        List<SmartPhone> GetAll(Expression<Func<SmartPhone, bool>> filter = null);
        SmartPhone Get(Expression<Func<SmartPhone, bool>> filter);
        void Add(SmartPhone smartphone);
        void Update(SmartPhone smartphone);
        void Delete(SmartPhone smartphone);
    }
}
