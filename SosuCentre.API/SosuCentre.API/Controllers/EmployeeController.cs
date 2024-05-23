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
        private readonly IEmployeeRepository repository = repository;

        [HttpPut("{id}")]
        public void UpdateBy(Employee employee)
        {
            repository.Update(employee);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetBy(int id)
        {
            return repository.GetById(id);
        }   

        [HttpPost]
        public void AddNew(Employee employee)
        {
            repository.Add(employee);

        }

        [HttpDelete]
        public void DeleteBy(Employee employee)
        {
            repository.Delete(employee);
        }

    }
}
