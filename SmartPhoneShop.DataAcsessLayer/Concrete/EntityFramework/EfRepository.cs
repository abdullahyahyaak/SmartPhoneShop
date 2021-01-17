using SmartPhoneShop.DataAcsessLayer.Abstract;
using SmartPhoneShop.Entites.Concrete;
using SmartPhoneShop.Entites.Abstract;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace SmartPhoneShop.DataAcsessLayer.Concrete.EntityFramework
{
    public class EfRepository<Tentity, Tcontext> : IEntityRepository<Tentity> 
        where Tentity : class , IEntity , new()
        where Tcontext : DbContext , new()
    {
        public void Add(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public Tentity Get(Expression<Func<Tentity, bool>> filter)
        {
            using (var context = new Tcontext())
            {
                return context.Set<Tentity>().SingleOrDefault(filter);
            }
        }

        public List<Tentity> GetAll(Expression<Func<Tentity, bool>> filter = null)
        {
            using (var context = new Tcontext())
            {
                return filter == null ?
                    context.Set<Tentity>().ToList() :
                    context.Set<Tentity>()
                    .Where(filter)
                    .ToList();
            }
        }

        public void Update(Tentity entity)
        {
            using (var context = new Tcontext())
            {
                context.Entry(entity).State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
