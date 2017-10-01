using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DateWebApi.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace DateWebApi.Controllers
{
    [Route("api/[controller]")]
    public class DateController : Controller
    {
        // GET: api/date
        [HttpGet]
        public IActionResult Get()
        {
            Date date = new Date();

            return Ok(date);
        }
        
    }
}
