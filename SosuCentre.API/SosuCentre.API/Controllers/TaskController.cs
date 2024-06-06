using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SosuCentre.DataAccess;
using SosuCentre.Entities;
using System.Threading.Tasks;
namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController(ITaskRepository repository) : Controller
    {
        private readonly ITaskRepository repository = repository;

        [HttpPut]
        public void UpdateBy([FromQuery] Entities.Assignment task)
        {
            repository.Update(task);
        }

        //TODO: FIX SOON
        //this is not working as there a circuler ref between Task and Employee 
        [HttpGet("{id}")]
        public ActionResult<Entities.Assignment> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetTasksFor))]
        public IEnumerable<Entities.Assignment> GetTasksFor([FromQuery] Employee employee, [FromQuery]DateTime date = default)
        {
            return repository.GetAssignmentsOn(employee,date);
        }

        [HttpGet(nameof(GetAssignmentsForEmployee))]
        public IEnumerable<Entities.Assignment> GetAssignmentsForEmployee([FromQuery] Employee employee)
        {
            return repository.GetAssignmentsFor(employee);
        }

        [HttpPost]
        public void AddNew(Entities.Assignment task)
        {
           repository.Add(task);
           
        }

        [HttpDelete]
        public void DeleteBy(Entities.Assignment task)
        {
            repository.Delete(task);
        }

        //Will move later
        [HttpPost]
        [Route("AddEmployeeToTask")]
        public void AddEmployeeToTask([FromQuery] Entities.Assignment task, [FromQuery] int EmployeeId)
        {
            repository.AddEmployeeToTask(task, EmployeeId);
            
        }
    }
}
