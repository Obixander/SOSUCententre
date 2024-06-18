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

        //note the residen has AsNoTracking() because it should not be updated from the taskrepository
        public override Entities.Assignment GetBy(int id)
        {
            try
            {
                return context.Assignments
                .Include(t => t.Employees)
                .Include(t => t.Resident)/*.AsNoTracking()*/
                .Include(t => t.SubTasks)
                .Include(t => t.MedicineTasks)

                .FirstOrDefault(t => t.AssignmentId == id);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
        public IEnumerable<Entities.Assignment> GetAssignmentsOn(Employee employee, DateTime date)
        {
            try
            {
                IEnumerable<Entities.Assignment> tasks = context.Assignments
                    .Where(a => a.Employees.Contains(employee) && a.TimeStart.Date == date.Date)
                    .Include(t => t.Resident).AsNoTracking()
                    .Include(t => t.Employees)
                    .Include(t => t.SubTasks)
                    .Include(t => t.MedicineTasks)
                    .ToList();
                return tasks;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        public IEnumerable<Entities.Assignment> GetAssignmentsFor(Employee employee)
        {
            try
            {
                List<Entities.Assignment> tasks = context.Assignments
                    .Where(a => a.Employees.Contains(employee))
                    .Include(t => t.Resident).AsNoTracking()
                    .Include(t => t.Employees)
                    .Include(t => t.SubTasks)
                    .Include(t => t.MedicineTasks)
                    .ToList();
                return tasks;

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }

        //rewrite this!
        public void AddEmployeeToTask(int taskid, int employeeId)
        {
            try
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
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                throw;
            }
        }



    }



}
