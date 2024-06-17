using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosuCentre.DataAccess;
using SosuCentre.Entities;

namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MedicineTaskController(IMedicineTaskRepository repository) : ControllerBase
    {
        private readonly IMedicineTaskRepository repository = repository;

        [HttpGet]
        public IEnumerable<MedicineTask> GetAll()
        {
            return repository.GetAll();
        }

        [HttpPost]
        public void AddNew([FromQuery] MedicineTask medicineTask)
        {
            repository.Add(medicineTask);
        }

        [HttpPut]
        public void UpdateBy([FromQuery] MedicineTask medicineTask)
        {
            repository.Update(medicineTask);
        }

        [HttpDelete]
        public void DeleteBy([FromQuery] MedicineTask medicineTask)
        {
            repository.Delete(medicineTask);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<MedicineTask> GetBy([FromQuery] int id)
        {
            return repository.GetBy(id);
        }
    }
}
