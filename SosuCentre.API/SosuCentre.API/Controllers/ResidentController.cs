using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosuCentre.DataAccess;
using SosuCentre.Entities;

namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ResidentController(IRepository<Resident> repository) : Controller
    {
        private readonly IRepository<Resident> repository = repository;

        [HttpGet]
        public IEnumerable<Resident> GetAll()
        {
            return repository.GetAll();
        }
        [HttpPost]
        public void AddNew([FromQuery]Resident resident)
        {
            repository.Add(resident);
        }
        [HttpPut]
        public void UpdateBy([FromQuery] Resident resident)
        {
            repository.Update(resident);
        }
        [HttpDelete]
        public void DeleteBy([FromQuery] Resident resident)
        {
            repository.Delete(resident);
        }
        [HttpGet]
        [Route("GetById")]
        public ActionResult<Resident> GetBy([FromQuery] int id)
        {
            return repository.GetBy(id);
        }


    }
}
