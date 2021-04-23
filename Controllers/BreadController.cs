using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using TheRobeOfBreadSummoning.API.Domain.Models;

namespace TheRobeOfBreadSummoning.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BreadController : ControllerBase
    {

        private readonly ILogger<BreadController> _logger;

        public BreadController(ILogger<BreadController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<string> Get()
        {
            return Ok(Bread.Loaves);
        }

        [HttpGet("{id}")]
        public IEnumerable<string> Get(int id)
        {
            return Ok(Bread.Loaves[id]);
        }
    }
}
