using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApiMissingOne.Models;
namespace WebApiMissingOne.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class WebApiController : ControllerBase
    {
        
        PracticeDBContext db = new PracticeDBContext();
        // GET: api/Product
        //[HttpGet]
        public IEnumerable<Employee> Get()
        {

            return db.Employee;
        }

        // GET: api/Product/5
        [HttpGet("{eid}", Name = "Get")]
        public IEnumerable<Employee> Get(int id)
        {
            return db.Employee;
        }
     
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }

        // POST: api/Product
        [HttpPost]
        public string Post(object value)
        {
            return "postedd";
        }

        // PUT: api/Product/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

    }
    }