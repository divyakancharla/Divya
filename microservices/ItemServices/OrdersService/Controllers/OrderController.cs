using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using OrdersService.Models;
using OrdersService.Repositories;
namespace OrdersService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OrderController : ControllerBase
    {
        private readonly IOrder _it;
        public OrderController(IOrder it)
        {
            _it = it;
        }

        [HttpGet]
        [Route("get")]
        public IActionResult Get()
        {
            try
            {
                return Ok(_it.Getall());
            }
            catch (Exception e)
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
        public IActionResult AddItems(Orders id)
        {
            try
            {
                _it.AddItems(id);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.InnerException.Message);
            }
        }
        [HttpPut]
        [Route("update")]
        public IActionResult update(Orders id)
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
        [HttpGet]
        [Route("image")]
        public IActionResult image(string img)
        {
            try
            {
                //_it.image(img);
                return Ok();
            }
            catch (Exception e)
            {
                return NotFound(e.Message);
            }
        }
    }
}