using Microsoft.EntityFrameworkCore;
using SosuCentre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.DataAccess
{
    public class TaskRepository(SosuCentreContext context) : Repository<Entities.Assignment>(context), ITaskRepository
    {
        public override Entities.Assignment GetBy(int id)
        {
            return context.Assignment
                 .Include(t => t.Employees)
                 .Include(t => t.Resident)
                 .FirstOrDefault(t => t.AssignmentId == id);
        }
        public IEnumerable<Entities.Assignment> GetAssignmentsOn(Employee employee,DateTime date)
        {
            IEnumerable<Entities.Assignment> tasks = context.Assignment
                .Where(a => a.Employees.Contains(employee) && a.TimeStart == date.Date)
                .Include(t => t.Resident)
                .Include(t => t.Employees)
                .ToList();  
            return tasks;
        }

        public IEnumerable<Entities.Assignment> GetAssignmentsFor(Employee employee)
        {
            
            List<Entities.Assignment> tasks = context.Assignment
                .Where(a => a.Employees.Contains(employee))
                .Include(t => t.Resident)
                .Include(t => t.Employees)
                .ToList();
            return tasks;
        }

        public void AddEmployeeToTask(Entities.Assignment task, int EmployeeId)
        {
            task.Employees.Add(context.Employees.FirstOrDefault(e => e.EmployeeId == EmployeeId));
            context.SaveChanges();
        }

        

    }



}
