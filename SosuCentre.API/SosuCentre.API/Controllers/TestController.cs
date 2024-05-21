using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SosuCentre.DataAccess;
using SosuCentre.Entities;

namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Employee> GetAll()
        {
            SosuCentreContext sosuCentreContext = new SosuCentreContext();
            List<Employee> employees = sosuCentreContext.Employees
                .Include(employees => employees.Role)
                .Include(employees => employees.CareCenter)
                    .ThenInclude(CareCenter => CareCenter.Address)
                    .Include(employees => employees.CareCenter)
                    .ThenInclude(CareCenter => CareCenter.Residents)
                .Include(employees => employees.Tasks)
                .ToList();
            return employees;
        }

        [HttpGet("{id}")]
        public IEnumerable<Employee> getById(int id)
        {
           //add try catch later
                SosuCentreContext sosuCentreContext = new SosuCentreContext();
                List<Employee> employees = sosuCentreContext.Employees
                    .Where(employees => employees.EmployeeId == id)
                    .Include(employees => employees.Role)
                    .Include(employees => employees.CareCenter)
                        .ThenInclude(CareCenter => CareCenter.Address)
                        .Include(employees => employees.CareCenter)
                        .ThenInclude(CareCenter => CareCenter.Residents)
                    .Include(employees => employees.Tasks)
                    .ToList();
                return employees;
            
            
        }

    }
}
