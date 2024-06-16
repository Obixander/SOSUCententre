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
        public void UpdateBy(Assignment dto ) //dto = data transfer object
        {
            //move the logic to the Taskrepository later
            var assignment = repository.GetBy(dto.AssignmentId);

            //Update database entity with changes from dto
            assignment.Completed = dto.Completed;
            assignment.Notes = dto.Notes;
            assignment.MedicinNotes = dto.MedicinNotes;
            foreach (var subTask in assignment.SubTasks)
            {
                var dtoSubTask = dto.SubTasks.Find(x => x.SubTaskId == subTask.SubTaskId);
                subTask.IsCompleted = dtoSubTask.IsCompleted;
            }
            foreach (var MedicinTask in assignment.MedicineTasks)
            {
                var dtoMedicinTask = dto.MedicineTasks.Find(x => x.MedicineTaskId == MedicinTask.MedicineTaskId);
                MedicinTask.IsCompleted = dtoMedicinTask.IsCompleted;
            }
            repository.Update(assignment);
        }

        //TODO: FIX SOON
        //this is not working as there a circuler ref between Task and Employee 
        [HttpGet("{id}")]
        public ActionResult<Entities.Assignment> GetBy(int id)
        {
            return repository.GetBy(id);
        }


        //this is the main endpoint that will be used
        [HttpGet(nameof(GetAssignmentsOn))]
        public IEnumerable<Entities.Assignment> GetAssignmentsOn([FromQuery] Employee employee, [FromQuery]DateTime date = default)
        {
            return repository.GetAssignmentsOn(employee,date);
        }

        //Dont use not working
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
        public void AddEmployeeToTask([FromQuery] int taskId, [FromQuery] int employeeId)
        {
            repository.AddEmployeeToTask(taskId, employeeId);
            
        }
    }
}
