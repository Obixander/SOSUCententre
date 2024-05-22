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


    public interface ITaskRepository : IRepository<Entities.Task>
    {
        IEnumerable<Entities.Task> GetAssignmentsOn(DateTime date);

        Entities.Task GetById(int id);
    }
}
