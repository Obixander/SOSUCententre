using SosuCentre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.DataAccess
{
    public class MedicineTaskRepository(SosuCentreContext context) : Repository<MedicineTask>(context), IMedicineTaskRepository
    {
        public void Add(MedicineTask entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(MedicineTask entity)
        {
            throw new NotImplementedException();
        }

        public void Update(MedicineTask entity)
        {
            throw new NotImplementedException();
        }

    }
}
