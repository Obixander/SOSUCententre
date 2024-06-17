using SosuCentre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.DataAccess
{
    public class SubTaskRepository(SosuCentreContext context) : Repository<Employee>(context), ISubTaskRepository
    {
        public void Add(SubTask entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(SubTask entity)
        {
            throw new NotImplementedException();
        }

        public void Update(SubTask entity)
        {
            throw new NotImplementedException();
        }

        IEnumerable<SubTask> IRepository<SubTask>.GetAll()
        {
            throw new NotImplementedException();
        }

        SubTask IRepository<SubTask>.GetBy(int id)
        {
            throw new NotImplementedException();
        }
    }
}
