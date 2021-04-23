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
    public ActionResult<IEnumerable<string>> Get()
    {
      return Ok(Bread.Loaves);
    }

    [HttpGet("{id}")]
    public ActionResult<IEnumerable<string>> Get(int id)
    {
      if (id > 100 || id <= 0)
      {
        return BadRequest("ID out of bounds, ID must be integer value between 1 and 100");
      }
      return Ok(Bread.Loaves[id - 1]);
    }
  }
}