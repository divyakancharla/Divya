using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApiDemo2.Models;
using WebApiDemo2.Repositories;
namespace WebApiDemo2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        CourseRep emp = new CourseRep();
        [Route("getall")]
        public IActionResult Getall()
        {
            return Ok(emp.getall());
        }
        [Route("Get/{item}")]
        public IActionResult Get(int item)
        {
            return Ok(emp.GetById(item));
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Cours item)
        {
            emp.Add(item);

            return Ok();
        }
        [HttpPut]
        [Route("update")]
        public IActionResult update(Cours
            item)
        {
            emp.Update(item);
            return Ok();
        }
        [HttpDelete]
        [Route("delete/{item}")]
        public IActionResult delete(int item)
        {
            emp.Delete(item);
            return Ok("Record Deleted");
        }

    }
}