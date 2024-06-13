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
            return context.Assignments
                 .Include(t => t.Employees)
                 .Include(t => t.Resident)
                 .Include(t => t.SubTasks)

                 .FirstOrDefault(t => t.AssignmentId == id);
        }
        public IEnumerable<Entities.Assignment> GetAssignmentsOn(Employee employee, DateTime date)
        {
            IEnumerable<Entities.Assignment> tasks = context.Assignments
                .Where(a => a.Employees.Contains(employee) && a.TimeStart.Date == date.Date)
                .Include(t => t.Resident)
                .Include(t => t.Employees)
                .Include(t => t.SubTasks)
                .ToList();
            return tasks;
        }

        public IEnumerable<Entities.Assignment> GetAssignmentsFor(Employee employee)
        {

            List<Entities.Assignment> tasks = context.Assignments
                .Where(a => a.Employees.Contains(employee))
                .Include(t => t.Resident)
                .Include(t => t.Employees)
                .Include(t => t.SubTasks)

                .ToList();
            return tasks;
        }

        //rewrite this!
        public void AddEmployeeToTask(int taskid, int employeeId)
        {
            //find task based on id
            Assignment task = context.Assignments
                .Include(t => t.Employees)
                .FirstOrDefault(t => t.AssignmentId == taskid);

            //find employee based on id
            Employee employee = context.Employees.Find(employeeId);
            //adds employee to a task
            task.Employees.Add(employee);

            context.SaveChanges();
        }



    }



}
