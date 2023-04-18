using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Data.EFCore;
using CMS.Core.Domain;

using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Web.Areas.cp.Controllers
{
    [ApiController]
    [Route("api/content")]
    public class ContentController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly IRepository<Article> _repo;
        private KhangDB context;
        public ContentController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_repo.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(new { result = "OK", data = _repo.GetById(id) });
        }


        [HttpPost]
        public IActionResult Create([FromBody] Article article)
        {
            _repo.Insert(article);
            _repo.Save();
            return Ok("Saved!");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Article article, [FromRoute] int id)
        {
            _repo.Update(article);
            _repo.Save();
            return Ok("OK");
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _repo.Delete(id);
            _repo.Save();
            return Ok("OK");
        }
    }
}