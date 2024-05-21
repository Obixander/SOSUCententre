using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosuCentre.DataAccess;
using SosuCentre.Entities;
namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Entities.Task> GetTaskFor(DateTime date = default)
        {
            SosuCentreContext Context = new SosuCentreContext();
            List<Entities.Task> tasks = Context.Tasks
                .Where(t => t.TimeStart.Date == date.Date)
                .ToList();
                return tasks;
        }

    }
}
