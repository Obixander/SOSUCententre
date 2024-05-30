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
        public void UpdateBy([FromQuery] Entities.Task task)
        {
            repository.Update(task);
        }

        //TODO: FIX SOON
        //this is not working as there a circuler ref between Task and Employee 
        [HttpGet("{id}")]
        public ActionResult<Entities.Task> GetBy(int id)
        {
            return repository.GetBy(id);
        }

        [HttpGet(nameof(GetTasksFor))]
        public IEnumerable<Entities.Task> GetTasksFor([FromQuery] Employee employee, [FromQuery]DateTime date = default)
        {
            return repository.GetAssignmentsOn(employee,date);
        }

        [HttpGet(nameof(GetAssignmentsForEmployee))]
        public IEnumerable<Entities.Task> GetAssignmentsForEmployee([FromQuery] Employee employee)
        {
            return repository.GetAssignmentsFor(employee);
        }

        [HttpPost]
        public void AddNew(Entities.Task task)
        {
           repository.Add(task);
           
        }

        [HttpDelete]
        public void DeleteBy(Entities.Task task)
        {
            repository.Delete(task);
        }

        //Will move later
        [HttpPost]
        [Route("AddEmployeeToTask")]
        public void AddEmployeeToTask([FromQuery] Entities.Task task, [FromQuery] int EmployeeId)
        {
            repository.AddEmployeeToTask(task, EmployeeId);
            
        }
    }
}
