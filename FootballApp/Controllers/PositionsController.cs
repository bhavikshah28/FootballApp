using Microsoft.AspNetCore.Mvc;
using SportsApp.Models;
using SportsApp.Services;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SportsApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class PositionsController : Controller
    {
        private readonly IPositionService _positionservice;

        public PositionsController(IPositionService positionservice)
        {
            _positionservice = positionservice;
        }

        [HttpGet]
        public async Task<IEnumerable<Position>> Get()
        {
            return await _positionservice.GetPositionsList();
        }
    }
}
