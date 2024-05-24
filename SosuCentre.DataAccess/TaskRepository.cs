using Microsoft.EntityFrameworkCore;
using SosuCentre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.DataAccess
{
    public class TaskRepository(SosuCentreContext context) : Repository<Entities.Task>(context), ITaskRepository
    {
        public override Entities.Task GetBy(int id)
        {
            return context.Tasks
                 .Include(t => t.Employees)
                 .Include(t => t.Medicines)
                 .Include(t => t.Resident)
                 .FirstOrDefault(t => t.TaskId == id);
        }
        public IEnumerable<Entities.Task> GetAssignmentsOn(DateTime date)
        {
            return context.Tasks.Where(a => a.TimeStart == date.Date);
        }

        public IEnumerable<Entities.Task> GetAssignmentsFor(Employee employee)
        {
            
            List<Entities.Task> tasks = context.Tasks
                .Where(a => a.Employees.Contains(employee))
                .Include(t => t.Resident)
                .Include(t => t.Medicines)
                .Include(t => t.Employees)
                .ToList();
            return tasks;
        }

        public void AddEmployeeToTask(Entities.Task task, int EmployeeId)
        {
            task.Employees.Add(context.Employees.FirstOrDefault(e => e.EmployeeId == EmployeeId));
            context.SaveChanges();
        }

        

    }



}
