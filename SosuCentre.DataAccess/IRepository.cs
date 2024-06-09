using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using SosuCentre.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SosuCentre.DataAccess
{
    public interface IRepository<T>
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        void Delete(int id);
        IEnumerable<T> GetAll();
        T GetBy(int id);
    }

    public interface IResidentRepository : IRepository<Resident>
    {
        Resident GetById(int id);
    }


    public interface ITaskRepository : IRepository<Entities.Assignment>
    {
        IEnumerable<Entities.Assignment> GetAssignmentsOn(Employee employee, DateTime date);
        IEnumerable<Entities.Assignment> GetAssignmentsFor(Employee employee);
        Entities.Assignment GetBy(int id);
        void AddEmployeeToTask(int taskId, int employeeId);

    }

    public interface IEmployeeRepository : IRepository<Employee> 
    {
         Employee GetById(int id);
        IEnumerable<Employee> GetAllBy(Role role);
    }

    public interface IRoleRepository : IRepository<Role>
    {
        Role GetById(int id);
    }
}
