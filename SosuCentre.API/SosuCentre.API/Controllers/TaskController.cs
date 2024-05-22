using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SosuCentre.DataAccess;
using SosuCentre.Entities;
namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        private readonly SosuCentreContext context;

        public TaskController(SosuCentreContext context)
        {
            this.context = context;
        }

        [HttpPut("{id}")]
        public void UpdateBy(int id) 
        {
            //TODO: make this work please
            //context.Tasks.Update();
            context.SaveChanges();
        }


        [HttpGet("{id}")]
        public ActionResult<Entities.Task> GetBy(int id)
        {
            Entities.Task? task = context.Tasks
                .Include(t => t.Resident)
                .FirstOrDefault(t => t.TaskId == id);
            return task;
        }

        [HttpGet]
        public IEnumerable<Entities.Task> GetTasksFor(DateTime date = default)
        {
            List<Entities.Task> tasks = context.Tasks
                .Where(t => t.TimeStart.Date == date.Date)
                .ToList();
            return tasks;
        }

        [HttpPost]
        public void AddNew(Entities.Task task)
        {
            //this is used to allow
            context.Entry(task.Resident).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.Tasks.Add(task);
            context.SaveChanges();
        }

    }
}
