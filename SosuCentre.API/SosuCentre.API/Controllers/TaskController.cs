﻿using Microsoft.AspNetCore.Http;
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

        [HttpPut("{id}")]
        public void UpdateBy(Entities.Task task) 
        {
            repository.Update(task);
        }


        [HttpGet("{id}")]
        public ActionResult<Entities.Task> GetBy(int id)
        {        
            return repository.GetById(id);
        }

        [HttpGet]
        [HttpGet(nameof(GetTasksFor))]
        public IEnumerable<Entities.Task> GetTasksFor(DateTime date = default)
        {
            return repository.GetAssignmentsOn(date);
        }

        [HttpPost]
        public void AddNew(Entities.Task task)
        {
           repository.Add(task);
           
        }
        [HttpDelete]
        public void DeleteBy(Entities.Task task)
        {
            repository.Delete(task);
        }

    }
}
