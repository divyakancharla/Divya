using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ServicesIntro.Repositories;
using ServicesIntro.Models;
namespace ServicesIntro.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ItemController : ControllerBase
    {
        private readonly IItem _it;
        public ItemController(IItem it)
        {
            _it = it;
        }
       
        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_it.GetAllItems());
            }
            catch(Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpGet]
        [Route("get/{id}")]
        public IActionResult GetById(string id)
        {
            try
            {
                return Ok(_it.GetById(id));
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpDelete]
        [Route("delete/{id}")]
        public IActionResult delete(string id)
        {
            try
            {
                _it.delete(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPost]
        [Route("add")]
        public IActionResult Add(Items id)
        {
            try
            {
                _it.AddItems(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        public IActionResult update(Items id)
        {
            try
            {
                _it.update(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}