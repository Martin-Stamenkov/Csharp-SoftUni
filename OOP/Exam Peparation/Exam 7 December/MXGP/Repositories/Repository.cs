using MXGP.Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MXGP.Repositories
{
    public abstract class Repository<T> : IRepository<T>
    {
        private readonly List<T> getAll;
        protected List<T> data => getAll;

        protected Repository()
        {
            this.getAll = new List<T>();
        }

        public void Add(T model)
        {
            getAll.Add(model);
        }


        public IReadOnlyCollection<T> GetAll()
        {
            return getAll;
        }

        public abstract T GetByName(string name);
             
        public bool Remove(T model)
        {
            return getAll.Remove(model);
        }
    }
}
