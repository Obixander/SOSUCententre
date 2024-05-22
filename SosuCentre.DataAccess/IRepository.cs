using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.DataAccess
{
    public interface IRepository<T>
    {
        void Add(T Entity);
        void Update(T Entity);
        void Delete(T Entity);
        T GetById(int Id);
        IEnumerable<T> GetAll();

    }

    public class Repository<T> : IRepository<T>
    {
        private readonly SosuCentreContext context;

        public Repository(SosuCentreContext context)
        {
            this.context = context;
        }


        public void Add(T Entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(T Entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(T Entity)
        {
            throw new NotImplementedException();
        }
    }
}
