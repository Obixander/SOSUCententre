using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosuCentre.DataAccess;
using SosuCentre.Entities;
namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController(IEmployeeRepository repository) : Controller
    {
        //this is not needed in theory
        private readonly IEmployeeRepository repository = repository;

        [HttpPut]
        public void UpdateBy([FromQuery] Employee employee)
        {
            repository.Update(employee);
        }

        [HttpGet]
        [Route("GetById")]
        public ActionResult<Employee> GetBy([FromQuery] int id)
        {
            return repository.GetById(id);
        }

        [HttpGet]
        [Route("GetAll")]
        public IEnumerable<Employee> GetAll()
        {
            //this is does not return Employee tasks fix later
            return repository.GetAll();
        }

        [HttpGet]
        [Route("GetAllByRole")]
        public IEnumerable<Employee> GetAllBy([FromQuery]Role role)
        {
            return repository.GetAllBy(role);
        }

        [HttpPost]
        public void AddNew([FromQuery]Employee employee)
        {
            repository.Add(employee);

        }

        [HttpDelete]
        public void DeleteBy([FromQuery] Employee employee)
        {
            repository.Delete(employee);
        }

    }
}
