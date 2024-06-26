﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelloWorld.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(new { Message = "Hello World" });
        }

        [HttpGet("GetData")]
        public IActionResult GetData()
        {
            return Ok(new { Message = "Your data" });
        }
    }
}
