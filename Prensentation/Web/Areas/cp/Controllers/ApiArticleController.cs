using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CMS.Core.Domain;
using CMS.Data.EFCore;
using CMS.Service.ArticleService;
using CMS.Service.CategoryService;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

namespace Web.Areas.cp.Controllers
{
    [ApiController]
    [Route("api/article")]
    public class ApiArticleController : ControllerBase
    {
        private readonly IConfiguration config;
        private readonly IArticleService _service;
        private HuongDanNetDB context;
        public ApiArticleController(IArticleService service)
        {
            _service = service;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetAll());
        }

        [HttpGet]
        [Route("{id}")]
        public IActionResult GetById([FromRoute] int id)
        {
            return Ok(new { result = "OK", data = _service.GetById(id) });
        }


        [HttpPost]
        public IActionResult Create([FromBody] Article obj)
        {
            _service.Insert(obj);
            _service.Save();
            return Ok("Saved!");
        }

        [HttpPut]
        [Route("{id}")]
        public IActionResult Put([FromBody] Article obj, [FromRoute] int id)
        {
            _service.Update(obj);
            _service.Save();
            return Ok("OK");
        }


        [HttpDelete]
        [Route("{id}")]
        public IActionResult Delete([FromRoute] int id)
        {
            _service.Delete(id);
            _service.Save();
            return Ok("OK");
        }
    }
}