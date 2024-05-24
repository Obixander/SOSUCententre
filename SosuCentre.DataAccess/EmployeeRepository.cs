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

        public IEnumerable<Employee> GetAllBy(Role role)
        {
            return context.Employees.Where(e => e.Role.Contains(role))
                .Include(e=>e.Role)
                .Include(e=>e.CareCenter);
        }

        public IEnumerable<Employee> GetAll()
        {
            return context.Employees
                .Include(e => e.Role)
                .Include(e => e.CareCenter)
                .ToList();
        }

    }
}
