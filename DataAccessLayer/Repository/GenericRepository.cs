using DataAccessLayer.Abstract;
using DataAccessLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Repository
{
    public class GenericRepository<T> : IGenericDal<T> where T : class
    {
        public void Delete(T vrb_t)
        {
            using var c = new Context();
            c.Remove(vrb_t);
            c.SaveChanges();
        }

        public List<T> GetAll()
        {
            using var c = new Context();
            return c.Set<T>().ToList();
        }

        public void Insert(T vrb_t)
        {
            using var c = new Context();
            c.Add(vrb_t);
        }

        public void Update(T vrb_t)
        {
            using var c = new Context();
            c.Update(vrb_t);
        }
    }
}
