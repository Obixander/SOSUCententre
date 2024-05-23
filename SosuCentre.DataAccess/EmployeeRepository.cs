using Microsoft.EntityFrameworkCore;
using SosuCentre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.DataAccess
{
    public class EmployeeRepository(SosuCentreContext context) : Repository<Employee>(context), IEmployeeRepository
    {
        public Employee GetById(int id)
        {
            return context.Employees.FirstOrDefault(t => t.EmployeeId == id);
        }
    }
}
