using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosuCentre.DataAccess;
using SosuCentre.Entities;

namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubTaskController(ISubTaskRepository subTask) : ControllerBase
    {
        private readonly ISubTaskRepository repository = subTask;

        [HttpGet]
        public IEnumerable<SubTask> GetAll()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public void AddNew([FromQuery] SubTask subTask)
        {
            repository.Add(subTask);
        }

        [HttpPut]
        public void UpdateBy([FromQuery] SubTask subTask)
        {
            repository.Update(subTask);
        }

        [HttpDelete]
        public void DeleteBy([FromQuery] SubTask subTask)
        {
            repository.Delete(subTask);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<SubTask> GetBy([FromQuery] int id)
        {
            return repository.GetBy(id);
        }
    }
}
