using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using CMS.Data;
using CMS.Data.EFCore;
using CMS.Core.Domain;
using Microsoft.Extensions.Configuration;

namespace Web.Controllers
{
    [ApiController]
    [Route("api/student")]
    public class StudentController : ControllerBase
    {
        // private readonly IConfiguration config;
        // private readonly IRepository _repo;


        // private SchoolContext context;
        // public StudentController(IRepository repo)
        // {
        //     _repo = repo;
        // }

        // [HttpGet]
        // public IActionResult Get()
        // {
        //     return Ok(_repo.GetAll());
        // }

        // [HttpGet]
        // [Route("{id}")]
        // public IActionResult GetStudent([FromRoute] int id)
        // {
        //     return Ok(new { result = "OK", data = _repo.GetById(id) });
        // }


        // [HttpPost]
        // public IActionResult Create([FromBody] Student student)
        // {
        //     _repo.Insert(student);
        //     _repo.Save();
        //     return Ok("Saved!");
        // }

        // [HttpPut]
        // [Route("{id}")]
        // public IActionResult Put([FromBody] Student student, [FromRoute] int id)
        // {
        //     _repo.Update(student);
        //     _repo.Save();
        //     return Ok("OK");
        // }


        // [HttpDelete]
        // [Route("{id}")]
        // public IActionResult Delete([FromRoute] int id)
        // {
        //     _repo.Delete(id);
        //     _repo.Save();
        //     return Ok("OK");
        // }
    }
}