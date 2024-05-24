using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SosuCentre.DataAccess;
using SosuCentre.Entities;

namespace SosuCentre.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController(IRepository<Role> repository) : Controller
    {
        private readonly IRepository<Role> repository = repository;

    }
}
