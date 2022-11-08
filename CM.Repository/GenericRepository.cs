using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CM.DOMAIN.Interfaces;

namespace CM.Repository
{
    public  class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        protected readonly CMDbContext _cMDbContext;
        private DbSet<T> table = null;

        public GenericRepository()
        {
            this._cMDbContext = new CMDbContext();
            table = _cMDbContext.Set<T>();
        }
        public GenericRepository(CMDbContext cMDbContext)
        {
            this._cMDbContext = cMDbContext;
            table = _cMDbContext.Set<T>();
        }

        public void Delete(object id)
        {
            T existing = table.Find(id);
            table.Remove(existing);
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

        public void Insert(T obj)
        {
            table.Add(obj);
        }

        public void Save()
        {
            _cMDbContext.SaveChanges();
        }

        public void Update(T obj)
        {
            table.Attach(obj);
            _cMDbContext.Entry(obj).State = EntityState.Modified;
        }
    }
}
